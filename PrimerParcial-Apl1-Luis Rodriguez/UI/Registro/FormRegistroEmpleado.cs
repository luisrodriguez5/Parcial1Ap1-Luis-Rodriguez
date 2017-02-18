using PrimerParcial_Apl1_Luis_Rodriguez.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial_Apl1_Luis_Rodriguez.UI.Registro
{
    public partial class FormRegistroEmpleado : Form
    {

        public FormRegistroEmpleado()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            empleadoIdTextBox.Clear();
            nombreTextBox.Clear();
            sueldoTextBox.Clear();
        }
        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                NombreErrorProvider.SetError(nombreTextBox, "Por favor digite el nombre");
                return false;
            }
            return true;
        }

        private void FormRegistroUsuario_Load(object sender, EventArgs e)
        {
          

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if(Utils.NoWhiteNoSpace(nombreTextBox.Text) && Utils.NoWhiteNoSpace(sueldoTextBox.Text))
            {
                int id = 0;
                Empleado empleado;
                using (var context = new DAL.Repositorio<Empleado>())
                {
                    empleado = context.Guardar(new Empleado(Utils.NoWhiteNoSpace(empleadoIdTextBox.Text) == false ? 0 : int.Parse(empleadoIdTextBox.Text), nombreTextBox.Text, fechaDeNacimentoDateTimePicker.Value.Date, int.Parse(sueldoTextBox.Text)));
                    id = empleado.EmpleadoId;
                }
                if (id != 0)
                {
                    empleadoIdTextBox.Text = id.ToString();
                    MessageBox.Show("Empleado guardado!");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Empleado no se puedo guardar!");
                }
            }


        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(empleadoIdTextBox.Text))
            {
                int id = int.Parse(empleadoIdTextBox.Text);
                using (var context = new DAL.Repositorio<Empleado>())
                {
                    if (context.Eliminar(context.Buscar(x => x.EmpleadoId == id)))
                    {
                        Limpiar();
                        MessageBox.Show("Este empleado eliminado!");
                    }
                    else
                    {
                        MessageBox.Show("No se puedo eliminar!");
                    }
                }
            }
            else
            {
                IderrorProvider.SetError(empleadoIdTextBox, "Id vacio!");
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (Utils.NoWhiteNoSpace(empleadoIdTextBox.Text))
            {
                Empleado empleado;
                int id = int.Parse(empleadoIdTextBox.Text);

                using (var context = new DAL.Repositorio<Empleado>())
                {
                    empleado = context.Buscar(x => x.EmpleadoId == id);
                }

                if (empleado != null)
                {
                    nombreTextBox.Text = empleado.Nombres;
                    fechaDeNacimentoDateTimePicker.Value = empleado.FechaNacimientos;
                    sueldoTextBox.Text = empleado.Sueldos.ToString();
                    IderrorProvider.Clear();
                }
                else
                {
                    MessageBox.Show("Este id de empleado no existe!");
                }
            }
            else
            {
                IderrorProvider.SetError(empleadoIdTextBox, "Id vacio!");
            }
        }
    }
}
