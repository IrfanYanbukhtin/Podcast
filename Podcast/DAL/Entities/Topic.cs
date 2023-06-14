namespace Podcast.DAL.Entities
{
    public class Topic : Entity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<SpeakerTopics> SpeakerTopics { get; set; }
    }
}
