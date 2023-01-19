using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AussTennis.Models
{
    public class Organizer
    {
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }

        public Option AssignedTournament { get; set; }

       
        public virtual ICollection<Reviewer> Reviewers { get; set; }

    }
}