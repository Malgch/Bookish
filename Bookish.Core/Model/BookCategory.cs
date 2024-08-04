using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.Core.Model
{
    public class BookCategory
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
