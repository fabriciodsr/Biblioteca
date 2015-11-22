namespace View._4BI.Movimentacao
{
    partial class frmEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmprestimo));
            this.dtgEmprestimos = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSobreNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSituacaoAluno = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPesquisaLivro = new System.Windows.Forms.ComboBox();
            this.txtProcurarLivro = new System.Windows.Forms.TextBox();
            this.btnProcurarLivro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp_Publicacao = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSituacaoLivro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIDLivro = new System.Windows.Forms.TextBox();
            this.txtAutor1 = new System.Windows.Forms.TextBox();
            this.txtAutor2 = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmprestimos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgEmprestimos
            // 
            this.dtgEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmprestimos.Location = new System.Drawing.Point(10, 250);
            this.dtgEmprestimos.Name = "dtgEmprestimos";
            this.dtgEmprestimos.Size = new System.Drawing.Size(764, 195);
            this.dtgEmprestimos.TabIndex = 117;
            // 
            // btnInserir
            // 
            this.btnInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserir.BackColor = System.Drawing.Color.Transparent;
            this.btnInserir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInserir.BackgroundImage")));
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.Red;
            this.btnInserir.Location = new System.Drawing.Point(719, 163);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(50, 50);
            this.btnInserir.TabIndex = 116;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPesquisa);
            this.groupBox1.Controls.Add(this.btnProcurar);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 42);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "ID",
            "NOME"});
            this.cmbPesquisa.Location = new System.Drawing.Point(135, 15);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(101, 21);
            this.cmbPesquisa.TabIndex = 0;
            this.cmbPesquisa.SelectedIndexChanged += new System.EventHandler(this.cmbPesquisa_SelectedIndexChanged);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.BackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProcurar.BackgroundImage")));
            this.btnProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.ForeColor = System.Drawing.Color.Transparent;
            this.btnProcurar.Location = new System.Drawing.Point(716, 11);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(31, 26);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(253, 16);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(445, 20);
            this.txtPesquisa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Opção de Busca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 126;
            this.label7.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(170, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(174, 20);
            this.txtNome.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 124;
            this.label4.Text = "Sobrenome";
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.Enabled = false;
            this.txtSobreNome.Location = new System.Drawing.Point(444, 61);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.Size = new System.Drawing.Size(157, 20);
            this.txtSobreNome.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 123;
            this.label3.Text = "Id.";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(45, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(67, 20);
            this.txtID.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 128;
            this.label1.Text = "Situação";
            // 
            // txtSituacaoAluno
            // 
            this.txtSituacaoAluno.Enabled = false;
            this.txtSituacaoAluno.Location = new System.Drawing.Point(678, 59);
            this.txtSituacaoAluno.Name = "txtSituacaoAluno";
            this.txtSituacaoAluno.Size = new System.Drawing.Size(93, 20);
            this.txtSituacaoAluno.TabIndex = 127;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPesquisaLivro);
            this.groupBox2.Controls.Add(this.txtProcurarLivro);
            this.groupBox2.Controls.Add(this.btnProcurarLivro);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(14, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 42);
            this.groupBox2.TabIndex = 129;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Livro";
            // 
            // cmbPesquisaLivro
            // 
            this.cmbPesquisaLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesquisaLivro.FormattingEnabled = true;
            this.cmbPesquisaLivro.Items.AddRange(new object[] {
            "ID",
            "TITULO"});
            this.cmbPesquisaLivro.Location = new System.Drawing.Point(133, 15);
            this.cmbPesquisaLivro.Name = "cmbPesquisaLivro";
            this.cmbPesquisaLivro.Size = new System.Drawing.Size(101, 21);
            this.cmbPesquisaLivro.TabIndex = 130;
            this.cmbPesquisaLivro.SelectedIndexChanged += new System.EventHandler(this.cmbPesquisaLivro_SelectedIndexChanged);
            // 
            // txtProcurarLivro
            // 
            this.txtProcurarLivro.Location = new System.Drawing.Point(251, 16);
            this.txtProcurarLivro.Name = "txtProcurarLivro";
            this.txtProcurarLivro.Size = new System.Drawing.Size(445, 20);
            this.txtProcurarLivro.TabIndex = 131;
            // 
            // btnProcurarLivro
            // 
            this.btnProcurarLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurarLivro.BackColor = System.Drawing.Color.Transparent;
            this.btnProcurarLivro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProcurarLivro.BackgroundImage")));
            this.btnProcurarLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProcurarLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurarLivro.FlatAppearance.BorderSize = 0;
            this.btnProcurarLivro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProcurarLivro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProcurarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarLivro.ForeColor = System.Drawing.Color.Transparent;
            this.btnProcurarLivro.Location = new System.Drawing.Point(716, 11);
            this.btnProcurarLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProcurarLivro.Name = "btnProcurarLivro";
            this.btnProcurarLivro.Size = new System.Drawing.Size(31, 26);
            this.btnProcurarLivro.TabIndex = 2;
            this.btnProcurarLivro.UseVisualStyleBackColor = false;
            this.btnProcurarLivro.Click += new System.EventHandler(this.btnProcurarLivro_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(4, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 132;
            this.label6.Text = "Opção de Busca";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(338, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 147;
            this.label14.Text = "Gênero";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 146;
            this.label13.Text = "Edit.";
            // 
            // dtp_Publicacao
            // 
            this.dtp_Publicacao.Enabled = false;
            this.dtp_Publicacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Publicacao.Location = new System.Drawing.Point(58, 195);
            this.dtp_Publicacao.Name = "dtp_Publicacao";
            this.dtp_Publicacao.Size = new System.Drawing.Size(101, 20);
            this.dtp_Publicacao.TabIndex = 134;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(590, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 145;
            this.label9.Text = "Situação";
            // 
            // txtSituacaoLivro
            // 
            this.txtSituacaoLivro.Enabled = false;
            this.txtSituacaoLivro.Location = new System.Drawing.Point(546, 195);
            this.txtSituacaoLivro.Name = "txtSituacaoLivro";
            this.txtSituacaoLivro.Size = new System.Drawing.Size(164, 20);
            this.txtSituacaoLivro.TabIndex = 136;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 144;
            this.label8.Text = "Publ.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 141;
            this.label5.Text = "Autor 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(197, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 142;
            this.label10.Text = "Autor 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(206, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 143;
            this.label11.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(265, 136);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(445, 20);
            this.txtTitulo.TabIndex = 131;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 140;
            this.label12.Text = "Vol.";
            // 
            // txtVolume
            // 
            this.txtVolume.Enabled = false;
            this.txtVolume.Location = new System.Drawing.Point(58, 164);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(101, 20);
            this.txtVolume.TabIndex = 132;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 16);
            this.label15.TabIndex = 139;
            this.label15.Text = "Id.";
            // 
            // txtIDLivro
            // 
            this.txtIDLivro.Enabled = false;
            this.txtIDLivro.Location = new System.Drawing.Point(58, 136);
            this.txtIDLivro.Name = "txtIDLivro";
            this.txtIDLivro.Size = new System.Drawing.Size(101, 20);
            this.txtIDLivro.TabIndex = 130;
            // 
            // txtAutor1
            // 
            this.txtAutor1.Enabled = false;
            this.txtAutor1.Location = new System.Drawing.Point(265, 165);
            this.txtAutor1.Name = "txtAutor1";
            this.txtAutor1.Size = new System.Drawing.Size(246, 20);
            this.txtAutor1.TabIndex = 148;
            // 
            // txtAutor2
            // 
            this.txtAutor2.Enabled = false;
            this.txtAutor2.Location = new System.Drawing.Point(265, 195);
            this.txtAutor2.Name = "txtAutor2";
            this.txtAutor2.Size = new System.Drawing.Size(246, 20);
            this.txtAutor2.TabIndex = 149;
            // 
            // txtEditora
            // 
            this.txtEditora.Enabled = false;
            this.txtEditora.Location = new System.Drawing.Point(56, 224);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(246, 20);
            this.txtEditora.TabIndex = 150;
            // 
            // txtGenero
            // 
            this.txtGenero.Enabled = false;
            this.txtGenero.Location = new System.Drawing.Point(403, 224);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(307, 20);
            this.txtGenero.TabIndex = 151;
            // 
            // frmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtAutor2);
            this.Controls.Add(this.txtAutor1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtp_Publicacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSituacaoLivro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtIDLivro);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSituacaoAluno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSobreNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgEmprestimos);
            this.Controls.Add(this.btnInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEmprestimo";
            this.Text = "EMPRÉSTIMOS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEmprestimo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmprestimos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEmprestimos;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSituacaoAluno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProcurarLivro;
        private System.Windows.Forms.ComboBox cmbPesquisaLivro;
        private System.Windows.Forms.TextBox txtProcurarLivro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp_Publicacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSituacaoLivro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIDLivro;
        private System.Windows.Forms.TextBox txtAutor1;
        private System.Windows.Forms.TextBox txtAutor2;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtGenero;
    }
}