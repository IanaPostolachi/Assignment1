using System.Collections.Generic;
using Assignment.Data;

namespace Assignment.Model
{
    public class Child : Person
    {
        public List<Interest> Interests { get; set; }
        public List<Pet> Pets { get; set; }
    }
}