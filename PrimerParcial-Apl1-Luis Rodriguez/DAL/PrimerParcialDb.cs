using PrimerParcial_Apl1_Luis_Rodriguez.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial_Apl1_Luis_Rodriguez.DAL
{
    public class PrimerParcialDb : DbContext
    {
        public PrimerParcialDb() : base("ConStr")
        {

        }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
