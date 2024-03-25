using System.ComponentModel.DataAnnotations;

namespace StartUpTemp.Models
{
    public class BlogDetail
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string Image { get; set; }

        [Required]
        public string Text1 { get; set; }

        [Required]
        public string Text2 { get; set; }

        [Required]
        public string Text3 { get; set; }

        [Required]
        public string Text4 { get; set; }
    }
}
