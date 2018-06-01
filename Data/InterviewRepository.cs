using System.Threading.Tasks;
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
     async Task<Interview> IInterviewRepository.ScheduleInterview(Interview interview)
        {
            //interview.InterviewDate= interview.InterviewDate.ToString();
            await _context.Interviews.AddAsync(interview);
            await _context.SaveChangesAsync();

            return interview;
        }
    }
}