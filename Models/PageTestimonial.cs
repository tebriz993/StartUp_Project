using System.ComponentModel.DataAnnotations;

namespace StartUpTemp.Models
{
    public class PageTestimonial
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Profession { get; set; }

        [Required]
        public string Subtitle { get; set; }

    }
}
