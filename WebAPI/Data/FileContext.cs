using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment.Model;
using Assignment.Pages;
using Adult = WebApi.Model.Adult;

namespace WebApi.Data
{
    public class FileContext : IFileContext
    {
        public IList<Family> Families { get; private set; }
        public IList<Adult> Adults { get; private set; }

        private readonly string familiesFile = "families.json";

        private readonly string adultsFile =
            "C:/Users/Iana Postolachi/RiderProjects/Assignment1/Assignment/adults.json";

        public FileContext()
        {
            Seed();
            Families = File.Exists(familiesFile) ? ReadDataFormFamilies<Family>(familiesFile) : new List<Family>();
            Adults = File.Exists(adultsFile) ? ReadDataFromAdults<Adult>(adultsFile) : new List<Adult>();
        }

        public void Seed()
        {
            Adults = ReadDataFromAdults<Adult>(adultsFile);

            Console.WriteLine(Adults.Count);
            Console.WriteLine(Adults[6].Id + "LALALALAL");
        }

        // public async Task<IList<Family>> GetFamiliesAsync()
        // {
            // List<Family> tmp = new List<Family>(Families);
            // return tmp;
        // }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            List<Adult> tmp = new List<Adult>(Adults);
            return tmp;
        }
        
        public async Task<Adult> AddAdultsAsync(Adult adult)
        {
            int max = Adults.Max(adult => adult.Id);
            adult.Id = ++max;
            Adults.Add(adult);
            SaveChanges();
            return adult;
        }

        public async Task RevomeAdultsAsync(int Id)
        {
            Adult adultToRemove = Adults.First(a => a.Id == Id);
            Adults.Remove(adultToRemove);
            SaveChanges();
        }


        private IList<T> ReadDataFromAdults<T>(string s)
        {
            using (var jsonReader = File.OpenText(adultsFile))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }
        
        private IList<T> ReadDataFormFamilies<T>(string s)
        {
            using (var jsonReader = File.OpenText(familiesFile))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public void SaveChanges()
        {
            // storing families
            string jsonFamilies = JsonSerializer.Serialize(Families, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(familiesFile, false))
            {
                outputFile.Write(jsonFamilies);
            }

            // storing persons
            string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }
    }
}