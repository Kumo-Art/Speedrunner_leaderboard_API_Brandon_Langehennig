

namespace Speedrunner_leaderboard_API_Brandon_Langehennig.Models
{
    public class Run
    {
        public int Id { get; set; }

        public string Game { get; set; }

        public string Category { get; set; }

        public string Runner { get; set; }

        public int TimeSeconds { get; set; }

        public string Platform { get; set; }

        public string VideoUrl { get; set; }

        public string Status { get; set; } = "Pending";

        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

        public string? Notes { get; set; } = string.Empty;
    }
}