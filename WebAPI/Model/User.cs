using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApi.Model
{
    public class User
    {
        [Key]
        [Required]
        public string UserName
        {
            set;
            get;
        }

        [Required]
        public string Password
        {
            set;
            get;
        }
        
        public string City
        {
            set;
            get;
        }

        public int BirthYear
        {
            set;
            get;
        }

        public string Role
        {
            set;
            get;
        }
    }
}