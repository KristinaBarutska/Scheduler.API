using System.Threading.Tasks;
namespace Scheduler.API.Services
{
    public interface IEmailService
    {
         Task SendEmail(string email, string message);
    }
}