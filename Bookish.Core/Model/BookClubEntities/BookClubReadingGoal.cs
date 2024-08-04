using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.Core.Model.BookClubEntities
{
    public class BookClubReadingGoal
    {
        public int Id { get; set; }
        public int BookClubId { get; set; }
        public int? BookId { get; set; }
        public string? GoalDescription { get; set; }
        public string GoalName { get; set; }
        public string GoalStatusId { get; set; }
        public DateTime? GoalDeadline { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
