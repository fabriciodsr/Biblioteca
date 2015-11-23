namespace View._4BI.RelatoriosdeMovimentacao
{
    partial class frmRelLivrosEmprestados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelLivrosEmprestados));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisarEmprestimo = new System.Windows.Forms.Button();
            this.rdbAluno = new System.Windows.Forms.RadioButton();
            this.rdbId = new System.Windows.Forms.RadioButton();
            this.dtgRelatorio = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPesquisarEmprestimo);
            this.groupBox2.Controls.Add(this.rdbAluno);
            this.groupBox2.Controls.Add(this.rdbId);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 80);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Classificar por:";
            // 
            // btnPesquisarEmprestimo
            // 
            this.btnPesquisarEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarEmprestimo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPesquisarEmprestimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarEmprestimo.BackgroundImage")));
            this.btnPesquisarEmprestimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarEmprestimo.Location = new System.Drawing.Point(720, 32);
            this.btnPesquisarEmprestimo.Name = "btnPesquisarEmprestimo";
            this.btnPesquisarEmprestimo.Size = new System.Drawing.Size(26, 21);
            this.btnPesquisarEmprestimo.TabIndex = 107;
            this.btnPesquisarEmprestimo.UseVisualStyleBackColor = false;
            this.btnPesquisarEmprestimo.Click += new System.EventHandler(this.btnPesquisarEmprestimo_Click);
            // 
            // rdbAluno
            // 
            this.rdbAluno.AutoSize = true;
            this.rdbAluno.Location = new System.Drawing.Point(126, 34);
            this.rdbAluno.Name = "rdbAluno";
            this.rdbAluno.Size = new System.Drawing.Size(52, 17);
            this.rdbAluno.TabIndex = 2;
            this.rdbAluno.TabStop = true;
            this.rdbAluno.Text = "Aluno";
            this.rdbAluno.UseVisualStyleBackColor = true;
            // 
            // rdbId
            // 
            this.rdbId.AutoSize = true;
            this.rdbId.Location = new System.Drawing.Point(33, 34);
            this.rdbId.Name = "rdbId";
            this.rdbId.Size = new System.Drawing.Size(36, 17);
            this.rdbId.TabIndex = 0;
            this.rdbId.TabStop = true;
            this.rdbId.Text = "ID";
            this.rdbId.UseVisualStyleBackColor = true;
            // 
            // dtgRelatorio
            // 
            this.dtgRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRelatorio.Location = new System.Drawing.Point(8, 113);
            this.dtgRelatorio.Name = "dtgRelatorio";
            this.dtgRelatorio.Size = new System.Drawing.Size(764, 336);
            this.dtgRelatorio.TabIndex = 106;
            // 
            // frmRelLivrosEmprestados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtgRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRelLivrosEmprestados";
            this.Text = "RELATÓRIO DE LIVROS EMPRESTADOS";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisarEmprestimo;
        private System.Windows.Forms.RadioButton rdbAluno;
        private System.Windows.Forms.RadioButton rdbId;
        private System.Windows.Forms.DataGridView dtgRelatorio;
    }
}