using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace AussTennis.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public string TournamentName { get; set; }
        
       
        [Display(Name = "Tournament Date")]
        [DataType(DataType.Date)]
        public DateTime TournamentDate { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Fee { get; set; }


       

        public int TourId { get; set; }//Foriegn key 
        public virtual Tournament Tournament { get; set; }//making one to many relation with Tournament

        public int CustomerId { get; set; }
        public virtual Customer Customer{ get; set; }//making one to many relation with Tournament

    }
}