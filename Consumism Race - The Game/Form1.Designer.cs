namespace WindowsFormsApp1
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.Botão_Opções = new System.Windows.Forms.Button();
            this.Botão_Créditos = new System.Windows.Forms.Button();
            this.Botão_Jogar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Botão_Iniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Botão_Opções
            // 
            this.Botão_Opções.Location = new System.Drawing.Point(350, 280);
            this.Botão_Opções.Name = "Botão_Opções";
            this.Botão_Opções.Size = new System.Drawing.Size(100, 25);
            this.Botão_Opções.TabIndex = 1;
            this.Botão_Opções.Text = "OPÇÕES";
            this.Botão_Opções.UseVisualStyleBackColor = true;
            this.Botão_Opções.Click += new System.EventHandler(this.Botão_Opções_Click);
            // 
            // Botão_Créditos
            // 
            this.Botão_Créditos.Location = new System.Drawing.Point(350, 380);
            this.Botão_Créditos.Name = "Botão_Créditos";
            this.Botão_Créditos.Size = new System.Drawing.Size(100, 25);
            this.Botão_Créditos.TabIndex = 2;
            this.Botão_Créditos.Text = "CRÉDITOS";
            this.Botão_Créditos.UseVisualStyleBackColor = true;
            this.Botão_Créditos.Click += new System.EventHandler(this.Botão_Créditos_Click);
            // 
            // Botão_Jogar
            // 
            this.Botão_Jogar.Location = new System.Drawing.Point(300, 200);
            this.Botão_Jogar.Name = "Botão_Jogar";
            this.Botão_Jogar.Size = new System.Drawing.Size(200, 50);
            this.Botão_Jogar.TabIndex = 3;
            this.Botão_Jogar.Text = "JOGAR";
            this.Botão_Jogar.UseVisualStyleBackColor = true;
            this.Botão_Jogar.Click += new System.EventHandler(this.Botão_Jogar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.label1.Location = new System.Drawing.Point(140, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "COMUNISM RACE";
            // 
            // Botão_Iniciar
            // 
            this.Botão_Iniciar.Location = new System.Drawing.Point(350, 330);
            this.Botão_Iniciar.Name = "Botão_Iniciar";
            this.Botão_Iniciar.Size = new System.Drawing.Size(100, 25);
            this.Botão_Iniciar.TabIndex = 5;
            this.Botão_Iniciar.Text = "INICIAR";
            this.Botão_Iniciar.UseVisualStyleBackColor = true;
            this.Botão_Iniciar.Click += new System.EventHandler(this.Botão_Iniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(600, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 253);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Botão_Iniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Botão_Jogar);
            this.Controls.Add(this.Botão_Créditos);
            this.Controls.Add(this.Botão_Opções);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormMenu";
            this.Text = "Hasami Shogi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Botão_Opções;
        private System.Windows.Forms.Button Botão_Créditos;
        private System.Windows.Forms.Button Botão_Jogar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Botão_Iniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

