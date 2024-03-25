using System.ComponentModel.DataAnnotations;

namespace StartUpTemp.Models
{
    public class BlogGrid
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string Text_Title { get; set; }

        [Required]
        public string Text_SubTitle { get; set; }

    }
}
