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
    public partial class Jogo : Form
    {
        public Jogo()
        {
            InitializeComponent();
            Image vezBq = Image.FromFile(@"..\..\Resources\VEZBURGUERQUEEN.png");
            Image vezMc = Image.FromFile(@"..\..\Resources\VEZDEMCDUCK.png");
        }

        private void pecas_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox peca = (PictureBox)sender;

            peca.DoDragDrop(peca, DragDropEffects.Move);
        }

        private void tabuleiro_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void tabuleiro_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox botao = (PictureBox)e.Data.GetData(typeof(PictureBox));
            Point loc = tabuleiro.PointToClient(new Point(e.X, e.Y));


            int ColumnIndex = -1;
            int RowIndex = -1;
            int x = 0;
            int y = 0;

            while (ColumnIndex <= tabuleiro.ColumnCount)
            {
                if (loc.X < x)
                {
                    break;
                }

                ColumnIndex++;
                x += tabuleiro.GetColumnWidths()[ColumnIndex];
            }

            while (RowIndex <= tabuleiro.RowCount)
            {

                if (loc.Y < y)
                {
                    break;
                }

                RowIndex++;
                y += tabuleiro.GetRowHeights()[RowIndex];
            }

            tabuleiro.Controls.Add(botao, ColumnIndex, RowIndex);
        }

        //Alguém me mata pfvrr

        private void Jogo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();

            menu.Show();
        }
    }
}
