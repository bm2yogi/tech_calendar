namespace TechCalendar.MeetupAPI
{
    public interface IMeetupConfig
    {
        string RecommendedEventsUrl { get; set; }
    }

    public class MeetupConfig : IMeetupConfig
    {
        public string RecommendedEventsUrl { get; set; }
    }
}