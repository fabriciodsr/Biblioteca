namespace View._4BI.Movimentacao
{
    partial class frmEmprestimoLivro
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
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtLivro = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.dtpDevol = new System.Windows.Forms.DateTimePicker();
            this.dtpEmp = new System.Windows.Forms.DateTimePicker();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAluno
            // 
            this.txtAluno.Enabled = false;
            this.txtAluno.Location = new System.Drawing.Point(80, 123);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(474, 20);
            this.txtAluno.TabIndex = 127;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(23, 73);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 16);
            this.lblTitulo.TabIndex = 123;
            this.lblTitulo.Text = "Título";
            // 
            // txtLivro
            // 
            this.txtLivro.Enabled = false;
            this.txtLivro.Location = new System.Drawing.Point(80, 73);
            this.txtLivro.Name = "txtLivro";
            this.txtLivro.Size = new System.Drawing.Size(474, 20);
            this.txtLivro.TabIndex = 120;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAluno.Location = new System.Drawing.Point(22, 123);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(47, 16);
            this.lblAluno.TabIndex = 119;
            this.lblAluno.Text = "Aluno";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(44, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 16);
            this.lblId.TabIndex = 117;
            this.lblId.Text = "Id.";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(80, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(101, 20);
            this.txtID.TabIndex = 116;
            // 
            // btnRenovar
            // 
            this.btnRenovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenovar.Location = new System.Drawing.Point(226, 295);
            this.btnRenovar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(127, 41);
            this.btnRenovar.TabIndex = 158;
            this.btnRenovar.Text = "Renovar";
            this.btnRenovar.UseVisualStyleBackColor = true;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 161;
            this.label1.Text = "SITUAÇÃO";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(26, 165);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(43, 32);
            this.lbl.TabIndex = 163;
            this.lbl.Text = "Data\r\nEmp.";
            // 
            // dtpDevol
            // 
            this.dtpDevol.Enabled = false;
            this.dtpDevol.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevol.Location = new System.Drawing.Point(80, 239);
            this.dtpDevol.Name = "dtpDevol";
            this.dtpDevol.Size = new System.Drawing.Size(101, 20);
            this.dtpDevol.TabIndex = 164;
            // 
            // dtpEmp
            // 
            this.dtpEmp.Enabled = false;
            this.dtpEmp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmp.Location = new System.Drawing.Point(80, 177);
            this.dtpEmp.Name = "dtpEmp";
            this.dtpEmp.Size = new System.Drawing.Size(101, 20);
            this.dtpEmp.TabIndex = 165;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Enabled = false;
            this.txtSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.Location = new System.Drawing.Point(400, 225);
            this.txtSituacao.Multiline = true;
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(154, 34);
            this.txtSituacao.TabIndex = 160;
            this.txtSituacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSituacao.TextChanged += new System.EventHandler(this.txtSituacao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 32);
            this.label2.TabIndex = 167;
            this.label2.Text = "Data\r\nDevol.";
            // 
            // frmEmprestimoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEmp);
            this.Controls.Add(this.dtpDevol);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.btnRenovar);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtLivro);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEmprestimoLivro";
            this.Text = "EMPRÉSTIMO";
            this.Load += new System.EventHandler(this.frmEmprestimoLivro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtLivro;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DateTimePicker dtpDevol;
        private System.Windows.Forms.DateTimePicker dtpEmp;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label label2;
    }
}