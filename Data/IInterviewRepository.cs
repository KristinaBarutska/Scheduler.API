using System.Threading.Tasks;
using Scheduler.API.Dtos;
using Scheduler.API.Models;

namespace Scheduler.API.Data
{
    public interface IInterviewRepository
    {
        Task<Interview> GetInterview(int id);
        Task<Interview> ScheduleInterview(Interview interview);
    }
}