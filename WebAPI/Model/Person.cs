using System.ComponentModel.DataAnnotations;

namespace WebApi.Model
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        [Range(1, 120, ErrorMessage = "Enter a valid age")]
        [Required]
        public int Age { get; set; }
        public float Weight { get; set; }
        public int Height { get; set; }
        [Required]
        public string Sex { get; set; }
    }
}