namespace View._4BI.Movimentacao
{
    partial class frmDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucao));
            this.dtgEmprestimos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSituacaoAluno = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSobreNome = new System.Windows.Forms.TextBox();
            this.txtIdAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.ID_EMPRESTIMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SITUACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_DEVOLUCAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_EMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdEmp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSituacaoEmprestimo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLivro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEmp = new System.Windows.Forms.DateTimePicker();
            this.dtpDevol = new System.Windows.Forms.DateTimePicker();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRenovar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmprestimos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgEmprestimos
            // 
            this.dtgEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmprestimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_EMPRESTIMO,
            this.TITULO,
            this.SITUACAO,
            this.DATA_DEVOLUCAO,
            this.DATA_EMP,
            this.NOME});
            this.dtgEmprestimos.Location = new System.Drawing.Point(10, 211);
            this.dtgEmprestimos.Name = "dtgEmprestimos";
            this.dtgEmprestimos.Size = new System.Drawing.Size(764, 238);
            this.dtgEmprestimos.TabIndex = 101;
            this.dtgEmprestimos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmprestimos_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPesquisa);
            this.groupBox1.Controls.Add(this.btnProcurar);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 42);
            this.groupBox1.TabIndex = 119;
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(602, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 16);
            this.label19.TabIndex = 143;
            this.label19.Text = "Situação";
            // 
            // txtSit
            // 
            this.txtSit.Enabled = false;
            this.txtSit.Location = new System.Drawing.Point(677, 59);
            this.txtSit.Name = "txtSit";
            this.txtSit.Size = new System.Drawing.Size(93, 20);
            this.txtSit.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 144;
            this.label1.Text = "Situação";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(113, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 16);
            this.label18.TabIndex = 139;
            this.label18.Text = "Nome";
            // 
            // txtSituacaoAluno
            // 
            this.txtSituacaoAluno.Enabled = false;
            this.txtSituacaoAluno.Location = new System.Drawing.Point(677, 59);
            this.txtSituacaoAluno.Name = "txtSituacaoAluno";
            this.txtSituacaoAluno.Size = new System.Drawing.Size(93, 20);
            this.txtSituacaoAluno.TabIndex = 142;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Enabled = false;
            this.txtNomeAluno.Location = new System.Drawing.Point(169, 61);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(174, 20);
            this.txtNomeAluno.TabIndex = 131;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 140;
            this.label7.Text = "Nome";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(349, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 16);
            this.label17.TabIndex = 137;
            this.label17.Text = "Sobrenome";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(169, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(174, 20);
            this.txtNome.TabIndex = 132;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(443, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 138;
            this.label4.Text = "Sobrenome";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 16);
            this.label16.TabIndex = 135;
            this.label16.Text = "Id.";
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.Enabled = false;
            this.txtSobreNome.Location = new System.Drawing.Point(443, 61);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.Size = new System.Drawing.Size(157, 20);
            this.txtSobreNome.TabIndex = 134;
            // 
            // txtIdAluno
            // 
            this.txtIdAluno.Enabled = false;
            this.txtIdAluno.Location = new System.Drawing.Point(44, 60);
            this.txtIdAluno.Name = "txtIdAluno";
            this.txtIdAluno.Size = new System.Drawing.Size(67, 20);
            this.txtIdAluno.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 136;
            this.label3.Text = "Id.";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(44, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(67, 20);
            this.txtID.TabIndex = 130;
            // 
            // ID_EMPRESTIMO
            // 
            this.ID_EMPRESTIMO.DataPropertyName = "ID_EMP";
            this.ID_EMPRESTIMO.HeaderText = "ID EMP";
            this.ID_EMPRESTIMO.Name = "ID_EMPRESTIMO";
            // 
            // TITULO
            // 
            this.TITULO.DataPropertyName = "TITULO";
            this.TITULO.HeaderText = "LIVRO";
            this.TITULO.Name = "TITULO";
            // 
            // SITUACAO
            // 
            this.SITUACAO.DataPropertyName = "SITUACAO";
            this.SITUACAO.HeaderText = "SITUAÇÃO";
            this.SITUACAO.Name = "SITUACAO";
            // 
            // DATA_DEVOLUCAO
            // 
            this.DATA_DEVOLUCAO.DataPropertyName = "DATA_DEVOL";
            this.DATA_DEVOLUCAO.HeaderText = "DATA DE DEVOLUÇÃO";
            this.DATA_DEVOLUCAO.Name = "DATA_DEVOLUCAO";
            // 
            // DATA_EMP
            // 
            this.DATA_EMP.DataPropertyName = "DATA_EMP";
            this.DATA_EMP.HeaderText = "DATA DE EMPRÉSTIMO";
            this.DATA_EMP.Name = "DATA_EMP";
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "TITULO";
            this.NOME.HeaderText = "ALUNO";
            this.NOME.Name = "NOME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(596, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 160;
            this.label6.Text = "Situação";
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.Enabled = false;
            this.txtIdEmp.Location = new System.Drawing.Point(70, 30);
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.Size = new System.Drawing.Size(71, 20);
            this.txtIdEmp.TabIndex = 145;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(156, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 155;
            this.label8.Text = "Livro";
            // 
            // txtSituacaoEmprestimo
            // 
            this.txtSituacaoEmprestimo.Enabled = false;
            this.txtSituacaoEmprestimo.Location = new System.Drawing.Point(667, 29);
            this.txtSituacaoEmprestimo.Name = "txtSituacaoEmprestimo";
            this.txtSituacaoEmprestimo.Size = new System.Drawing.Size(93, 20);
            this.txtSituacaoEmprestimo.TabIndex = 158;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 152;
            this.label9.Text = "Id. Emp";
            // 
            // txtLivro
            // 
            this.txtLivro.Enabled = false;
            this.txtLivro.Location = new System.Drawing.Point(204, 31);
            this.txtLivro.Name = "txtLivro";
            this.txtLivro.Size = new System.Drawing.Size(386, 20);
            this.txtLivro.TabIndex = 148;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 32);
            this.label5.TabIndex = 171;
            this.label5.Text = "Data\r\nDevol.";
            // 
            // dtpEmp
            // 
            this.dtpEmp.Enabled = false;
            this.dtpEmp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmp.Location = new System.Drawing.Point(70, 77);
            this.dtpEmp.Name = "dtpEmp";
            this.dtpEmp.Size = new System.Drawing.Size(101, 20);
            this.dtpEmp.TabIndex = 170;
            // 
            // dtpDevol
            // 
            this.dtpDevol.Enabled = false;
            this.dtpDevol.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevol.Location = new System.Drawing.Point(271, 78);
            this.dtpDevol.Name = "dtpDevol";
            this.dtpDevol.Size = new System.Drawing.Size(101, 20);
            this.dtpDevol.TabIndex = 169;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(3, 70);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(43, 32);
            this.lbl.TabIndex = 168;
            this.lbl.Text = "Data\r\nEmp.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRenovar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpEmp);
            this.groupBox2.Controls.Add(this.dtpDevol);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIdEmp);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSituacaoEmprestimo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtLivro);
            this.groupBox2.Location = new System.Drawing.Point(10, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 112);
            this.groupBox2.TabIndex = 172;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empréstimo";
            // 
            // btnRenovar
            // 
            this.btnRenovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenovar.Location = new System.Drawing.Point(392, 61);
            this.btnRenovar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(372, 41);
            this.btnRenovar.TabIndex = 172;
            this.btnRenovar.Text = "DEVOLVER";
            this.btnRenovar.UseVisualStyleBackColor = true;
            // 
            // frmDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSit);
            this.Controls.Add(this.dtgEmprestimos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdAluno);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtSituacaoAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.txtSobreNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDevolucao";
            this.Text = "DEVOLUÇÃO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDevolucao_FormClosed);
            this.Load += new System.EventHandler(this.frmDevolucao_Load);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSituacaoAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.TextBox txtIdAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPRESTIMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SITUACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_DEVOLUCAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_EMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSituacaoEmprestimo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLivro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEmp;
        private System.Windows.Forms.DateTimePicker dtpDevol;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRenovar;
    }
}