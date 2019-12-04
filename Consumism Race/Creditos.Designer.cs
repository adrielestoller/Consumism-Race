namespace Consumism_Race
{
    partial class Creditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creditos));
            this.btn_casinha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_casinha)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_casinha
            // 
            this.btn_casinha.BackColor = System.Drawing.Color.Transparent;
            this.btn_casinha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_casinha.Image = global::Consumism_Race.Properties.Resources.Casinha_TABULEIRO__little_;
            this.btn_casinha.Location = new System.Drawing.Point(12, 518);
            this.btn_casinha.Name = "btn_casinha";
            this.btn_casinha.Size = new System.Drawing.Size(75, 61);
            this.btn_casinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_casinha.TabIndex = 6;
            this.btn_casinha.TabStop = false;
            this.btn_casinha.Click += new System.EventHandler(this.Btn_casinha_Click);
            // 
            // Creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 591);
            this.Controls.Add(this.btn_casinha);
            this.DoubleBuffered = true;
            this.Name = "Creditos";
            this.ShowIcon = false;
            this.Text = "Créditos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Creditos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.btn_casinha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_casinha;
    }
}