using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JokerApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        public ICollection<Joke> Jokes { get; set; }
    }
}
