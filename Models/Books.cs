using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace piwebmvc.Models
{
        public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}