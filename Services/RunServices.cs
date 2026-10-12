

using Speedrunner_leaderboard_API_Brandon_Langehennig.DTOs;
using Speedrunner_leaderboard_API_Brandon_Langehennig.Models;
using Speedrunner_leaderboard_API_Brandon_Langehennig.Repositories;

namespace Speedrunner_leaderboard_API_Brandon_Langehennig.Services
{
    public class RunServices : IRunServices
    {
        private readonly IRunRepository _run;


        public RunServices(IRunRepository run)
        {
            _run = run;
        }

        public List<RunResponseDto> GetAll()
        {
            return _run.GetAll().Select(r => ToRunDto(r)).ToList();
        }

        public RunResponseDto? GetById(int id)
        {
            Run? run = _run.GetById(id);

            if(run == null)
            {
                return null;
            }

            return ToRunDto(run);
        }

        public RunResponseDto? GetByCategory(string category)
        {
            Run? run = _run.GetByCategory(category);

            if(run == null)
            {
                return null;
            }

            return ToRunDto(run);
        }

        public RunResponseDto? Add( CreateRunDto dto)
        {
            bool existingRun = _run.GetAll().Any(r => r.Game.ToLower() == dto.Game.ToLower());
            if (existingRun)
            {
                return null;
            }

            
            Run run = new Run();

            run.Game = dto.Game;

            run.Category = dto.Category;

            run.TimeSeconds = dto.TimeSeconds;

            run.SubmittedAt = DateTime.UtcNow;

            run.Runner = dto.Runner;

            run.Platform = dto.Platform;

            run.Notes = dto.Notes;

            run.VideoUrl = dto.VideoUrl;

            Run created = _run.Add(run);

            return ToRunDto(created);

        }

        
        public bool Update(int id, Run run)
        {
            
            bool existingRun = _run.GetAll().Any(r => r.Id == run.Id);

            Run? exists = _run.GetById(id);
            if (exists == null || existingRun)
            {
                return false;
            }

            exists.Id = run.Id;

            _run.Update(id, exists);
            return true;
        }

        public void Delete(int id)
        {
           Run? exsistingRun = _run.GetById(id);

            if (exsistingRun != null)
            {
                _run.Delete(exsistingRun);
            }
        }

        private static RunResponseDto ToRunDto(Run run)
        {
           RunResponseDto outputDto = new RunResponseDto();
            outputDto.Id = run.Id;
            outputDto.Game = run.Game;
            outputDto.Category = run.Category;
             outputDto.Platform= run.Platform;
            outputDto.Runner = run.Runner;
            outputDto.Status = run.Status;
             outputDto.SubmittedAt = run.SubmittedAt;
            outputDto.TimeSeconds = run.TimeSeconds;
            outputDto.Notes = run.Notes;
            outputDto.VideoUrl = run.VideoUrl;

              return outputDto;
        }
    }
}