namespace Consumism_Race
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_jogar = new System.Windows.Forms.PictureBox();
            this.btn_creditos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_jogar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_creditos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_jogar
            // 
            this.btn_jogar.BackColor = System.Drawing.Color.Transparent;
            this.btn_jogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_jogar.Image = global::Consumism_Race.Properties.Resources.botãodejogar;
            this.btn_jogar.Location = new System.Drawing.Point(338, 329);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(153, 75);
            this.btn_jogar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_jogar.TabIndex = 2;
            this.btn_jogar.TabStop = false;
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
            // 
            // btn_creditos
            // 
            this.btn_creditos.BackColor = System.Drawing.Color.Transparent;
            this.btn_creditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_creditos.Image = global::Consumism_Race.Properties.Resources.botãodecŕeditos;
            this.btn_creditos.Location = new System.Drawing.Point(346, 410);
            this.btn_creditos.Name = "btn_creditos";
            this.btn_creditos.Size = new System.Drawing.Size(136, 67);
            this.btn_creditos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_creditos.TabIndex = 3;
            this.btn_creditos.TabStop = false;
            this.btn_creditos.Click += new System.EventHandler(this.btn_creditos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 599);
            this.Controls.Add(this.btn_creditos);
            this.Controls.Add(this.btn_jogar);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "Consumism Race";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.btn_jogar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_creditos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_jogar;
        private System.Windows.Forms.PictureBox btn_creditos;


    }
}

