
// using Speedrunner_leaderboard_API_Brandon_Langehennig.Models;
// using Speedrunner_leaderboard_API_Brandon_Langehennig.Repositories;

// namespace Speedrunner_leaderboard_API_Brandon_Langehennig.Services
// {
//     public class RunnerServices : IRunnerServices
//     {
//          private readonly IRunnerRepository _runner;


//         public RunnerServices(IRunnerRepository runner)
//         {
//             _runner = runner;
//         }

//         public List<RunnerProfile> GetAll()
//         {
//             return _runner.GetAll().ToList();
//         }

//         public RunnerProfile? GetById(int id)
//         {
//             RunnerProfile? run = _runner.GetById(id);

//             if(run == null)
//             {
//                 return null;
//             }

//             return run;
//         }

//         public RunnerProfile? GetByName(string name)
//         {
//             RunnerProfile? run = _runner.GetByName(name);

//             if(run == null)
//             {
//                 return null;
//             }

//             return run;
//         }

//         public RunnerProfile? GetByVerification(bool pendingRuns)
//         {
//             RunnerProfile? pending = _runner.GetByVerification(pendingRuns);

//             if (pending is false)
//             {
                
//             }
//         }

     
// }
// }