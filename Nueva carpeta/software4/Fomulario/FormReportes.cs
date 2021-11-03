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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void reportesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reportesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.base_proyectoDataSet);

        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'base_proyectoDataSet.Reportes' Puede moverla o quitarla según sea necesario.
            this.reportesTableAdapter.Fill(this.base_proyectoDataSet.Reportes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportesBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportesBindingSource.EndEdit();
            reportesTableAdapter.Update(base_proyectoDataSet.Reportes);
        }
    }
}
