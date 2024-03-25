using System.ComponentModel.DataAnnotations;

namespace StartUpTemp.Models
{
    public class PageTeam
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Profession { get; set; }
    }
}
