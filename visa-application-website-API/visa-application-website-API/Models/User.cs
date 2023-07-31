using System.Numerics;
using System.Xml.Linq;

namespace visa_application_website_API.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Day> Days { get; private set; }


        /*protected User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }*/
    }

}