using System.Collections;

namespace MaktabQuiz.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CreationDate { get; set; }
        public ICollection<Category> categories { get; set;}

    }

}
