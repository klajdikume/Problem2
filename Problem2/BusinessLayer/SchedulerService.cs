using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Problem2.BusinessLayer
{
    public class SchedulerService
    {
        private static SchedulerService _instance = null;
        private readonly static object myObj = new object();

        private List<Timer> timers = new List<Timer>();

        // Thread safe singleton
        public static SchedulerService Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (myObj)
                    {
                        if (_instance == null) _instance = new SchedulerService();
                    }
                }

                return _instance;
            }
        }

        public void ScheduleTask(int year, int month, int day, int hour, int minute, int second, int milisecond, int interval, Action task)
        {
            DateTime now = DateTime.Now;
            DateTime firstRun = new DateTime(year, month, day, hour, minute, second, milisecond);

            TimeSpan timeToGo = firstRun - now;

            if (timeToGo <= TimeSpan.Zero)
            {
                timeToGo = TimeSpan.Zero;
            }

            var timer = new Timer(x =>
            {
                task.Invoke();

            }, null, timeToGo, TimeSpan.FromHours(interval));

            timers.Add(timer);

        }

    }
}
