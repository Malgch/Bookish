using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookish.Core.Model.UserEntities;

namespace Bookish.Core.Model.BookClubEntities
{
    public class BookClub
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<User> Members { get; set; }

    }
}
