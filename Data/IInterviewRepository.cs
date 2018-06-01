using System.Threading.Tasks;
using Scheduler.API.Models;

namespace Scheduler.API.Data
{
    public interface IInterviewRepository
    {
          Task<Interview> ScheduleInterview(Interview interview);
    }
}