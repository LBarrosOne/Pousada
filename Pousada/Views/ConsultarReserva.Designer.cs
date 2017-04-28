namespace Views
{
    partial class ConsultarReserva
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
            this.pousadaDataSet3 = new Views.PousadaDataSet3();
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservasTableAdapter = new Views.PousadaDataSet3TableAdapters.ReservasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pousadaDataSet4 = new Views.PousadaDataSet4();
            this.reservasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reservasTableAdapter1 = new Views.PousadaDataSet4TableAdapters.ReservasTableAdapter();
            this.reservaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quartoQuartoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pousadaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pousadaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pousadaDataSet3
            // 
            this.pousadaDataSet3.DataSetName = "PousadaDataSet3";
            this.pousadaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "Reservas";
            this.reservasBindingSource.DataSource = this.pousadaDataSet3;
            // 
            // reservasTableAdapter
            // 
            this.reservasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservaIdDataGridViewTextBoxColumn,
            this.dataEntradaDataGridViewTextBoxColumn,
            this.dataSaidaDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn,
            this.clienteIdDataGridViewTextBoxColumn,
            this.quartoQuartoIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservasBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(941, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // pousadaDataSet4
            // 
            this.pousadaDataSet4.DataSetName = "PousadaDataSet4";
            this.pousadaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservasBindingSource1
            // 
            this.reservasBindingSource1.DataMember = "Reservas";
            this.reservasBindingSource1.DataSource = this.pousadaDataSet4;
            // 
            // reservasTableAdapter1
            // 
            this.reservasTableAdapter1.ClearBeforeFill = true;
            // 
            // reservaIdDataGridViewTextBoxColumn
            // 
            this.reservaIdDataGridViewTextBoxColumn.DataPropertyName = "ReservaId";
            this.reservaIdDataGridViewTextBoxColumn.HeaderText = "ReservaId";
            this.reservaIdDataGridViewTextBoxColumn.Name = "reservaIdDataGridViewTextBoxColumn";
            this.reservaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataEntradaDataGridViewTextBoxColumn
            // 
            this.dataEntradaDataGridViewTextBoxColumn.DataPropertyName = "DataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.HeaderText = "DataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.Name = "dataEntradaDataGridViewTextBoxColumn";
            this.dataEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSaidaDataGridViewTextBoxColumn
            // 
            this.dataSaidaDataGridViewTextBoxColumn.DataPropertyName = "DataSaida";
            this.dataSaidaDataGridViewTextBoxColumn.HeaderText = "DataSaida";
            this.dataSaidaDataGridViewTextBoxColumn.Name = "dataSaidaDataGridViewTextBoxColumn";
            this.dataSaidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteIdDataGridViewTextBoxColumn
            // 
            this.clienteIdDataGridViewTextBoxColumn.DataPropertyName = "Cliente_Id";
            this.clienteIdDataGridViewTextBoxColumn.HeaderText = "Cliente_Id";
            this.clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            this.clienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quartoQuartoIDDataGridViewTextBoxColumn
            // 
            this.quartoQuartoIDDataGridViewTextBoxColumn.DataPropertyName = "Quarto_QuartoID";
            this.quartoQuartoIDDataGridViewTextBoxColumn.HeaderText = "Quarto_QuartoID";
            this.quartoQuartoIDDataGridViewTextBoxColumn.Name = "quartoQuartoIDDataGridViewTextBoxColumn";
            this.quartoQuartoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConsultarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 383);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultarReserva";
            this.Text = "Consulta de Reservas";
            this.Load += new System.EventHandler(this.ConsultarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pousadaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pousadaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PousadaDataSet3 pousadaDataSet3;
        private System.Windows.Forms.BindingSource reservasBindingSource;
        private PousadaDataSet3TableAdapters.ReservasTableAdapter reservasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PousadaDataSet4 pousadaDataSet4;
        private System.Windows.Forms.BindingSource reservasBindingSource1;
        private PousadaDataSet4TableAdapters.ReservasTableAdapter reservasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quartoQuartoIDDataGridViewTextBoxColumn;
    }
}