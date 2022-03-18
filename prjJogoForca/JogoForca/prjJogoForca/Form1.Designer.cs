namespace prjJogoForca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnLetra = new System.Windows.Forms.Panel();
            this.btnJogar = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPalavra = new System.Windows.Forms.Panel();
            this.pbForca = new System.Windows.Forms.PictureBox();
            this.pbBoneco = new System.Windows.Forms.PictureBox();
            this.pnLetra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoneco)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLetra
            // 
            this.pnLetra.BackColor = System.Drawing.Color.Transparent;
            this.pnLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLetra.Controls.Add(this.btnJogar);
            this.pnLetra.Controls.Add(this.txtLetra);
            this.pnLetra.Controls.Add(this.label1);
            this.pnLetra.Location = new System.Drawing.Point(12, 12);
            this.pnLetra.Name = "pnLetra";
            this.pnLetra.Size = new System.Drawing.Size(280, 212);
            this.pnLetra.TabIndex = 0;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Maroon;
            this.btnJogar.FlatAppearance.BorderSize = 3;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.ForeColor = System.Drawing.Color.White;
            this.btnJogar.Location = new System.Drawing.Point(11, 116);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(255, 84);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetra.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra.Location = new System.Drawing.Point(11, 65);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(255, 45);
            this.txtLetra.TabIndex = 1;
            this.txtLetra.Text = "A";
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE LETRA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnPalavra
            // 
            this.pnPalavra.BackColor = System.Drawing.Color.Transparent;
            this.pnPalavra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPalavra.Location = new System.Drawing.Point(298, 13);
            this.pnPalavra.Name = "pnPalavra";
            this.pnPalavra.Size = new System.Drawing.Size(801, 211);
            this.pnPalavra.TabIndex = 1;
            // 
            // pbForca
            // 
            this.pbForca.BackColor = System.Drawing.Color.Transparent;
            this.pbForca.Image = ((System.Drawing.Image)(resources.GetObject("pbForca.Image")));
            this.pbForca.Location = new System.Drawing.Point(12, 230);
            this.pbForca.Name = "pbForca";
            this.pbForca.Size = new System.Drawing.Size(238, 310);
            this.pbForca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbForca.TabIndex = 2;
            this.pbForca.TabStop = false;
            // 
            // pbBoneco
            // 
            this.pbBoneco.BackColor = System.Drawing.Color.Transparent;
            this.pbBoneco.Location = new System.Drawing.Point(125, 273);
            this.pbBoneco.Name = "pbBoneco";
            this.pbBoneco.Size = new System.Drawing.Size(194, 332);
            this.pbBoneco.TabIndex = 3;
            this.pbBoneco.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1111, 617);
            this.Controls.Add(this.pbBoneco);
            this.Controls.Add(this.pbForca);
            this.Controls.Add(this.pnPalavra);
            this.Controls.Add(this.pnLetra);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOGO DA FORCA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnLetra.ResumeLayout(false);
            this.pnLetra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoneco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnLetra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Panel pnPalavra;
        private System.Windows.Forms.PictureBox pbForca;
        private System.Windows.Forms.PictureBox pbBoneco;
    }
}

