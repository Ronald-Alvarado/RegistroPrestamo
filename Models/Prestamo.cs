using System;
using System.ComponentModel.DataAnnotations;

namespace RegistroPrestamo.Models
{
    public class Prestamo
    {
        [Key] public int PrestamoId { get; set; }

        [Required(ErrorMessage = "Debe poner una Fecha de Creación")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Debe poner una Persona")]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Debe de poner un Concepto")]
        public string Concepto { get; set; }

        [Required(ErrorMessage = "Debe poner un Monto")]
        public decimal Monto { get; set; }
        
        public decimal Balance { get; set; }
    }
}