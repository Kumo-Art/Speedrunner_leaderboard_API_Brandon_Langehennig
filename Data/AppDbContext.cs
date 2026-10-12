using Microsoft.EntityFrameworkCore;
using Speedrunner_leaderboard_API_Brandon_Langehennig.Models;

namespace Speedrunner_leaderboard_API_Brandon_Langehennig.Data
{
    public class AppDbContext : DbContext
    {
        

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Run> Runs { get; set; }

        public DbSet<RunnerProfile> RunnerProfiles { get; set; }
    }
}