
using Speedrunner_leaderboard_API_Brandon_Langehennig.Data;
using Speedrunner_leaderboard_API_Brandon_Langehennig.Models;

namespace Speedrunner_leaderboard_API_Brandon_Langehennig.Repositories
{
    public class RunRepository : IRunRepository
    {
        private readonly AppDbContext _db;

        public RunRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Run> GetAll()
        {
            return _db.Runs.ToList();
        }

        public Run? GetById(int id)
        {
            return _db.Runs.FirstOrDefault(r => r.Id == id);
        }

        public Run? GetByCategory(string category )
        {
            return _db.Runs.FirstOrDefault(r => r.Category == category);
        }

        
         public Run Add(Run newRun)
        {
            _db.Runs.Add(newRun);
            _db.SaveChanges();
            return newRun;
        }
        public void Update(int id, Run exsistingRun)
        {
            _db.SaveChanges();
        }
        public void Delete(Run deleteRun)
        {
            _db.Runs.Remove(deleteRun);
            _db.SaveChanges(); 
    }
}
}