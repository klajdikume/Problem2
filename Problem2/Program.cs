using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml;
using Newtonsoft.Json;
using Problem2.BusinessLayer;
using Problem2.Models;

namespace Problem2
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            var DatabasePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "Models", "Database");

           // var _schedules = File.ReadAllText("../Models/Database/Schedules.json");
            //var _TaskModel = File.ReadAllText("../Models/Database/TaskModel.json");
           // var _TypeSchedule = File.ReadAllText("../Models/Database/TypeSchedule.json");

            var _schedules = Path.Combine(DatabasePath, "Schedules.json");
            var _TaskModel = Path.Combine(DatabasePath, "TaskModel.json");
            var _TypeSchedule = Path.Combine(DatabasePath, "TypeSchedule.json");

            //var schedulesfile = File.ReadAllText(_schedules);
            //var schedules = JsonConvert.DeserializeObject<List<Schedules>>(schedulesfile);
            
            var tasksModelfile = File.ReadAllText(_TaskModel);
            var taskModels = JsonConvert.DeserializeObject<List<TaskModel>>(tasksModelfile);

            foreach(var task in taskModels)
            {
                var schedules_of_this_task = task.schedules.ToList();
                
                foreach(var sc in schedules_of_this_task)
                {
                    var tipi = sc.typeSchedule.Type;

                    switch (tipi) 
                    {
                        case "Secondly":
                            {
                                SchedulerContext.IntervalInSeconds(sc.Year,sc.Month,sc.Day,sc.Hour,sc.Minute,sc.Second,sc.Milisecond,sc.Intervali,() =>
                                {
                                    Console.WriteLine($"{task.Titull}: {task.Pershkrim} /// scheduled at (loading...)");
                                });
                                break;
                            }
                        case "Minute":
                            {
                                SchedulerContext.IntervalInSeconds(sc.Year, sc.Month, sc.Day, sc.Hour, sc.Minute, sc.Second, sc.Milisecond, sc.Intervali, () =>
                                {
                                    Console.WriteLine($"{task.Titull}: {task.Pershkrim} /// scheduled at (loading...)");
                                });
                                break;
                            }
                        case "Hourly":
                            {
                                SchedulerContext.IntervalInSeconds(sc.Year, sc.Month, sc.Day, sc.Hour, sc.Minute, sc.Second, sc.Milisecond, sc.Intervali, () =>
                                {
                                    Console.WriteLine($"{task.Titull}: {task.Pershkrim} /// scheduled at (loading...)");
                                });
                                break;
                            }
                        default:
                            {
                                SchedulerContext.IntervalInSeconds(sc.Year, sc.Month, sc.Day, sc.Hour, sc.Minute, sc.Second, sc.Milisecond, sc.Intervali, () =>
                                {
                                    Console.WriteLine($"{task.Titull}: {task.Pershkrim} /// scheduled at (loading...)");
                                });
                                break;
                            }
                    }
                }
                
            }

            Console.ReadKey();
        }

    }
}

