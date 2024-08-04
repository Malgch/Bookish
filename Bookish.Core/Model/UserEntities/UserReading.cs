using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.Core.Model.UserEntities
{
    internal class UserReading
    {
        public int UserReadingId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int StatusId { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime LastUpdatedAt { get; set;}
    }
}
