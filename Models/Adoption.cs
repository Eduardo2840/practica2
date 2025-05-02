using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practica2.Models
{
    public class Adoption
    {
        [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            public int PetId { get; set; }
            public Pet Pets { get; set; }

            public int AdopterId { get; set; }
            public Adopter Adopter { get; set; }
    }
}