
using Speedrunner_leaderboard_API_Brandon_Langehennig.DTOs;
using Speedrunner_leaderboard_API_Brandon_Langehennig.Models;

namespace Speedrunner_leaderboard_API_Brandon_Langehennig.Services
{
    public interface IRunServices
    {
        List<RunResponseDto> GetAll();

        RunResponseDto? GetById(int id);

        RunResponseDto? GetByCategory(string category);

        RunResponseDto? Add(CreateRunDto newRun);

        bool Update(int id, Run exsistingRun);

        void Delete(int id);
    }
}