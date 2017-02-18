using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial_Apl1_Luis_Rodriguez.Entidades
{
   public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimientos { get; set; }
        public int Sueldos { get; set; }

        public Empleado()
        {

        }
        public Empleado(int empleadoId, string nombre, DateTime fechaNacimiento, int sueldo)
        {
            this.EmpleadoId = empleadoId;
            this.Nombres = nombre;
            this.FechaNacimientos = fechaNacimiento;
            this.Sueldos = sueldo;
        }
    }
}

