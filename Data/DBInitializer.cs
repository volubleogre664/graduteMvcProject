using FirstMVCProject.Models;
using System;
using System.Linq;

namespace FirstMVCProject.Data
{
    public class DBInitializer
    {
        public static void Initialize(ProfileContext context)
        {
            context.Database.EnsureCreated();

            // Look for any profiles initialized

            if (context.UserProfiles.Any()) 
            {
                return;
            }

            /*context.UserProfiles.AddRange(
                new ProfileViewModel("Nduduzo", "Shabalala", DateTime.Now, 32, "Russia", "Moscow"),
                new ProfileViewModel("Walter", "White", DateTime.Now, 52, "United States", "New Mexico")
             );*/
            
            context.SaveChanges();
        }
    }
}
