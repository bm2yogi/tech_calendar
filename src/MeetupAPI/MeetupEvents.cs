using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using WebApplicationBasic.Models;

namespace TechCalendar.MeetupAPI
{
    public interface IMeetupEvents
    {
        IEnumerable<MeetupEvent> GetEvents();
    }

    public class MeetupEvents : IMeetupEvents
    {
        private readonly MeetupConfig _meetupConfig;

        public MeetupEvents(IOptions<MeetupConfig> meetupOptions)
        {
            _meetupConfig = meetupOptions.Value;
        }
        public IEnumerable<MeetupEvent> GetEvents()
        {
            var client = new HttpClient();
            var requestUri = _meetupConfig.RecommendedEventsUrl;
            var content = client.GetAsync(requestUri).Result.Content;
            var json = content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<IEnumerable<MeetupEvent>>(json);
            return result;
        }
    }
}