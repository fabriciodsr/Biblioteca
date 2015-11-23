namespace View._4BI.RelatoriosCadastrais
{
    partial class frmRelatorioCadastroLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioCadastroLivros));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtgRelatorio = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisarLivro = new System.Windows.Forms.Button();
            this.rdbTitulo = new System.Windows.Forms.RadioButton();
            this.rdbId = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRelatorio)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 80);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por Período:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(179, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Data Final";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(166, 44);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker2.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(49, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Data Inicial";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dtgRelatorio
            // 
            this.dtgRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRelatorio.Location = new System.Drawing.Point(10, 113);
            this.dtgRelatorio.Name = "dtgRelatorio";
            this.dtgRelatorio.Size = new System.Drawing.Size(764, 336);
            this.dtgRelatorio.TabIndex = 105;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbTitulo);
            this.groupBox2.Controls.Add(this.rdbId);
            this.groupBox2.Controls.Add(this.btnPesquisarLivro);
            this.groupBox2.Location = new System.Drawing.Point(335, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 80);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Classificar por:";
            // 
            // btnPesquisarLivro
            // 
            this.btnPesquisarLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarLivro.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPesquisarLivro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarLivro.BackgroundImage")));
            this.btnPesquisarLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarLivro.Location = new System.Drawing.Point(393, 32);
            this.btnPesquisarLivro.Name = "btnPesquisarLivro";
            this.btnPesquisarLivro.Size = new System.Drawing.Size(26, 21);
            this.btnPesquisarLivro.TabIndex = 110;
            this.btnPesquisarLivro.UseVisualStyleBackColor = false;
            this.btnPesquisarLivro.Click += new System.EventHandler(this.btnPesquisarLivro_Click);
            // 
            // rdbTitulo
            // 
            this.rdbTitulo.AutoSize = true;
            this.rdbTitulo.Location = new System.Drawing.Point(88, 34);
            this.rdbTitulo.Name = "rdbTitulo";
            this.rdbTitulo.Size = new System.Drawing.Size(51, 17);
            this.rdbTitulo.TabIndex = 112;
            this.rdbTitulo.Text = "Titulo";
            this.rdbTitulo.UseVisualStyleBackColor = true;
            // 
            // rdbId
            // 
            this.rdbId.AutoSize = true;
            this.rdbId.Location = new System.Drawing.Point(24, 34);
            this.rdbId.Name = "rdbId";
            this.rdbId.Size = new System.Drawing.Size(36, 17);
            this.rdbId.TabIndex = 111;
            this.rdbId.TabStop = true;
            this.rdbId.Text = "ID";
            this.rdbId.UseVisualStyleBackColor = true;
            // 
            // frmRelatorioCadastroLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRelatorioCadastroLivros";
            this.Text = "RELATÓRIO DE CADASTRO DE LIVROS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRelatorio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dtgRelatorio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisarLivro;
        private System.Windows.Forms.RadioButton rdbTitulo;
        private System.Windows.Forms.RadioButton rdbId;
    }
}