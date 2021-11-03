
namespace software4.Fomulario
{
    partial class FormReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label _HistoriaLabel;
            System.Windows.Forms.Label nombre_pacienteLabel;
            System.Windows.Forms.Label estado_ReporteLabel;
            System.Windows.Forms.Label apellido_pacienteLabel;
            System.Windows.Forms.Label descripcionLabel;
            this.base_proyectoDataSet = new software4.base_proyectoDataSet();
            this.reportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportesTableAdapter = new software4.base_proyectoDataSetTableAdapters.ReportesTableAdapter();
            this.tableAdapterManager = new software4.base_proyectoDataSetTableAdapters.TableAdapterManager();
            this.reportesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.reportesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this._HistoriaTextBox = new System.Windows.Forms.TextBox();
            this.nombre_pacienteTextBox = new System.Windows.Forms.TextBox();
            this.estado_ReporteTextBox = new System.Windows.Forms.TextBox();
            this.apellido_pacienteTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.reportesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            _HistoriaLabel = new System.Windows.Forms.Label();
            nombre_pacienteLabel = new System.Windows.Forms.Label();
            estado_ReporteLabel = new System.Windows.Forms.Label();
            apellido_pacienteLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.base_proyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesBindingNavigator)).BeginInit();
            this.reportesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // base_proyectoDataSet
            // 
            this.base_proyectoDataSet.DataSetName = "base_proyectoDataSet";
            this.base_proyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportesBindingSource
            // 
            this.reportesBindingSource.DataMember = "Reportes";
            this.reportesBindingSource.DataSource = this.base_proyectoDataSet;
            // 
            // reportesTableAdapter
            // 
            this.reportesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HistoriaTableAdapter = null;
            this.tableAdapterManager.PacientesTableAdapter = null;
            this.tableAdapterManager.ReportesTableAdapter = this.reportesTableAdapter;
            this.tableAdapterManager.UpdateOrder = software4.base_proyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportesBindingNavigator
            // 
            this.reportesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reportesBindingNavigator.BindingSource = this.reportesBindingSource;
            this.reportesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reportesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reportesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.reportesBindingNavigatorSaveItem});
            this.reportesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reportesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reportesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reportesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reportesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reportesBindingNavigator.Name = "reportesBindingNavigator";
            this.reportesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reportesBindingNavigator.Size = new System.Drawing.Size(876, 25);
            this.reportesBindingNavigator.TabIndex = 0;
            this.reportesBindingNavigator.Text = "bindingNavigator1";
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
            // reportesBindingNavigatorSaveItem
            // 
            this.reportesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reportesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesBindingNavigatorSaveItem.Image")));
            this.reportesBindingNavigatorSaveItem.Name = "reportesBindingNavigatorSaveItem";
            this.reportesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.reportesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.reportesBindingNavigatorSaveItem.Click += new System.EventHandler(this.reportesBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.Color.White;
            idLabel.Location = new System.Drawing.Point(44, 63);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(37, 28);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(87, 71);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // _HistoriaLabel
            // 
            _HistoriaLabel.AutoSize = true;
            _HistoriaLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _HistoriaLabel.ForeColor = System.Drawing.Color.White;
            _HistoriaLabel.Location = new System.Drawing.Point(219, 63);
            _HistoriaLabel.Name = "_HistoriaLabel";
            _HistoriaLabel.Size = new System.Drawing.Size(104, 28);
            _HistoriaLabel.TabIndex = 3;
            _HistoriaLabel.Text = "#Historia:";
            // 
            // _HistoriaTextBox
            // 
            this._HistoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportesBindingSource, "#Historia", true));
            this._HistoriaTextBox.Location = new System.Drawing.Point(329, 71);
            this._HistoriaTextBox.Name = "_HistoriaTextBox";
            this._HistoriaTextBox.Size = new System.Drawing.Size(100, 20);
            this._HistoriaTextBox.TabIndex = 4;
            // 
            // nombre_pacienteLabel
            // 
            nombre_pacienteLabel.AutoSize = true;
            nombre_pacienteLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_pacienteLabel.ForeColor = System.Drawing.Color.White;
            nombre_pacienteLabel.Location = new System.Drawing.Point(448, 63);
            nombre_pacienteLabel.Name = "nombre_pacienteLabel";
            nombre_pacienteLabel.Size = new System.Drawing.Size(173, 28);
            nombre_pacienteLabel.TabIndex = 5;
            nombre_pacienteLabel.Text = "Nombre paciente:";
            // 
            // nombre_pacienteTextBox
            // 
            this.nombre_pacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportesBindingSource, "Nombre_paciente", true));
            this.nombre_pacienteTextBox.Location = new System.Drawing.Point(627, 71);
            this.nombre_pacienteTextBox.Name = "nombre_pacienteTextBox";
            this.nombre_pacienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_pacienteTextBox.TabIndex = 6;
            // 
            // estado_ReporteLabel
            // 
            estado_ReporteLabel.AutoSize = true;
            estado_ReporteLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estado_ReporteLabel.ForeColor = System.Drawing.Color.White;
            estado_ReporteLabel.Location = new System.Drawing.Point(162, 111);
            estado_ReporteLabel.Name = "estado_ReporteLabel";
            estado_ReporteLabel.Size = new System.Drawing.Size(161, 28);
            estado_ReporteLabel.TabIndex = 7;
            estado_ReporteLabel.Text = "Estado Reporte:";
            // 
            // estado_ReporteTextBox
            // 
            this.estado_ReporteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportesBindingSource, "Estado_Reporte", true));
            this.estado_ReporteTextBox.Location = new System.Drawing.Point(329, 119);
            this.estado_ReporteTextBox.Name = "estado_ReporteTextBox";
            this.estado_ReporteTextBox.Size = new System.Drawing.Size(100, 20);
            this.estado_ReporteTextBox.TabIndex = 8;
            // 
            // apellido_pacienteLabel
            // 
            apellido_pacienteLabel.AutoSize = true;
            apellido_pacienteLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellido_pacienteLabel.ForeColor = System.Drawing.Color.White;
            apellido_pacienteLabel.Location = new System.Drawing.Point(448, 111);
            apellido_pacienteLabel.Name = "apellido_pacienteLabel";
            apellido_pacienteLabel.Size = new System.Drawing.Size(177, 28);
            apellido_pacienteLabel.TabIndex = 9;
            apellido_pacienteLabel.Text = "Apellido paciente:";
            // 
            // apellido_pacienteTextBox
            // 
            this.apellido_pacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportesBindingSource, "Apellido_paciente", true));
            this.apellido_pacienteTextBox.Location = new System.Drawing.Point(631, 119);
            this.apellido_pacienteTextBox.Name = "apellido_pacienteTextBox";
            this.apellido_pacienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellido_pacienteTextBox.TabIndex = 10;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.ForeColor = System.Drawing.Color.White;
            descripcionLabel.Location = new System.Drawing.Point(35, 167);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(125, 28);
            descripcionLabel.TabIndex = 11;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportesBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(189, 175);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox.TabIndex = 12;
            // 
            // reportesDataGridView
            // 
            this.reportesDataGridView.AutoGenerateColumns = false;
            this.reportesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.reportesDataGridView.DataSource = this.reportesBindingSource;
            this.reportesDataGridView.Location = new System.Drawing.Point(40, 220);
            this.reportesDataGridView.Name = "reportesDataGridView";
            this.reportesDataGridView.Size = new System.Drawing.Size(633, 195);
            this.reportesDataGridView.TabIndex = 13;
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Estado_Reporte";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estado_Reporte";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Apellido_paciente";
            this.dataGridViewTextBoxColumn5.HeaderText = "Apellido_paciente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(733, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(733, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(876, 456);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportesDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(_HistoriaLabel);
            this.Controls.Add(this._HistoriaTextBox);
            this.Controls.Add(nombre_pacienteLabel);
            this.Controls.Add(this.nombre_pacienteTextBox);
            this.Controls.Add(estado_ReporteLabel);
            this.Controls.Add(this.estado_ReporteTextBox);
            this.Controls.Add(apellido_pacienteLabel);
            this.Controls.Add(this.apellido_pacienteTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.reportesBindingNavigator);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.base_proyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesBindingNavigator)).EndInit();
            this.reportesBindingNavigator.ResumeLayout(false);
            this.reportesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private base_proyectoDataSet base_proyectoDataSet;
        private System.Windows.Forms.BindingSource reportesBindingSource;
        private base_proyectoDataSetTableAdapters.ReportesTableAdapter reportesTableAdapter;
        private base_proyectoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reportesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton reportesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox _HistoriaTextBox;
        private System.Windows.Forms.TextBox nombre_pacienteTextBox;
        private System.Windows.Forms.TextBox estado_ReporteTextBox;
        private System.Windows.Forms.TextBox apellido_pacienteTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.DataGridView reportesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}