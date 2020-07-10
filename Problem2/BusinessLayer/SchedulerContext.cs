using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2.BusinessLayer
{
    public static class SchedulerContext
    {
        public static void  IntervalInSeconds(int year,int month, int day, int hour, int minute, int second, int milisecond,int interval, Action task)
        {
            interval = interval / 3600;
            SchedulerService.Instance.ScheduleTask(year, month, day, hour, minute, second, milisecond, interval, task);
        }
        public static void IntervalInMinutes(int year, int month, int day, int hour, int minute, int second, int milisecond, int interval, Action task)
        {
            interval = interval / 60;
            SchedulerService.Instance.ScheduleTask(year, month, day, hour, minute, second, milisecond, interval, task);
        }

        public static void IntervalInHours(int year, int month, int day, int hour, int minute, int second, int milisecond, int interval, Action task)
        {
            SchedulerService.Instance.ScheduleTask(year, month, day, hour, minute, second, milisecond, interval, task);
        }
    }
}
