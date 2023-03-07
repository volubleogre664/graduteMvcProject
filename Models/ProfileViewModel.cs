namespace FirstMVCProject.Models
{
    public class ProfileViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DOB { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }

        public string City { get; set; } 

        /*public ProfileViewModel(string Name, string Surname, DateTime DOB, int Age, string Country, string City)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.DOB = DOB;
            this.Age = Age;
            this.Country = Country;
            this.City = City;
        }*/

    }

    public static class MyExtensions
    {
        public static string ToDateOnlyString(this DateTime date)
        {
            var str = date.ToLongDateString();

            return str.Split(",")[1];
        }
    }
}