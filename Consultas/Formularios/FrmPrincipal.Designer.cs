namespace Consultas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label medicoLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label consultaLabel;
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label otros_CostosLabel;
            System.Windows.Forms.Label fecha_ConsultaLabel;
            System.Windows.Forms.Label observaconesLabel;
            System.Windows.Forms.Label id_CosultaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.total_CostosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.total_CostosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaMedicaDataSet = new Consultas.ConsultaMedicaDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.dgvTotal_Costos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.consultaTextBox = new System.Windows.Forms.TextBox();
            this.costoTextBox = new System.Windows.Forms.TextBox();
            this.otros_CostosTextBox = new System.Windows.Forms.TextBox();
            this.fecha_ConsultaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.observaconesTextBox = new System.Windows.Forms.TextBox();
            this.id_CosultaTextBox = new System.Windows.Forms.TextBox();
            this.total_CostosTableAdapter = new Consultas.ConsultaMedicaDataSetTableAdapters.total_CostosTableAdapter();
            this.tableAdapterManager = new Consultas.ConsultaMedicaDataSetTableAdapters.TableAdapterManager();
            medicoLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            consultaLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            otros_CostosLabel = new System.Windows.Forms.Label();
            fecha_ConsultaLabel = new System.Windows.Forms.Label();
            observaconesLabel = new System.Windows.Forms.Label();
            id_CosultaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.total_CostosBindingNavigator)).BeginInit();
            this.total_CostosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.total_CostosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaMedicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal_Costos)).BeginInit();
            this.SuspendLayout();
            // 
            // medicoLabel
            // 
            medicoLabel.AutoSize = true;
            medicoLabel.Location = new System.Drawing.Point(12, 70);
            medicoLabel.Name = "medicoLabel";
            medicoLabel.Size = new System.Drawing.Size(45, 13);
            medicoLabel.TabIndex = 4;
            medicoLabel.Text = "Medico:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(12, 108);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 6;
            nombresLabel.Text = "Nombres:";
            // 
            // consultaLabel
            // 
            consultaLabel.AutoSize = true;
            consultaLabel.Location = new System.Drawing.Point(13, 146);
            consultaLabel.Name = "consultaLabel";
            consultaLabel.Size = new System.Drawing.Size(51, 13);
            consultaLabel.TabIndex = 8;
            consultaLabel.Text = "Consulta:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.Location = new System.Drawing.Point(415, 40);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(37, 13);
            costoLabel.TabIndex = 10;
            costoLabel.Text = "Costo:";
            // 
            // otros_CostosLabel
            // 
            otros_CostosLabel.AutoSize = true;
            otros_CostosLabel.Location = new System.Drawing.Point(415, 73);
            otros_CostosLabel.Name = "otros_CostosLabel";
            otros_CostosLabel.Size = new System.Drawing.Size(70, 13);
            otros_CostosLabel.TabIndex = 12;
            otros_CostosLabel.Text = "Otros Costos:";
            // 
            // fecha_ConsultaLabel
            // 
            fecha_ConsultaLabel.AutoSize = true;
            fecha_ConsultaLabel.Location = new System.Drawing.Point(9, 190);
            fecha_ConsultaLabel.Name = "fecha_ConsultaLabel";
            fecha_ConsultaLabel.Size = new System.Drawing.Size(102, 13);
            fecha_ConsultaLabel.TabIndex = 14;
            fecha_ConsultaLabel.Text = "&Fecha  de Consulta:";
            // 
            // observaconesLabel
            // 
            observaconesLabel.AutoSize = true;
            observaconesLabel.Location = new System.Drawing.Point(406, 111);
            observaconesLabel.Name = "observaconesLabel";
            observaconesLabel.Size = new System.Drawing.Size(79, 13);
            observaconesLabel.TabIndex = 16;
            observaconesLabel.Text = "Observacones:";
            // 
            // id_CosultaLabel
            // 
            id_CosultaLabel.AutoSize = true;
            id_CosultaLabel.Location = new System.Drawing.Point(21, 36);
            id_CosultaLabel.Name = "id_CosultaLabel";
            id_CosultaLabel.Size = new System.Drawing.Size(59, 13);
            id_CosultaLabel.TabIndex = 17;
            id_CosultaLabel.Text = "ID Cosulta:";
            // 
            // total_CostosBindingNavigator
            // 
            this.total_CostosBindingNavigator.AddNewItem = null;
            this.total_CostosBindingNavigator.BindingSource = this.total_CostosBindingSource;
            this.total_CostosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.total_CostosBindingNavigator.DeleteItem = null;
            this.total_CostosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbCancelar,
            this.tsbGuardar,
            this.tsbBuscar,
            this.tsbEliminar});
            this.total_CostosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.total_CostosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.total_CostosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.total_CostosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.total_CostosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.total_CostosBindingNavigator.Name = "total_CostosBindingNavigator";
            this.total_CostosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.total_CostosBindingNavigator.Size = new System.Drawing.Size(1175, 25);
            this.total_CostosBindingNavigator.TabIndex = 0;
            this.total_CostosBindingNavigator.Text = "bindingNavigator1";
            // 
            // total_CostosBindingSource
            // 
            this.total_CostosBindingSource.DataMember = "total_Costos";
            this.total_CostosBindingSource.DataSource = this.consultaMedicaDataSet;
            // 
            // consultaMedicaDataSet
            // 
            this.consultaMedicaDataSet.DataSetName = "ConsultaMedicaDataSet";
            this.consultaMedicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::Consultas.Properties.Resources.plus;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = global::Consultas.Properties.Resources.edit;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Enabled = false;
            this.tsbCancelar.Image = global::Consultas.Properties.Resources.cancel;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Enabled = false;
            this.tsbGuardar.Image = global::Consultas.Properties.Resources.save;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = global::Consultas.Properties.Resources.search;
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::Consultas.Properties.Resources.delete;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Borrar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // dgvTotal_Costos
            // 
            this.dgvTotal_Costos.AllowUserToAddRows = false;
            this.dgvTotal_Costos.AllowUserToDeleteRows = false;
            this.dgvTotal_Costos.AllowUserToOrderColumns = true;
            this.dgvTotal_Costos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTotal_Costos.AutoGenerateColumns = false;
            this.dgvTotal_Costos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotal_Costos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn8});
            this.dgvTotal_Costos.DataSource = this.total_CostosBindingSource;
            this.dgvTotal_Costos.Location = new System.Drawing.Point(12, 239);
            this.dgvTotal_Costos.Name = "dgvTotal_Costos";
            this.dgvTotal_Costos.ReadOnly = true;
            this.dgvTotal_Costos.Size = new System.Drawing.Size(1143, 220);
            this.dgvTotal_Costos.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_Cosulta";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Consulta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Medico";
            this.dataGridViewTextBoxColumn2.HeaderText = "Medico";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombres";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre Completo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha_Consulta";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha de Consulta";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Consulta";
            this.dataGridViewTextBoxColumn4.HeaderText = "Consulta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Costo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Costo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Otros_Costos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "Otros Costos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Total_Costos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn9.HeaderText = "Total Costos";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Observacones";
            this.dataGridViewTextBoxColumn8.HeaderText = "Observacones";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // medicoTextBox
            // 
            this.medicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.total_CostosBindingSource, "Medico", true));
            this.medicoTextBox.Enabled = false;
            this.medicoTextBox.Location = new System.Drawing.Point(83, 67);
            this.medicoTextBox.Name = "medicoTextBox";
            this.medicoTextBox.Size = new System.Drawing.Size(252, 20);
            this.medicoTextBox.TabIndex = 5;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.total_CostosBindingSource, "Nombres", true));
            this.nombresTextBox.Enabled = false;
            this.nombresTextBox.Location = new System.Drawing.Point(83, 105);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(252, 20);
            this.nombresTextBox.TabIndex = 7;
            // 
            // consultaTextBox
            // 
            this.consultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.total_CostosBindingSource, "Consulta", true));
            this.consultaTextBox.Enabled = false;
            this.consultaTextBox.Location = new System.Drawing.Point(83, 143);
            this.consultaTextBox.Name = "consultaTextBox";
            this.consultaTextBox.Size = new System.Drawing.Size(252, 20);
            this.consultaTextBox.TabIndex = 9;
            // 
            // costoTextBox
            // 
            this.costoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.total_CostosBindingSource, "Costo", true));
            this.costoTextBox.Enabled = false;
            this.costoTextBox.Location = new System.Drawing.Point(491, 37);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(100, 20);
            this.costoTextBox.TabIndex = 11;
            // 
            // otros_CostosTextBox
            // 
            this.otros_CostosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.total_CostosBindingSource, "Otros_Costos", true));
            this.otros_CostosTextBox.Enabled = false;
            this.otros_CostosTextBox.Location = new System.Drawing.Point(491, 70);
            this.otros_CostosTextBox.Name = "otros_CostosTextBox";
            this.otros_CostosTextBox.Size = new System.Drawing.Size(100, 20);
            this.otros_CostosTextBox.TabIndex = 13;
            // 
            // fecha_ConsultaDateTimePicker
            // 
            this.fecha_ConsultaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.total_CostosBindingSource, "fecha_Consulta", true));
            this.fecha_ConsultaDateTimePicker.Enabled = false;
            this.fecha_ConsultaDateTimePicker.Location = new System.Drawing.Point(135, 187);
            this.fecha_ConsultaDateTimePicker.Name = "fecha_ConsultaDateTimePicker";
            this.fecha_ConsultaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_ConsultaDateTimePicker.TabIndex = 15;
            // 
            // observaconesTextBox
            // 
            this.observaconesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.total_CostosBindingSource, "Observacones", true));
            this.observaconesTextBox.Enabled = false;
            this.observaconesTextBox.Location = new System.Drawing.Point(491, 115);
            this.observaconesTextBox.Multiline = true;
            this.observaconesTextBox.Name = "observaconesTextBox";
            this.observaconesTextBox.Size = new System.Drawing.Size(220, 92);
            this.observaconesTextBox.TabIndex = 17;
            // 
            // id_CosultaTextBox
            // 
            this.id_CosultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.total_CostosBindingSource, "id_Cosulta", true));
            this.id_CosultaTextBox.Enabled = false;
            this.id_CosultaTextBox.Location = new System.Drawing.Point(83, 33);
            this.id_CosultaTextBox.Name = "id_CosultaTextBox";
            this.id_CosultaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_CosultaTextBox.TabIndex = 18;
            // 
            // total_CostosTableAdapter
            // 
            this.total_CostosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Consultas.ConsultaMedicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1175, 479);
            this.Controls.Add(id_CosultaLabel);
            this.Controls.Add(this.id_CosultaTextBox);
            this.Controls.Add(observaconesLabel);
            this.Controls.Add(this.observaconesTextBox);
            this.Controls.Add(fecha_ConsultaLabel);
            this.Controls.Add(this.fecha_ConsultaDateTimePicker);
            this.Controls.Add(otros_CostosLabel);
            this.Controls.Add(this.otros_CostosTextBox);
            this.Controls.Add(costoLabel);
            this.Controls.Add(this.costoTextBox);
            this.Controls.Add(consultaLabel);
            this.Controls.Add(this.consultaTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(medicoLabel);
            this.Controls.Add(this.medicoTextBox);
            this.Controls.Add(this.dgvTotal_Costos);
            this.Controls.Add(this.total_CostosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Control de Pacientes";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.total_CostosBindingNavigator)).EndInit();
            this.total_CostosBindingNavigator.ResumeLayout(false);
            this.total_CostosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.total_CostosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaMedicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal_Costos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConsultaMedicaDataSet consultaMedicaDataSet;
        private System.Windows.Forms.BindingSource total_CostosBindingSource;
        private ConsultaMedicaDataSetTableAdapters.total_CostosTableAdapter total_CostosTableAdapter;
        private ConsultaMedicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator total_CostosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dgvTotal_Costos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox medicoTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox consultaTextBox;
        private System.Windows.Forms.TextBox costoTextBox;
        private System.Windows.Forms.TextBox otros_CostosTextBox;
        private System.Windows.Forms.DateTimePicker fecha_ConsultaDateTimePicker;
        private System.Windows.Forms.TextBox observaconesTextBox;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.TextBox id_CosultaTextBox;
    }
}

