using System.ComponentModel.DataAnnotations;

namespace PhilsBookshop.Web
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }
        public string Title { get; set; }
    }
}
