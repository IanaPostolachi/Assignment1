using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment.Model
{
    public class User
    {
        public string UserName
        {
            set;
            get;
        }

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