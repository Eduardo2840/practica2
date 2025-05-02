using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practica2.Models
{
    public class Pet
    {
        [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Tipo { get; set; }
            public string EstadoAdopcion { get; set; } // "Adoptado" o "No adoptado"

            public Adoption? Adoption { get; set; }
    }
}