using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WebApplicationBasic.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public bool Repinned { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string LocalizedCountryName { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Address2 { get; set; }
    }

    public class Group
    {
        public object Created { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public string JoinMode { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Urlname { get; set; }
        public string Who { get; set; }
        public string LocalizedLocation { get; set; }
        public string Region { get; set; }
    }

    public class MeetupEvent
    {
//        public object Created { get; set; }
//        public int Duration { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
//        public string Status { get; set; }
        public long Time { get; set; }
//        public object Updated { get; set; }
//        public int UtcOffset { get; set; }
//        public int WaitlistCount { get; set; }
        [JsonProperty("yes_rsvp_count")]
        public int YesRsvpCount { get; set; }
        public Venue Venue { get; set; }
        public Group Group { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
//        public string HowToFindUs { get; set; }
//        public string Visibility { get; set; }
//        public int? RsvpLimit { get; set; }
//        public int? ManualAttendanceCount { get; set; }
//        public string RsvpOpenOffset { get; set; }
    }
}