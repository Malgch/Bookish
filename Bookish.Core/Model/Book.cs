using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.Core.Model
{
    public class Book
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? CoverImg { get; set; }
        public DateTime? PublishDate { get; set; }
        public ICollection<BookCategory> Categories { get; set; }

    }
}
