using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//Library to use Key attribute
using System.ComponentModel.DataAnnotations.Schema;//
using System.Linq;
using System.Threading.Tasks;

namespace AussTennis.Models
{
    public class Venue
    {
        [Key()]
        [ForeignKey("Tournament")]
        public int Id { get; set; }
        public string VenueLocation { get; set; }
        public virtual Tournament Tournament { get; set; }

    }
}
