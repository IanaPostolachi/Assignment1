using System.ComponentModel.DataAnnotations;

namespace WebApi.Model
{
    public class Job
    {
        [Key]
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }
}