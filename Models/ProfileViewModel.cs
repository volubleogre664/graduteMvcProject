namespace FirstMVCProject.Models
{
    public class ProfileViewModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DOB { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }

        public string City { get; set; } 

        public ProfileViewModel(string _name, string _surname, DateTime _dob, int _age, string _country, string _city)
        {
            this.Name = _name;
            this.Surname = _surname;
            this.DOB = _dob;
            this.Age = _age;
            this.Country = _country;
            this.City = _city;
        }

    }
}