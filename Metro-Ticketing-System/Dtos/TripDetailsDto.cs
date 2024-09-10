using System.ComponentModel.DataAnnotations;

namespace Metro_Ticketing_System.Dtos
{
    public class TripDetailsDto
    {
        [Required]
        public string StartStation { get; set; }
        [Required]
        public string EndStation { get; set; }
    }
}
