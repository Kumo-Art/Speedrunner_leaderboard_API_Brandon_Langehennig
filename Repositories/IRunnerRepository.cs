

using Speedrunner_leaderboard_API_Brandon_Langehennig.Models;

namespace Speedrunner_leaderboard_API_Brandon_Langehennig.Repositories
{
    public interface IRunnerRepository
    {
        List<RunnerProfile> GetAll();

        RunnerProfile? GetById(int id);

        RunnerProfile? GetByName(string name);

        RunnerProfile GetByVerification(bool pendingRuns);

        RunnerProfile Add(RunnerProfile newRunner);

        void Update(RunnerProfile exsistingRunner);

        void Delete(RunnerProfile deleteRunner);
    }
}