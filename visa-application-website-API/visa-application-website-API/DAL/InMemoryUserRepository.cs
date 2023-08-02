using visa_application_website_API.Models;

namespace visa_application_website_API.DAL
{
    public class InMemoryUserRepository : IRepository<User>
    {
        private readonly List<User> _users;

        public InMemoryUserRepository() {
            _users = new List<User>() {
                new User(01, "Csirkés István", "csirkes@gmail.com")
            };

        }


        public void Add(User user)
        {
            _users.Add(user);
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id)!;
        }

        public void Update(User user)
        {
            var userToUpdate = GetById(user.Id);

            userToUpdate.Name = user.Name;
            userToUpdate.Email = user.Email;
        }

        public void Delete(int id)
        {
            _users.Remove(_users.FirstOrDefault(user => user.Id == id)!);
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }
    }
}
