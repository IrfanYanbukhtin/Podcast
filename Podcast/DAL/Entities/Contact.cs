namespace Podcast.DAL.Entities
{
    public class Contact : Entity
    {
        public string Title { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}
