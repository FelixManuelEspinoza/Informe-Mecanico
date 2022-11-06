using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformeBD.entidades
{
    [Index(nameof(Matricula), Name = "Numero de matricula del vehiculo", IsUnique = true)]
    public class Cliente
    {
       
        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        [Key]
        public string DNI { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string NumTelefono { get; set; }
        
        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string MarcaVehiculo { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string ModeloVehiculo { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(500, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string DetallesDehiculo { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string FechaDeEntrada { get; set; }


    }
}
