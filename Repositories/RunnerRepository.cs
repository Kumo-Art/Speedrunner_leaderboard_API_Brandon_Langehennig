
using Speedrunner_leaderboard_API_Brandon_Langehennig.Data;
using Speedrunner_leaderboard_API_Brandon_Langehennig.Models;
using SQLitePCL;

namespace Speedrunner_leaderboard_API_Brandon_Langehennig.Repositories
{
    public class RunnerRepository : IRunnerRepository
    {
        private readonly AppDbContext _db;

        public RunnerRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<RunnerProfile> GetAll()
        {
            return _db.RunnerProfiles.ToList();
        }

        public RunnerProfile? GetById(int id)
        {
            return _db.RunnerProfiles.FirstOrDefault(r => r.Id == id);
        }

        public RunnerProfile? GetByName(string name)
        {
            return _db.RunnerProfiles.FirstOrDefault(r => r.Username == name);
        }

        public RunnerProfile GetByVerification(bool pendingRuns)
        {
            return _db.RunnerProfiles.FirstOrDefault(r => r.PendingRuns == pendingRuns);
        }

         public RunnerProfile Add(RunnerProfile newRunner)
        {
            _db.RunnerProfiles.Add(newRunner);
            _db.SaveChanges();
            return newRunner;
        }
        public void Update(RunnerProfile exsistingRunner)
        {
            _db.SaveChanges();
        }
        public void Delete(RunnerProfile deleteRunner)
        {
            _db.RunnerProfiles.Remove(deleteRunner);
            _db.SaveChanges(); 
        }
    }
}