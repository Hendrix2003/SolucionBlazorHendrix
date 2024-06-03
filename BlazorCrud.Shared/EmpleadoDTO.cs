using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Shared
{
     public class EmpleadoDTO
    {
        public int IdEmpleado { get; set; }

        [Required(ErrorMessage = "EL campo{0} es requerido.")]

        public string NombreCompleto { get; set; } = null!;

        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "EL campo{0} es requerido.")]
        public int IdDepartamento { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "EL campo{0} es requerido.")]
        public  int Salario { get; set; }
        [Required]
        public string? Direccion { get; set; }

        [Required]
        public string? Telefono { get; set; }
        [Required]
        public int Edad { get; set; }

        public DateTime FechaContrato { get; set; }

        public DepartamentoDTO? Departamento { get; set; }
    }
}
