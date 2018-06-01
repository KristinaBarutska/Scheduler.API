using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scheduler.API.Data;
using Scheduler.API.Dtos;
using Scheduler.API.Models;

namespace Scheduler.API.Controllers
{
    [Route("api/[controller]")]
    public class InterviewController : Controller
    {
        private readonly IInterviewRepository _repo;
        public InterviewController(IInterviewRepository repo)
        {
            _repo = repo;

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInterview(int id)
        {
           var interview = await _repo.GetInterview(id);
           return Ok(interview);
        }

        [HttpPost("save")]
        public async Task<IActionResult> Save([FromBody]InterviewToBeScheduledDto interviewToBeScheduledDto)
        {
            var interview =new Interview();
            interview.Recruiter.Id=1;
            interview.InterviewDate= interviewToBeScheduledDto.date;
            
           
            var scheduledInterview= await _repo.ScheduleInterview(interview);
            return Ok();
        }

    }
}