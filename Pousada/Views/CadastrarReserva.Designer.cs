namespace Views
{
    partial class CadastrarReserva
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblQuarto = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.comboQuarto = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblDtEntrada = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.txtDataSaida = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 15);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblQuarto
            // 
            this.lblQuarto.AutoSize = true;
            this.lblQuarto.Location = new System.Drawing.Point(12, 42);
            this.lblQuarto.Name = "lblQuarto";
            this.lblQuarto.Size = new System.Drawing.Size(42, 13);
            this.lblQuarto.TabIndex = 1;
            this.lblQuarto.Text = "Quarto:";
            // 
            // comboCliente
            // 
            this.comboCliente.BackColor = System.Drawing.SystemColors.Window;
            this.comboCliente.Location = new System.Drawing.Point(113, 12);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(121, 21);
            this.comboCliente.Sorted = true;
            this.comboCliente.TabIndex = 2;
            // 
            // comboQuarto
            // 
            this.comboQuarto.FormattingEnabled = true;
            this.comboQuarto.Location = new System.Drawing.Point(113, 39);
            this.comboQuarto.Name = "comboQuarto";
            this.comboQuarto.Size = new System.Drawing.Size(121, 21);
            this.comboQuarto.TabIndex = 3;
            this.comboQuarto.SelectedIndexChanged += new System.EventHandler(this.comboQuarto_SelectedIndexChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(159, 165);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblDtEntrada
            // 
            this.lblDtEntrada.AutoSize = true;
            this.lblDtEntrada.Location = new System.Drawing.Point(12, 70);
            this.lblDtEntrada.Name = "lblDtEntrada";
            this.lblDtEntrada.Size = new System.Drawing.Size(88, 13);
            this.lblDtEntrada.TabIndex = 5;
            this.lblDtEntrada.Text = "Data de Entrada:";
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(12, 96);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(77, 13);
            this.lblDataSaida.TabIndex = 6;
            this.lblDataSaida.Text = "Data de Saída";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 122);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total a Pagar:";
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(113, 67);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(121, 20);
            this.txtDataEntrada.TabIndex = 8;
            // 
            // txtDataSaida
            // 
            this.txtDataSaida.Location = new System.Drawing.Point(113, 93);
            this.txtDataSaida.Name = "txtDataSaida";
            this.txtDataSaida.Size = new System.Drawing.Size(121, 20);
            this.txtDataSaida.TabIndex = 9;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(113, 119);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(121, 20);
            this.txtTotalPagar.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(78, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CadastrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 244);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtDataSaida);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.lblDtEntrada);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.comboQuarto);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.lblQuarto);
            this.Controls.Add(this.lblCliente);
            this.Name = "CadastrarReserva";
            this.Text = "Cadastro de Reserva";
            this.Load += new System.EventHandler(this.CadastrarReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblQuarto;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.ComboBox comboQuarto;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblDtEntrada;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.TextBox txtDataSaida;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Button btnCancelar;
    }
}