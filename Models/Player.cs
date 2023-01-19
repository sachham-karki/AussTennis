using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AussTennis.Models
{
    public class Player
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
        
        [Range(1, 100)]
        public int Age { get; set; }

        [StringLength(60, MinimumLength = 3)]
        
        public string TournamentName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public int TourId { get; set; }
        public virtual Tournament Tournament { get; set; }


    }
}