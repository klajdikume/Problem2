using System;

namespace Problem2.Models
{
    public class Schedules
    {
        public int Id { get; set; }
        public int Intervali { get; set; }
        //public DateTime TimeScheduled { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public int Milisecond { get; set; }
        public int TypeScheduleId { get; set; }
        public TypeSchedule typeSchedule { get; set; }
    }
}