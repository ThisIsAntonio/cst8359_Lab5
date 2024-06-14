using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models
{
    public class Subscription
    {
        public int FanId { get; set; }
        public string SportClubId { get; set; } = string.Empty;

        // Navigation properties
        public Fan Fan { get; set; }
        public SportClub SportClub { get; set; }
    }
}
