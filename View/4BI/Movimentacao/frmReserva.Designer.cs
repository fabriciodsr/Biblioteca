namespace View._4BI.Movimentacao
{
    partial class frmReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            this.dtgReservas = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtAutores = new System.Windows.Forms.TextBox();
            this.lblAutores = new System.Windows.Forms.Label();
            this.btnPesquisaTitulo = new System.Windows.Forms.Button();
            this.LblVolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.LblIdLivro = new System.Windows.Forms.Label();
            this.txtIDLivro = new System.Windows.Forms.TextBox();
            this.btnPesquisarAluno = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgReservas
            // 
            this.dtgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReservas.Location = new System.Drawing.Point(13, 165);
            this.dtgReservas.Margin = new System.Windows.Forms.Padding(4);
            this.dtgReservas.Name = "dtgReservas";
            this.dtgReservas.Size = new System.Drawing.Size(1019, 383);
            this.dtgReservas.TabIndex = 117;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Red;
            this.btnSalvar.Location = new System.Drawing.Point(964, 18);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(67, 62);
            this.btnSalvar.TabIndex = 116;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // txtAutores
            // 
            this.txtAutores.Enabled = false;
            this.txtAutores.Location = new System.Drawing.Point(371, 121);
            this.txtAutores.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutores.Name = "txtAutores";
            this.txtAutores.Size = new System.Drawing.Size(487, 22);
            this.txtAutores.TabIndex = 115;
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutores.Location = new System.Drawing.Point(288, 123);
            this.lblAutores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(74, 20);
            this.lblAutores.TabIndex = 114;
            this.lblAutores.Text = "Autores";
            // 
            // btnPesquisaTitulo
            // 
            this.btnPesquisaTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisaTitulo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPesquisaTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisaTitulo.BackgroundImage")));
            this.btnPesquisaTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisaTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisaTitulo.Location = new System.Drawing.Point(881, 69);
            this.btnPesquisaTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisaTitulo.Name = "btnPesquisaTitulo";
            this.btnPesquisaTitulo.Size = new System.Drawing.Size(35, 26);
            this.btnPesquisaTitulo.TabIndex = 113;
            this.btnPesquisaTitulo.UseVisualStyleBackColor = false;
            // 
            // LblVolume
            // 
            this.LblVolume.AutoSize = true;
            this.LblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVolume.Location = new System.Drawing.Point(52, 123);
            this.LblVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVolume.Name = "LblVolume";
            this.LblVolume.Size = new System.Drawing.Size(41, 20);
            this.LblVolume.TabIndex = 112;
            this.LblVolume.Text = "Vol.";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(108, 121);
            this.txtVolume.Margin = new System.Windows.Forms.Padding(4);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(133, 22);
            this.txtVolume.TabIndex = 111;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(307, 73);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(56, 20);
            this.lblTitulo.TabIndex = 110;
            this.lblTitulo.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(371, 73);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(487, 22);
            this.txtTitulo.TabIndex = 109;
            // 
            // LblIdLivro
            // 
            this.LblIdLivro.AutoSize = true;
            this.LblIdLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdLivro.Location = new System.Drawing.Point(16, 73);
            this.LblIdLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdLivro.Name = "LblIdLivro";
            this.LblIdLivro.Size = new System.Drawing.Size(77, 20);
            this.LblIdLivro.TabIndex = 108;
            this.LblIdLivro.Text = "Id. Livro";
            // 
            // txtIDLivro
            // 
            this.txtIDLivro.Enabled = false;
            this.txtIDLivro.Location = new System.Drawing.Point(108, 71);
            this.txtIDLivro.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDLivro.Name = "txtIDLivro";
            this.txtIDLivro.Size = new System.Drawing.Size(133, 22);
            this.txtIDLivro.TabIndex = 107;
            // 
            // btnPesquisarAluno
            // 
            this.btnPesquisarAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarAluno.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPesquisarAluno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarAluno.BackgroundImage")));
            this.btnPesquisarAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarAluno.Location = new System.Drawing.Point(881, 18);
            this.btnPesquisarAluno.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarAluno.Name = "btnPesquisarAluno";
            this.btnPesquisarAluno.Size = new System.Drawing.Size(35, 26);
            this.btnPesquisarAluno.TabIndex = 106;
            this.btnPesquisarAluno.UseVisualStyleBackColor = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(305, 23);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 20);
            this.lblNome.TabIndex = 105;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(371, 23);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(487, 22);
            this.txtNome.TabIndex = 104;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(64, 23);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 20);
            this.lblId.TabIndex = 103;
            this.lblId.Text = "Id.";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(108, 21);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(133, 22);
            this.txtID.TabIndex = 102;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.dtgReservas);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtAutores);
            this.Controls.Add(this.lblAutores);
            this.Controls.Add(this.btnPesquisaTitulo);
            this.Controls.Add(this.LblVolume);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.LblIdLivro);
            this.Controls.Add(this.txtIDLivro);
            this.Controls.Add(this.btnPesquisarAluno);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReserva";
            this.Text = "RESERVAS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReserva_FormClosed);
            this.Load += new System.EventHandler(this.frmReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgReservas;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtAutores;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.Button btnPesquisaTitulo;
        private System.Windows.Forms.Label LblVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label LblIdLivro;
        private System.Windows.Forms.TextBox txtIDLivro;
        private System.Windows.Forms.Button btnPesquisarAluno;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtID;
    }
}