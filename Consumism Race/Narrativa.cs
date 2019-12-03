using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consumism_Race
{
    public partial class Narrativa : Form
    {
        public Narrativa()
        {
            InitializeComponent();
        }

        private void Btn_pular_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Narrativa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Jogar jogo = new Jogar();

            jogo.Show();
        }
    }
}
