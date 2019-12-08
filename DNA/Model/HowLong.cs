using System;

namespace DNA.Model
{
    public class HowLong
    {
        public DateTime CurrentUtcTime { get; set; }
        public DateTime NextMeetingTime { get; set; } //=> DateTime.Parse("2019/12/18");

        public int Hours => (int)(NextMeetingTime - CurrentUtcTime).TotalHours;
        
        public int Days => (int)(NextMeetingTime - CurrentUtcTime).TotalDays;
        
        public int AnimeChapters => (int)(NextMeetingTime - CurrentUtcTime).TotalHours * 60 / 24;
    }
}