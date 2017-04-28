namespace Views
{
    partial class ConsultarQuarto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pousadaDataSet = new Views.PousadaDataSet();
            this.quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartosTableAdapter = new Views.PousadaDataSetTableAdapters.QuartosTableAdapter();
            this.pousadaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pousadaDataSet1 = new Views.PousadaDataSet1();
            this.quartosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quartosTableAdapter1 = new Views.PousadaDataSet1TableAdapters.QuartosTableAdapter();
            this.quartoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDiariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pousadaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pousadaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pousadaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quartoIDDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.capacidadeDataGridViewTextBoxColumn,
            this.valorDiariaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.quartosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 221);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pousadaDataSet
            // 
            this.pousadaDataSet.DataSetName = "PousadaDataSet";
            this.pousadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quartosBindingSource
            // 
            this.quartosBindingSource.DataMember = "Quartos";
            this.quartosBindingSource.DataSource = this.pousadaDataSet;
            // 
            // quartosTableAdapter
            // 
            this.quartosTableAdapter.ClearBeforeFill = true;
            // 
            // pousadaDataSetBindingSource
            // 
            this.pousadaDataSetBindingSource.DataSource = this.pousadaDataSet;
            this.pousadaDataSetBindingSource.Position = 0;
            // 
            // pousadaDataSet1
            // 
            this.pousadaDataSet1.DataSetName = "PousadaDataSet1";
            this.pousadaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quartosBindingSource1
            // 
            this.quartosBindingSource1.DataMember = "Quartos";
            this.quartosBindingSource1.DataSource = this.pousadaDataSet1;
            // 
            // quartosTableAdapter1
            // 
            this.quartosTableAdapter1.ClearBeforeFill = true;
            // 
            // quartoIDDataGridViewTextBoxColumn
            // 
            this.quartoIDDataGridViewTextBoxColumn.DataPropertyName = "QuartoID";
            this.quartoIDDataGridViewTextBoxColumn.HeaderText = "QuartoID";
            this.quartoIDDataGridViewTextBoxColumn.Name = "quartoIDDataGridViewTextBoxColumn";
            this.quartoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacidadeDataGridViewTextBoxColumn
            // 
            this.capacidadeDataGridViewTextBoxColumn.DataPropertyName = "Capacidade";
            this.capacidadeDataGridViewTextBoxColumn.HeaderText = "Capacidade";
            this.capacidadeDataGridViewTextBoxColumn.Name = "capacidadeDataGridViewTextBoxColumn";
            this.capacidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDiariaDataGridViewTextBoxColumn
            // 
            this.valorDiariaDataGridViewTextBoxColumn.DataPropertyName = "ValorDiaria";
            this.valorDiariaDataGridViewTextBoxColumn.HeaderText = "ValorDiaria";
            this.valorDiariaDataGridViewTextBoxColumn.Name = "valorDiariaDataGridViewTextBoxColumn";
            this.valorDiariaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConsultarQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 245);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultarQuarto";
            this.Text = "Consultar Quartos";
            this.Load += new System.EventHandler(this.frmListagemCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pousadaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pousadaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pousadaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PousadaDataSet pousadaDataSet;
        private System.Windows.Forms.BindingSource quartosBindingSource;
        private PousadaDataSetTableAdapters.QuartosTableAdapter quartosTableAdapter;
        private System.Windows.Forms.BindingSource pousadaDataSetBindingSource;
        private PousadaDataSet1 pousadaDataSet1;
        private System.Windows.Forms.BindingSource quartosBindingSource1;
        private PousadaDataSet1TableAdapters.QuartosTableAdapter quartosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quartoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDiariaDataGridViewTextBoxColumn;
    }
}