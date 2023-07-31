namespace visa_application_website_API.Models
{
    public class Day
    {
        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public int userId { get; private set; }
        public User User { get; private set; }

    }
}