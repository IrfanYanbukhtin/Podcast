namespace Podcast.DAL.Entities
{
    public class Speaker : Entity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Episode> Episodes { get; set; }
        public ICollection<SpeakerTopics> SpeakerTopics { get; set; }
    }
}
