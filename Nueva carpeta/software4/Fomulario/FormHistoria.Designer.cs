
namespace software4.Fomulario
{
    partial class FormHistoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoria));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label _HistoriaLabel;
            System.Windows.Forms.Label nombre_pacienteLabel;
            System.Windows.Forms.Label apellido_PacienteLabel;
            System.Windows.Forms.Label ePSLabel;
            this.base_proyectoDataSet = new software4.base_proyectoDataSet();
            this.historiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historiaTableAdapter = new software4.base_proyectoDataSetTableAdapters.HistoriaTableAdapter();
            this.tableAdapterManager = new software4.base_proyectoDataSetTableAdapters.TableAdapterManager();
            this.historiaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.historiaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this._HistoriaTextBox = new System.Windows.Forms.TextBox();
            this.nombre_pacienteTextBox = new System.Windows.Forms.TextBox();
            this.apellido_PacienteTextBox = new System.Windows.Forms.TextBox();
            this.ePSTextBox = new System.Windows.Forms.TextBox();
            this.historiaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            _HistoriaLabel = new System.Windows.Forms.Label();
            nombre_pacienteLabel = new System.Windows.Forms.Label();
            apellido_PacienteLabel = new System.Windows.Forms.Label();
            ePSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.base_proyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaBindingNavigator)).BeginInit();
            this.historiaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // base_proyectoDataSet
            // 
            this.base_proyectoDataSet.DataSetName = "base_proyectoDataSet";
            this.base_proyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historiaBindingSource
            // 
            this.historiaBindingSource.DataMember = "Historia";
            this.historiaBindingSource.DataSource = this.base_proyectoDataSet;
            // 
            // historiaTableAdapter
            // 
            this.historiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HistoriaTableAdapter = this.historiaTableAdapter;
            this.tableAdapterManager.PacientesTableAdapter = null;
            this.tableAdapterManager.ReportesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = software4.base_proyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // historiaBindingNavigator
            // 
            this.historiaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.historiaBindingNavigator.BindingSource = this.historiaBindingSource;
            this.historiaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.historiaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.historiaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.historiaBindingNavigatorSaveItem});
            this.historiaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.historiaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.historiaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.historiaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.historiaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.historiaBindingNavigator.Name = "historiaBindingNavigator";
            this.historiaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.historiaBindingNavigator.Size = new System.Drawing.Size(963, 25);
            this.historiaBindingNavigator.TabIndex = 0;
            this.historiaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // historiaBindingNavigatorSaveItem
            // 
            this.historiaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.historiaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("historiaBindingNavigatorSaveItem.Image")));
            this.historiaBindingNavigatorSaveItem.Name = "historiaBindingNavigatorSaveItem";
            this.historiaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.historiaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.historiaBindingNavigatorSaveItem.Click += new System.EventHandler(this.historiaBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.Color.White;
            idLabel.Location = new System.Drawing.Point(50, 73);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(37, 28);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historiaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(207, 81);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // _HistoriaLabel
            // 
            _HistoriaLabel.AutoSize = true;
            _HistoriaLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _HistoriaLabel.ForeColor = System.Drawing.Color.White;
            _HistoriaLabel.Location = new System.Drawing.Point(12, 125);
            _HistoriaLabel.Name = "_HistoriaLabel";
            _HistoriaLabel.Size = new System.Drawing.Size(104, 28);
            _HistoriaLabel.TabIndex = 3;
            _HistoriaLabel.Text = "#Historia:";
            // 
            // _HistoriaTextBox
            // 
            this._HistoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historiaBindingSource, "#Historia", true));
            this._HistoriaTextBox.Location = new System.Drawing.Point(207, 133);
            this._HistoriaTextBox.Name = "_HistoriaTextBox";
            this._HistoriaTextBox.Size = new System.Drawing.Size(100, 20);
            this._HistoriaTextBox.TabIndex = 4;
            // 
            // nombre_pacienteLabel
            // 
            nombre_pacienteLabel.AutoSize = true;
            nombre_pacienteLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_pacienteLabel.ForeColor = System.Drawing.Color.White;
            nombre_pacienteLabel.Location = new System.Drawing.Point(12, 188);
            nombre_pacienteLabel.Name = "nombre_pacienteLabel";
            nombre_pacienteLabel.Size = new System.Drawing.Size(173, 28);
            nombre_pacienteLabel.TabIndex = 5;
            nombre_pacienteLabel.Text = "Nombre paciente:";
            // 
            // nombre_pacienteTextBox
            // 
            this.nombre_pacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historiaBindingSource, "Nombre_paciente", true));
            this.nombre_pacienteTextBox.Location = new System.Drawing.Point(207, 196);
            this.nombre_pacienteTextBox.Name = "nombre_pacienteTextBox";
            this.nombre_pacienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_pacienteTextBox.TabIndex = 6;
            // 
            // apellido_PacienteLabel
            // 
            apellido_PacienteLabel.AutoSize = true;
            apellido_PacienteLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellido_PacienteLabel.ForeColor = System.Drawing.Color.White;
            apellido_PacienteLabel.Location = new System.Drawing.Point(12, 241);
            apellido_PacienteLabel.Name = "apellido_PacienteLabel";
            apellido_PacienteLabel.Size = new System.Drawing.Size(178, 28);
            apellido_PacienteLabel.TabIndex = 7;
            apellido_PacienteLabel.Text = "Apellido Paciente:";
            // 
            // apellido_PacienteTextBox
            // 
            this.apellido_PacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historiaBindingSource, "Apellido_Paciente", true));
            this.apellido_PacienteTextBox.Location = new System.Drawing.Point(207, 249);
            this.apellido_PacienteTextBox.Name = "apellido_PacienteTextBox";
            this.apellido_PacienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellido_PacienteTextBox.TabIndex = 8;
            // 
            // ePSLabel
            // 
            ePSLabel.AutoSize = true;
            ePSLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ePSLabel.ForeColor = System.Drawing.Color.White;
            ePSLabel.Location = new System.Drawing.Point(21, 303);
            ePSLabel.Name = "ePSLabel";
            ePSLabel.Size = new System.Drawing.Size(56, 28);
            ePSLabel.TabIndex = 9;
            ePSLabel.Text = "EPS:";
            // 
            // ePSTextBox
            // 
            this.ePSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historiaBindingSource, "EPS", true));
            this.ePSTextBox.Location = new System.Drawing.Point(207, 311);
            this.ePSTextBox.Name = "ePSTextBox";
            this.ePSTextBox.Size = new System.Drawing.Size(100, 20);
            this.ePSTextBox.TabIndex = 10;
            // 
            // historiaDataGridView
            // 
            this.historiaDataGridView.AutoGenerateColumns = false;
            this.historiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historiaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.historiaDataGridView.DataSource = this.historiaBindingSource;
            this.historiaDataGridView.Location = new System.Drawing.Point(338, 133);
            this.historiaDataGridView.Name = "historiaDataGridView";
            this.historiaDataGridView.Size = new System.Drawing.Size(541, 220);
            this.historiaDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "#Historia";
            this.dataGridViewTextBoxColumn2.HeaderText = "#Historia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre_paciente";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre_paciente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Apellido_Paciente";
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellido_Paciente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EPS";
            this.dataGridViewTextBoxColumn5.HeaderText = "EPS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(514, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Historias clinicas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(728, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(963, 456);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.historiaDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(_HistoriaLabel);
            this.Controls.Add(this._HistoriaTextBox);
            this.Controls.Add(nombre_pacienteLabel);
            this.Controls.Add(this.nombre_pacienteTextBox);
            this.Controls.Add(apellido_PacienteLabel);
            this.Controls.Add(this.apellido_PacienteTextBox);
            this.Controls.Add(ePSLabel);
            this.Controls.Add(this.ePSTextBox);
            this.Controls.Add(this.historiaBindingNavigator);
            this.Name = "FormHistoria";
            this.Text = "FormHistoria";
            this.Load += new System.EventHandler(this.FormHistoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.base_proyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaBindingNavigator)).EndInit();
            this.historiaBindingNavigator.ResumeLayout(false);
            this.historiaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private base_proyectoDataSet base_proyectoDataSet;
        private System.Windows.Forms.BindingSource historiaBindingSource;
        private base_proyectoDataSetTableAdapters.HistoriaTableAdapter historiaTableAdapter;
        private base_proyectoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator historiaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton historiaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox _HistoriaTextBox;
        private System.Windows.Forms.TextBox nombre_pacienteTextBox;
        private System.Windows.Forms.TextBox apellido_PacienteTextBox;
        private System.Windows.Forms.TextBox ePSTextBox;
        private System.Windows.Forms.DataGridView historiaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}