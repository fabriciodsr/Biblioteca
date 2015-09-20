namespace View
{
    partial class frmTeste
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
            this.dtgTeste = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTeste
            // 
            this.dtgTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTeste.Location = new System.Drawing.Point(46, 140);
            this.dtgTeste.Name = "dtgTeste";
            this.dtgTeste.Size = new System.Drawing.Size(492, 239);
            this.dtgTeste.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Carregar Bagaça";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgTeste);
            this.Name = "frmTeste";
            this.Text = "Teste";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTeste;
        private System.Windows.Forms.Button button1;
    }
}

