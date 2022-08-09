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
     public class Vehiculo   
    {

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(500, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Detalles { get; set; }    



    }
}
