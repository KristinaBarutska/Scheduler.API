using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Scheduler.API.Dtos;
using Scheduler.API.Models;

namespace Scheduler.API.Data
{
    public class InterviewRepository : IInterviewRepository
    {
        private readonly DataContext _context;
        public InterviewRepository(DataContext context)
        {
            _context = context;

        }

        public async Task<Interview> GetInterview(int id)
        {
            var interview = await _context.Interviews.FirstOrDefaultAsync(x =>x.Id==id);
           return interview;
        }

        public Task<Interview> ScheduleInterview(Interview interview)
        {
            throw new System.NotImplementedException();
        }
    }
     
    }
