using System.ComponentModel.DataAnnotations;

namespace FirstMVCProject.Models
{
    public class ProfileModel
    {
        [Key]
        public int? ID { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public DateTime DOB { get; set; }

        public int? Age { get; set; }

        public string? Country { get; set; }

        public string? City { get; set; }

    }
}