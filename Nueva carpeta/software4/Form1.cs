using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software4
{
    public partial class Form1 : Form
    {
        // campos 
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        // contructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        //metodos

        private Color temacolor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = temacolor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                }
            }
        }


        private void DisableButton()
        {
            foreach (Control previousBtn in Panel_Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(34, 34, 74);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelDeskopt.Controls.Add(childForm);
            this.PanelDeskopt.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }



       



        private void Boton_Pacientes_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Fomulario.FormPacientes(), sender);
        }

        private void Boton_Historias_clinicas_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Fomulario.FormHistoria(), sender);
        }

        private void Boton_Reportes_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Fomulario.FormReportes(), sender);
        }

        private void Boton_Afiliaciones_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Boton_Salir_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }










    
    
}
