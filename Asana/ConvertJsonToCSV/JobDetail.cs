using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConvertJsonToCSV
{
    public class JobDetail
    {

        public class Rootobject
        {
            public Datum[] data { get; set; }
        }

        public class Datum
        {
            public long id { get; set; }
            public DateTime created_at { get; set; }
            public DateTime modified_at { get; set; }
            public string name { get; set; }
            public string notes { get; set; }
            public bool completed { get; set; }
            public string assignee_status { get; set; }
            public DateTime? completed_at { get; set; }
            public string due_on { get; set; }
            public DateTime? due_at { get; set; }
            public Workspace workspace { get; set; }
            public int num_hearts { get; set; }
            public object parent { get; set; }
            public Subtask[] subtasks { get; set; }
            public Heart[] hearts { get; set; }
            public Project[] projects { get; set; }
            public Tag1[] tags { get; set; }
            public Membership[] memberships { get; set; }
            public object[] custom_fields { get; set; }
            public bool hearted { get; set; }
            public Assignee assignee { get; set; }
            public Follower1[] followers { get; set; }
        }

        public class Workspace
        {
            public long id { get; set; }
            public string name { get; set; }
        }

        public class Assignee
        {
            public long id { get; set; }
            public string name { get; set; }
        }

        public class Subtask
        {
            public long id { get; set; }
            public DateTime created_at { get; set; }
            public DateTime modified_at { get; set; }
            public string name { get; set; }
            public string notes { get; set; }
            public bool completed { get; set; }
            public string assignee_status { get; set; }
            public DateTime? completed_at { get; set; }
            public object due_on { get; set; }
            public object due_at { get; set; }
            public Workspace1 workspace { get; set; }
            public int num_hearts { get; set; }
            public Assignee1 assignee { get; set; }
            public Parent parent { get; set; }
            public object[] subtasks { get; set; }
            public object[] hearts { get; set; }
            public Follower[] followers { get; set; }
            public object[] projects { get; set; }
            public Tag[] tags { get; set; }
            public object[] memberships { get; set; }
            public object[] custom_fields { get; set; }
            public bool hearted { get; set; }
        }

        public class Workspace1
        {
            public long id { get; set; }
            public string name { get; set; }
        }

        public class Assignee1
        {
            public long id { get; set; }
            public string name { get; set; }
        }

        public class Parent
        {
            public long id { get; set; }
            public string name { get; set; }
        }

        public class Follower
        {
            public long id { get; set; }
            public string name { get; set; }
        }

        public class Tag
        {
            public long id { get; set; }
            public string name { get; set; }
        }

        public class Heart
        {
            public long id { get; set; }
            public User user { get; set; }
        }

        public class User
        {
            public long id { get; set; }
            public string name { get; set; }
        }

        public class Project
        {
            public long id { get; set; }
            public string name { get; set; }
        }

        public class Tag1
        {
            public long id { get; set; }
            public string name { get; set; }
        }

        public class Membership
        {
            public Project1 project { get; set; }
            public object section { get; set; }
        }

        public class Project1
        {
            public long id { get; set; }
            public string name { get; set; }
        }

        public class Follower1
        {
            public long id { get; set; }
            public string name { get; set; }
        }

    }
}