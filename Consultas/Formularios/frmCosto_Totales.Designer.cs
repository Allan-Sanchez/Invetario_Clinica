namespace Consultas.Formularios
{
    partial class frmCosto_Totales
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
            System.Windows.Forms.Label id_CosultaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCosto_Totales));
            this.dgvCostos_Totales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtOtros_Costos = new System.Windows.Forms.TextBox();
            this.txtTotal_Costos = new System.Windows.Forms.TextBox();
            this.txtTOTAL_IVA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBorrar_Solo_uno = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.id_CosultaTextBox = new System.Windows.Forms.TextBox();
            this.totalCostosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaMedicaDataSet = new Consultas.ConsultaMedicaDataSet();
            this.idCosultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaConsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrosCostosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaconesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_CostosTableAdapter = new Consultas.ConsultaMedicaDataSetTableAdapters.total_CostosTableAdapter();
            this.tableAdapterManager = new Consultas.ConsultaMedicaDataSetTableAdapters.TableAdapterManager();
            id_CosultaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostos_Totales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaMedicaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCostos_Totales
            // 
            this.dgvCostos_Totales.AllowUserToAddRows = false;
            this.dgvCostos_Totales.AllowUserToDeleteRows = false;
            this.dgvCostos_Totales.AllowUserToOrderColumns = true;
            this.dgvCostos_Totales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCostos_Totales.AutoGenerateColumns = false;
            this.dgvCostos_Totales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostos_Totales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCosultaDataGridViewTextBoxColumn,
            this.medicoDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.fechaConsultaDataGridViewTextBoxColumn,
            this.consultaDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.otrosCostosDataGridViewTextBoxColumn,
            this.totalCostosDataGridViewTextBoxColumn,
            this.observaconesDataGridViewTextBoxColumn});
            this.dgvCostos_Totales.DataSource = this.totalCostosBindingSource;
            this.dgvCostos_Totales.Location = new System.Drawing.Point(9, 168);
            this.dgvCostos_Totales.Name = "dgvCostos_Totales";
            this.dgvCostos_Totales.ReadOnly = true;
            this.dgvCostos_Totales.Size = new System.Drawing.Size(1103, 404);
            this.dgvCostos_Totales.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Totales:";
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCosto.Location = new System.Drawing.Point(605, 589);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(87, 20);
            this.txtCosto.TabIndex = 6;
            this.txtCosto.Text = "0";
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOtros_Costos
            // 
            this.txtOtros_Costos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtros_Costos.Location = new System.Drawing.Point(698, 589);
            this.txtOtros_Costos.Name = "txtOtros_Costos";
            this.txtOtros_Costos.Size = new System.Drawing.Size(87, 20);
            this.txtOtros_Costos.TabIndex = 7;
            this.txtOtros_Costos.Text = "0";
            this.txtOtros_Costos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal_Costos
            // 
            this.txtTotal_Costos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal_Costos.Location = new System.Drawing.Point(819, 589);
            this.txtTotal_Costos.Name = "txtTotal_Costos";
            this.txtTotal_Costos.Size = new System.Drawing.Size(87, 20);
            this.txtTotal_Costos.TabIndex = 8;
            this.txtTotal_Costos.Text = "0";
            this.txtTotal_Costos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTOTAL_IVA
            // 
            this.txtTOTAL_IVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTOTAL_IVA.Location = new System.Drawing.Point(912, 589);
            this.txtTOTAL_IVA.Name = "txtTOTAL_IVA";
            this.txtTOTAL_IVA.Size = new System.Drawing.Size(87, 20);
            this.txtTOTAL_IVA.TabIndex = 9;
            this.txtTOTAL_IVA.Text = "0";
            this.txtTOTAL_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1005, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IVA a Pagar";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::Consultas.Properties.Resources.printer;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.Location = new System.Drawing.Point(498, 74);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(108, 41);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Consultas.Properties.Resources.cross;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(341, 74);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 41);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBorrar_Solo_uno
            // 
            this.btnBorrar_Solo_uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar_Solo_uno.Image = global::Consultas.Properties.Resources.eraser;
            this.btnBorrar_Solo_uno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar_Solo_uno.Location = new System.Drawing.Point(15, 74);
            this.btnBorrar_Solo_uno.Name = "btnBorrar_Solo_uno";
            this.btnBorrar_Solo_uno.Size = new System.Drawing.Size(120, 41);
            this.btnBorrar_Solo_uno.TabIndex = 2;
            this.btnBorrar_Solo_uno.Text = "&Borrar c/u";
            this.btnBorrar_Solo_uno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar_Solo_uno.UseVisualStyleBackColor = true;
            this.btnBorrar_Solo_uno.Click += new System.EventHandler(this.btnBorrar_Solo_uno_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::Consultas.Properties.Resources.garbage;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(184, 74);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 41);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // id_CosultaLabel
            // 
            id_CosultaLabel.AutoSize = true;
            id_CosultaLabel.Enabled = false;
            id_CosultaLabel.Location = new System.Drawing.Point(12, 15);
            id_CosultaLabel.Name = "id_CosultaLabel";
            id_CosultaLabel.Size = new System.Drawing.Size(59, 13);
            id_CosultaLabel.TabIndex = 11;
            id_CosultaLabel.Text = "ID Cosulta:";
            // 
            // id_CosultaTextBox
            // 
            this.id_CosultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.totalCostosBindingSource, "id_Cosulta", true));
            this.id_CosultaTextBox.Enabled = false;
            this.id_CosultaTextBox.Location = new System.Drawing.Point(74, 12);
            this.id_CosultaTextBox.Name = "id_CosultaTextBox";
            this.id_CosultaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_CosultaTextBox.TabIndex = 12;
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
            // idCosultaDataGridViewTextBoxColumn
            // 
            this.idCosultaDataGridViewTextBoxColumn.DataPropertyName = "id_Cosulta";
            this.idCosultaDataGridViewTextBoxColumn.HeaderText = "ID Cosulta";
            this.idCosultaDataGridViewTextBoxColumn.Name = "idCosultaDataGridViewTextBoxColumn";
            this.idCosultaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCosultaDataGridViewTextBoxColumn.Width = 50;
            // 
            // medicoDataGridViewTextBoxColumn
            // 
            this.medicoDataGridViewTextBoxColumn.DataPropertyName = "Medico";
            this.medicoDataGridViewTextBoxColumn.HeaderText = "Medico";
            this.medicoDataGridViewTextBoxColumn.Name = "medicoDataGridViewTextBoxColumn";
            this.medicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombresDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaConsultaDataGridViewTextBoxColumn
            // 
            this.fechaConsultaDataGridViewTextBoxColumn.DataPropertyName = "fecha_Consulta";
            this.fechaConsultaDataGridViewTextBoxColumn.HeaderText = "Fecha Consulta";
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
            // frmCosto_Totales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1124, 625);
            this.Controls.Add(id_CosultaLabel);
            this.Controls.Add(this.id_CosultaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTOTAL_IVA);
            this.Controls.Add(this.txtTotal_Costos);
            this.Controls.Add(this.txtOtros_Costos);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar_Solo_uno);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvCostos_Totales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCosto_Totales";
            this.Text = "Costo Totales";
            this.Load += new System.EventHandler(this.frmCosto_Totales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostos_Totales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaMedicaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCostos_Totales;
        private ConsultaMedicaDataSet consultaMedicaDataSet;
        private System.Windows.Forms.BindingSource totalCostosBindingSource;
        private ConsultaMedicaDataSetTableAdapters.total_CostosTableAdapter total_CostosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCosultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrosCostosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaconesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar_Solo_uno;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtOtros_Costos;
        private System.Windows.Forms.TextBox txtTotal_Costos;
        private System.Windows.Forms.TextBox txtTOTAL_IVA;
        private System.Windows.Forms.Label label2;
        private ConsultaMedicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_CosultaTextBox;
    }
}