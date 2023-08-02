using visa_application_website_API.Models;

namespace visa_application_website_API.Services
{
    public interface IUserService
    {
        void Add(User user);
        User GetById(int id);
        void Update(User bike);
        void Delete(int id);
        IEnumerable<User> GetAll();
    }
}
