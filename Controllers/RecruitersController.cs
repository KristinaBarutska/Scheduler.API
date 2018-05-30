using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scheduler.API.Data;

namespace Scheduler.API.Controllers
{
    [Route("api/[controller]")]
    public class RecruitersController : Controller
    {
        private readonly DataContext _context;

        public RecruitersController(DataContext context){
            _context = context;
        }
        // GET api/recruiters
        [HttpGet]
        public async Task<IActionResult> GetRecruiters()
        {
            var recruiters = await _context.Recruiters.ToListAsync();
            return Ok(recruiters);
        }

        // GET api/recruiters/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecruiter(int id)
        {
           var recruiter = await _context.Recruiters.FirstOrDefaultAsync(x =>x.Id==id);
           return Ok(recruiter);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
