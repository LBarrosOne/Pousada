namespace Views
{
    partial class ExcluirQuarto
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
            this.lblId = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(23, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(50, 16);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(75, 20);
            this.textID.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GerenciarQuarto
            // 
            this.ClientSize = new System.Drawing.Size(288, 62);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.lblId);
            this.Name = "GerenciarQuarto";
            this.Text = "Excluir Quarto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button button2;
    }
}