using PrimerParcial_Apl1_Luis_Rodriguez.UI.Consulta;
using PrimerParcial_Apl1_Luis_Rodriguez.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial_Apl1_Luis_Rodriguez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormRegistroEmpleado().Show();
        }

        private void consultaEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormConsultaEmpleado().Show();
        }
    }
}
