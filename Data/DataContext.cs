using Microsoft.EntityFrameworkCore;
using Scheduler.API.Models;

namespace Scheduler.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) {}
        public DbSet <Recruiter> Recruiters {get; set;}
    }
}