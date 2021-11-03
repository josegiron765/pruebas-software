
namespace software4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.PanelDeskopt = new System.Windows.Forms.Panel();
            this.Panel_Logo = new System.Windows.Forms.Panel();
            this.Boton_Historias_clinicas = new System.Windows.Forms.Button();
            this.Boton_Reportes = new System.Windows.Forms.Button();
            this.Boton_Afiliaciones = new System.Windows.Forms.Button();
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Boton_Pacientes = new System.Windows.Forms.Button();
            this.Panel_Menu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.Panel_Menu.Controls.Add(this.Boton_Pacientes);
            this.Panel_Menu.Controls.Add(this.Boton_Salir);
            this.Panel_Menu.Controls.Add(this.Boton_Afiliaciones);
            this.Panel_Menu.Controls.Add(this.Boton_Reportes);
            this.Panel_Menu.Controls.Add(this.Boton_Historias_clinicas);
            this.Panel_Menu.Controls.Add(this.Panel_Logo);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(220, 559);
            this.Panel_Menu.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(990, 100);
            this.panelTitleBar.TabIndex = 1;
            // 
            // PanelDeskopt
            // 
            this.PanelDeskopt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.PanelDeskopt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDeskopt.Location = new System.Drawing.Point(220, 100);
            this.PanelDeskopt.Name = "PanelDeskopt";
            this.PanelDeskopt.Size = new System.Drawing.Size(990, 459);
            this.PanelDeskopt.TabIndex = 2;
            // 
            // Panel_Logo
            // 
            this.Panel_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Logo.BackgroundImage")));
            this.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Logo.Name = "Panel_Logo";
            this.Panel_Logo.Size = new System.Drawing.Size(220, 100);
            this.Panel_Logo.TabIndex = 0;
            // 
            // Boton_Historias_clinicas
            // 
            this.Boton_Historias_clinicas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Boton_Historias_clinicas.FlatAppearance.BorderSize = 0;
            this.Boton_Historias_clinicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Historias_clinicas.ForeColor = System.Drawing.Color.White;
            this.Boton_Historias_clinicas.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Historias_clinicas.Image")));
            this.Boton_Historias_clinicas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Historias_clinicas.Location = new System.Drawing.Point(0, 100);
            this.Boton_Historias_clinicas.Name = "Boton_Historias_clinicas";
            this.Boton_Historias_clinicas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Boton_Historias_clinicas.Size = new System.Drawing.Size(220, 59);
            this.Boton_Historias_clinicas.TabIndex = 4;
            this.Boton_Historias_clinicas.Text = "      Historia clinica";
            this.Boton_Historias_clinicas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Historias_clinicas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Boton_Historias_clinicas.UseVisualStyleBackColor = true;
            this.Boton_Historias_clinicas.Click += new System.EventHandler(this.Boton_Historias_clinicas_Click_1);
            // 
            // Boton_Reportes
            // 
            this.Boton_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Boton_Reportes.FlatAppearance.BorderSize = 0;
            this.Boton_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Reportes.ForeColor = System.Drawing.Color.White;
            this.Boton_Reportes.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Reportes.Image")));
            this.Boton_Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Reportes.Location = new System.Drawing.Point(0, 159);
            this.Boton_Reportes.Name = "Boton_Reportes";
            this.Boton_Reportes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Boton_Reportes.Size = new System.Drawing.Size(220, 59);
            this.Boton_Reportes.TabIndex = 5;
            this.Boton_Reportes.Text = "      Reportes";
            this.Boton_Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Boton_Reportes.UseVisualStyleBackColor = true;
            this.Boton_Reportes.Click += new System.EventHandler(this.Boton_Reportes_Click_1);
            // 
            // Boton_Afiliaciones
            // 
            this.Boton_Afiliaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.Boton_Afiliaciones.FlatAppearance.BorderSize = 0;
            this.Boton_Afiliaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Afiliaciones.ForeColor = System.Drawing.Color.White;
            this.Boton_Afiliaciones.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Afiliaciones.Image")));
            this.Boton_Afiliaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Afiliaciones.Location = new System.Drawing.Point(0, 218);
            this.Boton_Afiliaciones.Name = "Boton_Afiliaciones";
            this.Boton_Afiliaciones.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Boton_Afiliaciones.Size = new System.Drawing.Size(220, 59);
            this.Boton_Afiliaciones.TabIndex = 6;
            this.Boton_Afiliaciones.Text = "      Afiliacion";
            this.Boton_Afiliaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Afiliaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Boton_Afiliaciones.UseVisualStyleBackColor = true;
            this.Boton_Afiliaciones.Click += new System.EventHandler(this.Boton_Afiliaciones_Click_1);
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.Dock = System.Windows.Forms.DockStyle.Top;
            this.Boton_Salir.FlatAppearance.BorderSize = 0;
            this.Boton_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Salir.ForeColor = System.Drawing.Color.White;
            this.Boton_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Salir.Image")));
            this.Boton_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Salir.Location = new System.Drawing.Point(0, 277);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Boton_Salir.Size = new System.Drawing.Size(220, 59);
            this.Boton_Salir.TabIndex = 7;
            this.Boton_Salir.Text = "      Configuracion";
            this.Boton_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Boton_Salir.UseVisualStyleBackColor = true;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(440, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // Boton_Pacientes
            // 
            this.Boton_Pacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Boton_Pacientes.FlatAppearance.BorderSize = 0;
            this.Boton_Pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Pacientes.ForeColor = System.Drawing.Color.White;
            this.Boton_Pacientes.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Pacientes.Image")));
            this.Boton_Pacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Pacientes.Location = new System.Drawing.Point(0, 336);
            this.Boton_Pacientes.Name = "Boton_Pacientes";
            this.Boton_Pacientes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Boton_Pacientes.Size = new System.Drawing.Size(220, 59);
            this.Boton_Pacientes.TabIndex = 8;
            this.Boton_Pacientes.Text = "      Paciente";
            this.Boton_Pacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Pacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Boton_Pacientes.UseVisualStyleBackColor = true;
            this.Boton_Pacientes.Click += new System.EventHandler(this.Boton_Pacientes_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 559);
            this.Controls.Add(this.PanelDeskopt);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.Panel_Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel_Menu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.Button Boton_Afiliaciones;
        private System.Windows.Forms.Button Boton_Reportes;
        private System.Windows.Forms.Button Boton_Historias_clinicas;
        private System.Windows.Forms.Panel Panel_Logo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel PanelDeskopt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Boton_Pacientes;
    }
}

