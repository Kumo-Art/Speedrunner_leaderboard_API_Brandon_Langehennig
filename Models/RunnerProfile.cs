
namespace Speedrunner_leaderboard_API_Brandon_Langehennig.Models
{
    public class RunnerProfile
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Country { get; set; }

        public DateTime JoinedOn { get; set; }

        public bool IsModerator { get; set; }

        public bool PendingRuns {get;set;} = true;
    }
}