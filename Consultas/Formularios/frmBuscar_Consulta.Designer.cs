namespace Consultas.Formularios
{
    partial class frmBuscar_Consulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar_Consulta));
            this.dgvBusquedaConsulta = new System.Windows.Forms.DataGridView();
            this.idCosultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaConsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrosCostosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaconesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaMedicaDataSet = new Consultas.ConsultaMedicaDataSet();
            this.total_CostosTableAdapter = new Consultas.ConsultaMedicaDataSetTableAdapters.total_CostosTableAdapter();
            this.fillByfecha_ConsultaToolStrip = new System.Windows.Forms.ToolStrip();
            this.fecha_ConsultaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fecha_ConsultaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByfecha_ConsultaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByNombresCompletoToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombresToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombresToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByNombresCompletoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAcentar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaMedicaDataSet)).BeginInit();
            this.fillByfecha_ConsultaToolStrip.SuspendLayout();
            this.fillByNombresCompletoToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusquedaConsulta
            // 
            this.dgvBusquedaConsulta.AllowUserToAddRows = false;
            this.dgvBusquedaConsulta.AllowUserToDeleteRows = false;
            this.dgvBusquedaConsulta.AllowUserToOrderColumns = true;
            this.dgvBusquedaConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusquedaConsulta.AutoGenerateColumns = false;
            this.dgvBusquedaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCosultaDataGridViewTextBoxColumn,
            this.medicoDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.fechaConsultaDataGridViewTextBoxColumn,
            this.consultaDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.otrosCostosDataGridViewTextBoxColumn,
            this.totalCostosDataGridViewTextBoxColumn,
            this.observaconesDataGridViewTextBoxColumn});
            this.dgvBusquedaConsulta.DataSource = this.totalCostosBindingSource;
            this.dgvBusquedaConsulta.Location = new System.Drawing.Point(12, 146);
            this.dgvBusquedaConsulta.Name = "dgvBusquedaConsulta";
            this.dgvBusquedaConsulta.ReadOnly = true;
            this.dgvBusquedaConsulta.Size = new System.Drawing.Size(1112, 375);
            this.dgvBusquedaConsulta.TabIndex = 0;
            // 
            // idCosultaDataGridViewTextBoxColumn
            // 
            this.idCosultaDataGridViewTextBoxColumn.DataPropertyName = "id_Cosulta";
            this.idCosultaDataGridViewTextBoxColumn.HeaderText = "ID Cosulta";
            this.idCosultaDataGridViewTextBoxColumn.Name = "idCosultaDataGridViewTextBoxColumn";
            this.idCosultaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicoDataGridViewTextBoxColumn
            // 
            this.medicoDataGridViewTextBoxColumn.DataPropertyName = "Medico";
            this.medicoDataGridViewTextBoxColumn.HeaderText = "Medico";
            this.medicoDataGridViewTextBoxColumn.Name = "medicoDataGridViewTextBoxColumn";
            this.medicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.medicoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombresDataGridViewTextBoxColumn.Width = 200;
            // 
            // fechaConsultaDataGridViewTextBoxColumn
            // 
            this.fechaConsultaDataGridViewTextBoxColumn.DataPropertyName = "fecha_Consulta";
            this.fechaConsultaDataGridViewTextBoxColumn.HeaderText = "Fecha de Consulta";
            this.fechaConsultaDataGridViewTextBoxColumn.Name = "fechaConsultaDataGridViewTextBoxColumn";
            this.fechaConsultaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consultaDataGridViewTextBoxColumn
            // 
            this.consultaDataGridViewTextBoxColumn.DataPropertyName = "Consulta";
            this.consultaDataGridViewTextBoxColumn.HeaderText = "Consulta";
            this.consultaDataGridViewTextBoxColumn.Name = "consultaDataGridViewTextBoxColumn";
            this.consultaDataGridViewTextBoxColumn.ReadOnly = true;
            this.consultaDataGridViewTextBoxColumn.Width = 150;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.costoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otrosCostosDataGridViewTextBoxColumn
            // 
            this.otrosCostosDataGridViewTextBoxColumn.DataPropertyName = "Otros_Costos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.otrosCostosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.otrosCostosDataGridViewTextBoxColumn.HeaderText = "Otros Costos";
            this.otrosCostosDataGridViewTextBoxColumn.Name = "otrosCostosDataGridViewTextBoxColumn";
            this.otrosCostosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCostosDataGridViewTextBoxColumn
            // 
            this.totalCostosDataGridViewTextBoxColumn.DataPropertyName = "Total_Costos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.totalCostosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalCostosDataGridViewTextBoxColumn.HeaderText = "Total Costos";
            this.totalCostosDataGridViewTextBoxColumn.Name = "totalCostosDataGridViewTextBoxColumn";
            this.totalCostosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observaconesDataGridViewTextBoxColumn
            // 
            this.observaconesDataGridViewTextBoxColumn.DataPropertyName = "Observacones";
            this.observaconesDataGridViewTextBoxColumn.HeaderText = "Observacones";
            this.observaconesDataGridViewTextBoxColumn.Name = "observaconesDataGridViewTextBoxColumn";
            this.observaconesDataGridViewTextBoxColumn.ReadOnly = true;
            this.observaconesDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalCostosBindingSource
            // 
            this.totalCostosBindingSource.DataMember = "total_Costos";
            this.totalCostosBindingSource.DataSource = this.consultaMedicaDataSet;
            // 
            // consultaMedicaDataSet
            // 
            this.consultaMedicaDataSet.DataSetName = "ConsultaMedicaDataSet";
            this.consultaMedicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // total_CostosTableAdapter
            // 
            this.total_CostosTableAdapter.ClearBeforeFill = true;
            // 
            // fillByfecha_ConsultaToolStrip
            // 
            this.fillByfecha_ConsultaToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByfecha_ConsultaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecha_ConsultaToolStripLabel,
            this.fecha_ConsultaToolStripTextBox,
            this.fillByfecha_ConsultaToolStripButton});
            this.fillByfecha_ConsultaToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByfecha_ConsultaToolStrip.Name = "fillByfecha_ConsultaToolStrip";
            this.fillByfecha_ConsultaToolStrip.Size = new System.Drawing.Size(367, 25);
            this.fillByfecha_ConsultaToolStrip.TabIndex = 1;
            this.fillByfecha_ConsultaToolStrip.Text = "fillByfecha_ConsultaToolStrip";
            // 
            // fecha_ConsultaToolStripLabel
            // 
            this.fecha_ConsultaToolStripLabel.Name = "fecha_ConsultaToolStripLabel";
            this.fecha_ConsultaToolStripLabel.Size = new System.Drawing.Size(107, 22);
            this.fecha_ConsultaToolStripLabel.Text = "Fecha de Consulta:";
            // 
            // fecha_ConsultaToolStripTextBox
            // 
            this.fecha_ConsultaToolStripTextBox.Name = "fecha_ConsultaToolStripTextBox";
            this.fecha_ConsultaToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByfecha_ConsultaToolStripButton
            // 
            this.fillByfecha_ConsultaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByfecha_ConsultaToolStripButton.Name = "fillByfecha_ConsultaToolStripButton";
            this.fillByfecha_ConsultaToolStripButton.Size = new System.Drawing.Size(146, 22);
            this.fillByfecha_ConsultaToolStripButton.Text = "Filtrar por Fecha Consulta";
            this.fillByfecha_ConsultaToolStripButton.ToolTipText = "Filtrar por Fecha Consulta ";
            this.fillByfecha_ConsultaToolStripButton.Click += new System.EventHandler(this.fillByfecha_ConsultaToolStripButton_Click);
            // 
            // fillByNombresCompletoToolStrip
            // 
            this.fillByNombresCompletoToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByNombresCompletoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombresToolStripLabel,
            this.nombresToolStripTextBox,
            this.fillByNombresCompletoToolStripButton});
            this.fillByNombresCompletoToolStrip.Location = new System.Drawing.Point(407, 0);
            this.fillByNombresCompletoToolStrip.Name = "fillByNombresCompletoToolStrip";
            this.fillByNombresCompletoToolStrip.Size = new System.Drawing.Size(287, 25);
            this.fillByNombresCompletoToolStrip.TabIndex = 2;
            this.fillByNombresCompletoToolStrip.Text = "fillByNombresCompletoToolStrip";
            // 
            // nombresToolStripLabel
            // 
            this.nombresToolStripLabel.Name = "nombresToolStripLabel";
            this.nombresToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.nombresToolStripLabel.Text = "Nombres:";
            // 
            // nombresToolStripTextBox
            // 
            this.nombresToolStripTextBox.Name = "nombresToolStripTextBox";
            this.nombresToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByNombresCompletoToolStripButton
            // 
            this.fillByNombresCompletoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByNombresCompletoToolStripButton.Name = "fillByNombresCompletoToolStripButton";
            this.fillByNombresCompletoToolStripButton.Size = new System.Drawing.Size(114, 22);
            this.fillByNombresCompletoToolStripButton.Text = "Filtrar por Nombres";
            this.fillByNombresCompletoToolStripButton.Click += new System.EventHandler(this.fillByNombresCompletoToolStripButton_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Consultas.Properties.Resources.delete__2_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(440, 71);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnCancelar.Size = new System.Drawing.Size(114, 36);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAcentar
            // 
            this.btnAcentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcentar.Image = global::Consultas.Properties.Resources.checkmark;
            this.btnAcentar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcentar.Location = new System.Drawing.Point(229, 71);
            this.btnAcentar.Name = "btnAcentar";
            this.btnAcentar.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnAcentar.Size = new System.Drawing.Size(114, 36);
            this.btnAcentar.TabIndex = 5;
            this.btnAcentar.Text = "&Aceptar";
            this.btnAcentar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcentar.UseVisualStyleBackColor = true;
            this.btnAcentar.Click += new System.EventHandler(this.btnAcentar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Consultas.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(788, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnFiltros
            // 
            this.btnFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltros.Image = global::Consultas.Properties.Resources.eraser_1_;
            this.btnFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltros.Location = new System.Drawing.Point(21, 71);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(137, 36);
            this.btnFiltros.TabIndex = 3;
            this.btnFiltros.Text = "Limpiar Filtros";
            this.btnFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltros.UseVisualStyleBackColor = true;
            this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            // 
            // frmBuscar_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1136, 531);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcentar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFiltros);
            this.Controls.Add(this.fillByNombresCompletoToolStrip);
            this.Controls.Add(this.fillByfecha_ConsultaToolStrip);
            this.Controls.Add(this.dgvBusquedaConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscar_Consulta";
            this.Text = "frmBuscar_Consulta";
            this.Load += new System.EventHandler(this.frmBuscar_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaMedicaDataSet)).EndInit();
            this.fillByfecha_ConsultaToolStrip.ResumeLayout(false);
            this.fillByfecha_ConsultaToolStrip.PerformLayout();
            this.fillByNombresCompletoToolStrip.ResumeLayout(false);
            this.fillByNombresCompletoToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusquedaConsulta;
        private ConsultaMedicaDataSet consultaMedicaDataSet;
        private System.Windows.Forms.BindingSource totalCostosBindingSource;
        private ConsultaMedicaDataSetTableAdapters.total_CostosTableAdapter total_CostosTableAdapter;
        private System.Windows.Forms.ToolStrip fillByfecha_ConsultaToolStrip;
        private System.Windows.Forms.ToolStripLabel fecha_ConsultaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fecha_ConsultaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByfecha_ConsultaToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCosultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrosCostosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaconesDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByNombresCompletoToolStrip;
        private System.Windows.Forms.ToolStripLabel nombresToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombresToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByNombresCompletoToolStripButton;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAcentar;
        private System.Windows.Forms.Button btnCancelar;
    }
}