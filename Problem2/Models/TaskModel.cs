using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2.Models
{
    public class TaskModel
    {

        

        public int Id { get; set; }
        public string Titull { get; set; }
        public string Pershkrim { get; set; }
        public List<Schedules> schedules { get; set; }

    }
}
