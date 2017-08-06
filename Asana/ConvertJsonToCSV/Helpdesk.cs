using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConvertJsonToCSV
{
    public class Helpdesk
    {
        
        public string id { get; set; }
        public string project_name { get; set; }
        public string assignee { get; set; }
        public string name { get; set; }
        public DateTime created_at { get; set; }
        public string completed_at { get; set; }
        public string completed { get; set; }
        public string durationString { get; set; }
        public int durationInt { get { return Int32.Parse(durationString); } set { Int32.Parse(durationString); } }
        public bool isComplete { get; set; }


    }


}
