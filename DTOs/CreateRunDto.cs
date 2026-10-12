
namespace Speedrunner_leaderboard_API_Brandon_Langehennig.DTOs
{
    public class CreateRunDto
    {
         

        public string Game { get; set; }

        public string Category { get; set; }

        public string Runner { get; set; }

        public int TimeSeconds { get; set; }

        public string Platform { get; set; }

        public string VideoUrl { get; set; }

        public string? Notes { get; set; }
    }
}