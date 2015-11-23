namespace View._4BI.RelatoriosdeMovimentacao
{
    partial class RelLivrosReservados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelLivrosReservados));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbAluno = new System.Windows.Forms.RadioButton();
            this.btnPesquisarReserva = new System.Windows.Forms.Button();
            this.rdbLivro = new System.Windows.Forms.RadioButton();
            this.dtgRelatorio = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbAluno);
            this.groupBox2.Controls.Add(this.btnPesquisarReserva);
            this.groupBox2.Controls.Add(this.rdbLivro);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 80);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Classificar por:";
            // 
            // rdbAluno
            // 
            this.rdbAluno.AutoSize = true;
            this.rdbAluno.Location = new System.Drawing.Point(146, 36);
            this.rdbAluno.Name = "rdbAluno";
            this.rdbAluno.Size = new System.Drawing.Size(52, 17);
            this.rdbAluno.TabIndex = 108;
            this.rdbAluno.TabStop = true;
            this.rdbAluno.Text = "Aluno";
            this.rdbAluno.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarReserva
            // 
            this.btnPesquisarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarReserva.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPesquisarReserva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarReserva.BackgroundImage")));
            this.btnPesquisarReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarReserva.Location = new System.Drawing.Point(714, 34);
            this.btnPesquisarReserva.Name = "btnPesquisarReserva";
            this.btnPesquisarReserva.Size = new System.Drawing.Size(26, 21);
            this.btnPesquisarReserva.TabIndex = 107;
            this.btnPesquisarReserva.UseVisualStyleBackColor = false;
            this.btnPesquisarReserva.Click += new System.EventHandler(this.btnPesquisarReserva_Click);
            // 
            // rdbLivro
            // 
            this.rdbLivro.AutoSize = true;
            this.rdbLivro.Location = new System.Drawing.Point(49, 36);
            this.rdbLivro.Name = "rdbLivro";
            this.rdbLivro.Size = new System.Drawing.Size(48, 17);
            this.rdbLivro.TabIndex = 3;
            this.rdbLivro.TabStop = true;
            this.rdbLivro.Text = "Livro";
            this.rdbLivro.UseVisualStyleBackColor = true;
            // 
            // dtgRelatorio
            // 
            this.dtgRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRelatorio.Location = new System.Drawing.Point(8, 113);
            this.dtgRelatorio.Name = "dtgRelatorio";
            this.dtgRelatorio.Size = new System.Drawing.Size(764, 336);
            this.dtgRelatorio.TabIndex = 106;
            // 
            // RelLivrosReservados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtgRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RelLivrosReservados";
            this.Text = "RELATÓRIO DE LIVROS RESERVADOS";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisarReserva;
        private System.Windows.Forms.RadioButton rdbLivro;
        private System.Windows.Forms.DataGridView dtgRelatorio;
        private System.Windows.Forms.RadioButton rdbAluno;
    }
}