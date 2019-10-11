using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Botão_Jogar_Click(object sender, EventArgs e)
        {
            Form FormJogar = new Form();
            FormJogar.Show();
        }

        private void Botão_Opções_Click(object sender, EventArgs e)
        {
            Form FormOpções = new Form();
            FormOpções.Show();
        }

        private void Botão_Iniciar_Click(object sender, EventArgs e)
        {
            Form FormIniciar = new Form();
            FormIniciar.Show();
        }

        private void Botão_Créditos_Click(object sender, EventArgs e)
        {
            Form FormCréditos = new Form();
            FormCréditos.Show();
        }
    }
}
