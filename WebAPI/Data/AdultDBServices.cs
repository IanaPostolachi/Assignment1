using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebApi.Data.DBAdults;
using WebApi.Model;
using WebApi.Persistence;

namespace WebApi.Data.DBAdults
{
    public class AdultDBServices : IAdultsServices
    {
        private AdultDBContext AdultDbContext;

        public AdultDBServices(AdultDBContext context)
        {
            AdultDbContext = context;
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            return await AdultDbContext.
                Adults.
                Include(adult => adult.Job).
                ToListAsync();
        }
        
        public async Task<IList<Job>> GetJobsAsync()
        {
            return await AdultDbContext.Jobs.ToListAsync();
        }

        public async Task<Adult> AddAdultsAsync(Adult adult)
        {
            EntityEntry<Adult> addedAdult = await AdultDbContext.Adults.AddAsync(adult);
            EntityEntry<Job> newJob = await AdultDbContext.Jobs.AddAsync(adult.Job);
            Console.WriteLine("New user!!!" + addedAdult.Entity);
            await AdultDbContext.SaveChangesAsync();
            return addedAdult.Entity;
        }

        public async Task RemoveAdultsAsync(int Id)
        {
            Adult adultToDelete = await AdultDbContext.Adults.FirstOrDefaultAsync(a => a.Id == Id);
            if (adultToDelete != null)
            {
                AdultDbContext.Adults.Remove(adultToDelete);
                await AdultDbContext.SaveChangesAsync();
            }
        }
    }
}