
using Speedrunner_leaderboard_API_Brandon_Langehennig.Models;

namespace Speedrunner_leaderboard_API_Brandon_Langehennig.Repositories
{
    public interface IRunRepository
    {
        List<Run> GetAll();

        Run? GetById(int id);

        Run? GetByCategory(string category);

        Run Add(Run newRun);

        void Update(int id, Run exsistingRun);

        void Delete(Run deleteRun);
    }
}