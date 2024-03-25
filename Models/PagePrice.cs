using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace StartUpTemp.Models
{
    public class PagePrice
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Subtitle { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string Time { get; set; }

        [Required]
        public string Langs1 { get; set; }

        [Required]
        public string Langs2 { get; set; }

        [Required]
        public string Langs3 { get; set; }

        [Required]
        public string Langs4 { get; set; }
    }
}
