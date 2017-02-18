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

namespace PrimerParcial_Apl1_Luis_Rodriguez.UI.Consulta
{
    public partial class FormConsultaEmpleado : Form
    {
        public FormConsultaEmpleado()
        {
            InitializeComponent();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            using (var context = new DAL.Repositorio<Empleado>())
            {

                if (FiltrarCheckBox.Checked == false) DataGridView.DataSource = context.GetListAll();
                else
                {
                    if (FechaCheckBox.Checked == true && NombreCheckBox.Checked == true)
                    {
                        if (Utils.NoWhiteNoSpace(SearchTextBox.Text))
                        {
                            DataGridView.DataSource = context.GetList(x => x.FechaNacimientos >= DesdeDateTimePicker.Value.Date && x.FechaNacimientos <= HastaDateTimePicker.Value.Date && x.Nombres == SearchTextBox.Text);
                            ErrorProvider.Clear();
                        }
                        else ErrorProvider.SetError(SearchTextBox, "No puede estar vacio!");
                    }
                    else
                    {
                        if (FechaCheckBox.Checked == true)
                        {
                            DataGridView.DataSource = context.GetList(x => x.FechaNacimientos >= DesdeDateTimePicker.Value.Date && x.FechaNacimientos <= HastaDateTimePicker.Value.Date);
                        }
                        else if (NombreCheckBox.Checked == true)
                        {
                            if (Utils.NoWhiteNoSpace(SearchTextBox.Text))
                            {
                                DataGridView.DataSource = context.GetList(x => x.Nombres == SearchTextBox.Text);

                                ErrorProvider.Clear();
                            }
                            else ErrorProvider.SetError(SearchTextBox, "No puede estar vacio!");
                        }
                    }
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
