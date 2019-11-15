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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            Jogar jogar = new Jogar();

            jogar.Show();
            this.Hide();
        }

        private void btn_creditos_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();

            creditos.Show();
        }
    }
}
