using System;

namespace Scheduler.API.Models
{
    public class Interview
    {
        public int Id{get;set;}
        public Recruiter Recruiter{get; set;}
        public DateTime InterviewDate {get; set;}
        public string Notes {get; set;}
    }
}