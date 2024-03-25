using System.ComponentModel.DataAnnotations;

namespace StartUpTemp.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Subtitle { get; set; }
    }
}
