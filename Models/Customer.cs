using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AussTennis.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime TournamentDate { get; set; }
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
         [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual List<Registration> Registrations { get; set; }

    }
}