namespace View
{
    partial class frmConsultaGeneros
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaGeneros));
            this.dtgGeneros = new System.Windows.Forms.DataGridView();
            this.gENEROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENEROBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGeneros
            // 
            this.dtgGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGeneros.Location = new System.Drawing.Point(13, 142);
            this.dtgGeneros.Name = "dtgGeneros";
            this.dtgGeneros.Size = new System.Drawing.Size(759, 298);
            this.dtgGeneros.TabIndex = 3;
            // 
            // gENEROBindingSource
            // 
            this.gENEROBindingSource.DataSource = typeof(Model.GENERO);
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "TODOS",
            "ID",
            "NOME"});
            this.cmbPesquisa.Location = new System.Drawing.Point(198, 56);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(101, 21);
            this.cmbPesquisa.TabIndex = 0;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(316, 57);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(208, 20);
            this.txtPesquisa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(69, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 121;
            this.label2.Text = "Opção de Busca";
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
            this.btnProcurar.Location = new System.Drawing.Point(531, 40);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(50, 50);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(18, 86);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 119;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmConsultaGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.cmbPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtgGeneros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultaGeneros";
            this.Text = "CONSULTA DE GÊNEROS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsultaGeneros_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENEROBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgGeneros;
        private System.Windows.Forms.BindingSource gENEROBindingSource;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnCancelar;
    }
}