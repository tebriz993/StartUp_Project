using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace StartUpTemp.Models
{
    public class Home
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

    }
}
