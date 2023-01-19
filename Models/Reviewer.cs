using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AussTennis.Models
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int OrgId { get; set; }
        public virtual Organizer Organizer { get; set; }//creation relationship with Organizer

        public int TourId { get; set; }//foriegn key
        public virtual Tournament Tournament { get; set; }//relating with tournament
    }
}
