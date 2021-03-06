using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software4.Fomulario
{
    public partial class FormPacientes : Form
    {
        public FormPacientes()
        {
            InitializeComponent();
        }

        private void pacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.base_proyectoDataSet);

        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'base_proyectoDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.base_proyectoDataSet.Pacientes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pacientesBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pacientesBindingSource.EndEdit();
            pacientesTableAdapter.Update(base_proyectoDataSet.Pacientes);
        }
    }
}
