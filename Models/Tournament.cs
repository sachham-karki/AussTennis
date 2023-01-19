using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AussTennis.Models
{
    public class Tournament
    {
        [Required()]
        public int Id { get; set; }
        [Required()]
        [StringLength(30, MinimumLength =2)]
        public string TournamentName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
      
       
       
        public string Location { get; set; }
        


        public virtual List<Player> Players { get; set; }
        public virtual List<Registration> Registrations { get; set; }
        public virtual Venue Venue { get; set; }
        public virtual ICollection<Reviewer> Reviewers { get; set; }
    }
}