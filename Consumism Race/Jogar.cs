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
    public partial class Jogar : Form
    {
        public Jogar()
        {
            InitializeComponent();
        }

        private void peca_bq_MouseDown(object sender, MouseEventArgs e)
        {
            Button peca_bq = (Button)sender;

            peca_bq.DoDragDrop(peca_bq, DragDropEffects.Move);
        }

        private void tableLayoutPanel_tabuleiro_DragDrop(object sender, DragEventArgs e)
        {
            Button botao = (Button)e.Data.GetData(typeof(Button));
            Point loc = tableLayoutPanel_tabuleiro.PointToClient(new Point(e.X, e.Y));

            int ColumnIndex = -1;
            int RowIndex = -1;
            int x = 0;
            int y = 0;

            while (ColumnIndex <= tableLayoutPanel_tabuleiro.ColumnCount)
            {
                if (loc.X < x)
                {
                    break;
                }

                ColumnIndex++;
                x += tableLayoutPanel_tabuleiro.GetColumnWidths()[ColumnIndex];
            }

            while (RowIndex <= tableLayoutPanel_tabuleiro.RowCount)
            {

                if (loc.Y < y)
                {
                    break;
                }

                RowIndex++;
                y += tableLayoutPanel_tabuleiro.GetRowHeights()[RowIndex];
            }

            tableLayoutPanel_tabuleiro.Controls.Add(botao, ColumnIndex, RowIndex); 
        }

        private void tableLayoutPanel_tabuleiro_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
