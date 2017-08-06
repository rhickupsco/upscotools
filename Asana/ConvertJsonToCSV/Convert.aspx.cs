using System.IO;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Data;
using System.Web.UI.WebControls;

namespace ConvertJsonToCSV
{
    public partial class Convert : System.Web.UI.Page
    {
        const string json_file_path = @"C:\AsanaExports\result.json";
       // const string json_File_Path_dev = @"X:\AsanaExports\result.json";
        public List<double> TotalTime = new List<double>();
        public static int numberOfMinutesInBusinessDay = 540;
        public List<double> DaysOpen = new List<double>();
        public string AverageDaysToComplete { get; set; }
        public string AverageDaysOpen { get; set; }
        public string QuantityOpenTotal { get; set; }
        public string CompleteTotal { get; set; }
        public string PercentageCompleteTotal { get; set; }
        public string InclusiveDates { get; set; }

        public string TotalHelpdeskCount { get; set; }

        public int IssuesCompleted { get; set; }

        public int IntIssuesNotCompleted { get; set; }

        public List<Helpdesk> Issues = new List<Helpdesk>();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (gvIssues.Columns.Count > 0)
                {
                    imageHolder.Visible = false;
                    gvIssues.Visible = true;

                }
            }

        }


        protected void btnConvert_Click(object sender, EventArgs e)
        {

            if (FindFile())
            {
                StreamReader sr = new StreamReader(File.OpenRead(json_file_path));

                

                string jsonBody = sr.ReadToEnd();

                JobDetail.Rootobject jobDetail;
                jobDetail = JsonConvert.DeserializeObject<JobDetail.Rootobject>(jsonBody);

                foreach (JobDetail.Datum jobDetailEntry in jobDetail.data)
                {
                    bool completedStatus = jobDetailEntry.completed;
                    if (completedStatus)
                    {
                        string jobid = jobDetailEntry.id.ToString();
                        string projectName = jobDetailEntry.projects[0].name;
                        string taskName = jobDetailEntry.name;
                        string assignee;
                        try
                        {
                            assignee = jobDetailEntry.assignee.name;
                        }
                        catch (Exception)
                        {
                            assignee = "Not Assigned";
                        }

                        DateTime jobCreated = jobDetailEntry.created_at.ToLocalTime();
                        DateTime? jobCompleted = jobDetailEntry.completed_at;

                        if (jobCompleted.HasValue)
                        {
                            jobCompleted = System.Convert.ToDateTime(jobDetailEntry.completed_at).ToLocalTime();
                        }

                        if (!String.IsNullOrEmpty(assignee) && assignee != "Not Assigned")
                        {
                            assignee = jobDetailEntry.assignee.name;
                        }

                        if (!String.IsNullOrEmpty(projectName))
                        {
                            projectName = jobDetailEntry.projects[0].name.ToString();
                        }

                        if (!String.IsNullOrEmpty(taskName))
                        {
                            taskName = jobDetailEntry.name.ToString();
                        }



                        Issues.Add(new Helpdesk()
                        {
                            id = jobid.ToString(),
                            project_name = projectName.ToString(),
                            created_at = jobCreated.ToLocalTime(),
                            name = taskName.ToString(),
                            assignee = assignee.ToString(),
                            completed = completedStatus.ToString(),
                            completed_at = jobCompleted.ToString(),
                            durationString = CalculateDuration(jobCompleted, jobCreated),
                            isComplete = true

                        });

               
                    }


                    else
                    {
                        string jobid = jobDetailEntry.id.ToString();
                        string projectName = jobDetailEntry.projects[0].name;
                        string taskName = jobDetailEntry.name;
                        string assignee;

                        try
                        {
                            assignee = jobDetailEntry.assignee.name;
                        }
                        catch (Exception)
                        {
                            assignee = "Not Assigned";
                        }

                        DateTime jobCreated = jobDetailEntry.created_at.ToLocalTime();


                        if (!String.IsNullOrEmpty(assignee) && assignee != "Not Assigned")
                        {
                            assignee = jobDetailEntry.assignee.name;
                        }

                        if (!String.IsNullOrEmpty(projectName))
                        {
                            projectName = jobDetailEntry.projects[0].name;
                        }

                        if (!String.IsNullOrEmpty(taskName))
                        {
                            taskName = jobDetailEntry.name;
                        }

                        Issues.Add(new Helpdesk()
                        {
                            id = jobid.ToString(),
                            project_name = projectName.ToString(),
                            created_at = jobCreated.ToLocalTime(),
                            name = taskName.ToString(),
                            assignee = assignee.ToString(),
                            completed = completedStatus.ToString(),
                            completed_at = "InComplete",
                            durationString = CalculateWait(jobCreated),
                            isComplete = false

                        });


                    }

                }

                
                CalculateAverageCompletionTime();
                CalculateAverageDaysOpen(Issues.Where(p => p.isComplete == true && p.created_at >= DateTime.Now.AddDays(-90)).Count(), Issues.Where(p => p.isComplete == true && p.created_at >= DateTime.Now.AddDays(-90)).Sum(item => item.durationInt));
                DataBind();

                var sortedResults = Issues.OrderBy(c => c.isComplete).ThenByDescending(r => r.created_at.Date).ThenByDescending(t => t.durationInt);

                gvIssues.DataSource = sortedResults;
                gvIssues.DataBind();

            }

        }

        private string CalculateDuration(DateTime? jobCompleted, DateTime jobCreated)
        {
            string timeElapsed;
            if (jobCompleted.HasValue)
            {
                DateTime tmpJobComplete = new DateTime();
                tmpJobComplete = System.Convert.ToDateTime(jobCompleted).ToLocalTime();

                int count = 0;

                for (var i = jobCreated; i < jobCompleted; i = i.AddMinutes(1))
                {
                    if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                    {
                        if (i.TimeOfDay.Hours >= 8 && i.TimeOfDay.Hours < 17)
                        {
                            count++;
                        }
                    }
                }

                //this is the piece of code that reports on LAST WEEK Monday through Friday
                DayOfWeek weekStart = DayOfWeek.Monday; // or Sunday, or whenever
                DateTime startingDate = DateTime.Today;

                while (startingDate.DayOfWeek != weekStart)
                    startingDate = startingDate.AddDays(-1);

                DateTime previousWeekStart = startingDate.AddDays(-7);
                DateTime previousWeekEnd = startingDate.AddDays(-1);

                InclusiveDates = previousWeekStart.ToShortDateString() + " through " + previousWeekEnd.ToShortDateString();
                //This is the end of the code that reports on LAST WEEK Monday through Friday


                if (jobCompleted >= previousWeekStart && jobCompleted <= previousWeekEnd)
                {
                    UpdateDurationTotal(count);
                    IssuesCompleted += 1;
                }
                timeElapsed = count.ToString();
            }
            else { 
            timeElapsed = "Job Not Complete";
               
            }


            return timeElapsed;
        }

        private void UpdateDurationTotal(int count)
        {

            TotalTime.Add((double)count);
        }

        private void UpdateOpenTotal(int count)
        {

            DaysOpen.Add((double)count);

        }



        private string CalculateWait(DateTime jobCreated)
        {
            string timeElapsed;

            DateTime nowTime = new DateTime();

            int count = 0;
            nowTime = DateTime.Now;

            for (var i = jobCreated; i < nowTime; i = i.AddMinutes(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (i.TimeOfDay.Hours >= 8 && i.TimeOfDay.Hours < 17)
                    {
                        count++;
                    }
                }
            }

            //this is the piece of code that reports on LAST WEEK Monday through Friday
            DayOfWeek weekStart = DayOfWeek.Monday; // or Sunday, or whenever
            DateTime startingDate = DateTime.Today;

            while (startingDate.DayOfWeek != weekStart)
                startingDate = startingDate.AddDays(-1);

            DateTime previousWeekStart = startingDate.AddDays(-7);
            DateTime previousWeekEnd = startingDate.AddDays(-1);

            InclusiveDates = previousWeekStart.ToShortDateString() + " through " + previousWeekEnd.ToShortDateString();
            //This is the end of the code that reports on LAST WEEK Monday through Friday


            if (jobCreated >= previousWeekStart && jobCreated <= previousWeekEnd)
            {
                UpdateOpenTotal(count);
                IntIssuesNotCompleted += 1;
            }
            timeElapsed = count.ToString();
            return timeElapsed;
        }

        private bool FindFile()
        {
            bool result = false;

            result = File.Exists(json_file_path);

            return result;
        }

        private void CalculateAverageDaysOpen(int totalTicketCount, int totalTicketElapsedMinutes)
        {
            double sum = totalTicketElapsedMinutes;
           
            AverageDaysOpen = "Average Number of Business Days a Ticket Remained Open Over Past 90 Day Period : " + String.Format("{0:N2}", ((sum / numberOfMinutesInBusinessDay) / totalTicketCount)).ToString();
            QuantityOpenTotal = "Total Helpdesks Open: " + DaysOpen.Count.ToString();
        }

        private void CalculateAverageCompletionTime()
        {
            double sum = 0;
            foreach (double instance in TotalTime)
            {
                sum += instance;
            }
            AverageDaysToComplete = "Completed (This week) Average Days A Ticket Remained Open: " + String.Format("{0:N2}", ((sum / numberOfMinutesInBusinessDay) / TotalTime.Count)).ToString();
            CompleteTotal = "Total Helpdesks Completed This Week: " + IssuesCompleted.ToString();
            TotalHelpdeskCount = "Total Helpdesks Started This Week: " + (IssuesCompleted + IntIssuesNotCompleted).ToString();
            PercentageCompleteTotal = "Percentage of Helpdesks Closed This Week: " + String.Format("{0:N2}", ((Double)IssuesCompleted / (IssuesCompleted + IntIssuesNotCompleted)) * 100).ToString() + "%";
        }
    }
}