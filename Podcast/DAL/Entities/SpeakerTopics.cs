namespace Podcast.DAL.Entities
{
    public class SpeakerTopics : Entity
    {
        public int SpeakerId { get; set; }
        public Speaker Speaker { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
