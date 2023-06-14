namespace Podcast.DAL.Entities
{
    public class Episode : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CornerImageUrl { get; set; }
        public string BackgroundImageUrl { get; set; }
        public int Minute { get; set; }
        public int ListeningCount { get; set; }
        public int SpeakerId { get; set; }
        public Speaker Speaker { get; set; }
    }
}
