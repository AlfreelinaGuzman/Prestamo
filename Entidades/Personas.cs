using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Prestamos.Entidades
{
 
 
     public class Personas{
        [Key]
        public int PersonaID { get; set; }
        public string Nombres { get; set; }
        public decimal Balance { get; set; }
    }

}