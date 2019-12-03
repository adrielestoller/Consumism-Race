namespace Consumism_Race
{
    partial class Narrativa
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
            this.btn_pular = new System.Windows.Forms.PictureBox();
            this.pic_narrativa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_narrativa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pular
            // 
            this.btn_pular.BackColor = System.Drawing.Color.Transparent;
            this.btn_pular.Image = global::Consumism_Race.Properties.Resources.botaodepularda_NARRATIVA__litlle_;
            this.btn_pular.Location = new System.Drawing.Point(601, 457);
            this.btn_pular.Name = "btn_pular";
            this.btn_pular.Size = new System.Drawing.Size(107, 93);
            this.btn_pular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_pular.TabIndex = 1;
            this.btn_pular.TabStop = false;
            this.btn_pular.Click += new System.EventHandler(this.Btn_pular_Click);
            // 
            // pic_narrativa
            // 
            this.pic_narrativa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_narrativa.Image = global::Consumism_Race.Properties.Resources.quadrinhodanarrativacompleto;
            this.pic_narrativa.Location = new System.Drawing.Point(0, 0);
            this.pic_narrativa.Name = "pic_narrativa";
            this.pic_narrativa.Size = new System.Drawing.Size(784, 561);
            this.pic_narrativa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_narrativa.TabIndex = 0;
            this.pic_narrativa.TabStop = false;
            // 
            // Narrativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_pular);
            this.Controls.Add(this.pic_narrativa);
            this.Name = "Narrativa";
            this.ShowIcon = false;
            this.Text = "Narrativa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Narrativa_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.btn_pular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_narrativa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_narrativa;
        private System.Windows.Forms.PictureBox btn_pular;
    }
}