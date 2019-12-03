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
        PictureBox pecaLado;
        PictureBox pecaOutroLado;
        PictureBox pecaAnteriorAmarela;
        PictureBox pecaAnteriorAzul;

        int vez = 0;

        Image vezBQ;
        Image vezMD;
        Image pecaazul;
        Image pecaamarela;

        TableLayoutPanelCellPosition posicaoAnterior;

        int seg = 01, min = 05;

        public Jogar()
        {
            InitializeComponent();

            vezBQ = Properties.Resources.VEZBURGUERQUEEN;
            vezMD = Properties.Resources.VEZDEMCDUCK;
            pecaazul = Properties.Resources.peçadabqq;
            pecaamarela = Properties.Resources.peçadomc;

            timerCronômetro.Enabled = true;
        }

        private void pecaBQ_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pecabq = (PictureBox)sender;

            posicaoAnterior = tabuleiro.GetPositionFromControl(pecabq);
            pecabq.DoDragDrop(pecabq, DragDropEffects.Move);

            pecaAnteriorAzul = pecabq;
        }

        private void pecaMD_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pecamd = (PictureBox)sender;

            posicaoAnterior = tabuleiro.GetPositionFromControl(pecamd);
            pecamd.DoDragDrop(pecamd, DragDropEffects.Move);

            pecaAnteriorAmarela = pecamd;
        }

        private void tabuleiro_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void tabuleiro_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox peca = (PictureBox)e.Data.GetData(typeof(PictureBox));    
            Point loc = tabuleiro.PointToClient(new Point(e.X, e.Y));

            int ColumnIndex = -1;
            int RowIndex = -1;
            int x = 0;
            int y = 0;

            if (vez % 2 != 0)
            {
                if (peca.Name.StartsWith("pecabq"))
                {
                    MessageBox.Show("Não é seu turno! Espere Mc Duck completar sua jogada!", "ATENÇÃO!");
                }
            }
            else
            {
                if (peca.Name.StartsWith("pecamd"))
                {
                    MessageBox.Show("Não é seu turno! Espere Burguer Queen completar sua jogada!", "ATENÇÃO!");
                }
            }

            if (peca.Name.StartsWith("pecabq") && vez % 2 == 0)
            {

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

                if (posicaoAnterior.Row == RowIndex && posicaoAnterior.Column != ColumnIndex)
                {
                    tabuleiro.Controls.Add(peca, ColumnIndex, RowIndex);

                    if (vez % 2 == 0)
                    {
                        pic_fundo.Image = vezMD;
                    }
                    else
                    {
                        pic_fundo.Image = vezBQ;
                    }
                }
                else if (posicaoAnterior.Column == ColumnIndex && posicaoAnterior.Row != RowIndex)
                {
                    tabuleiro.Controls.Add(peca, ColumnIndex, RowIndex);

                    if (vez % 2 == 0)
                    {
                        pic_fundo.Image = vezMD;
                    }
                    else
                    {
                        pic_fundo.Image = vezBQ;
                    }
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                    vez--;
                }

                vez++;
            }
            else if(peca.Name.StartsWith("pecamd") && vez % 2 != 0)
            {

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

                if (posicaoAnterior.Row == RowIndex && posicaoAnterior.Column != ColumnIndex)
                {
                    tabuleiro.Controls.Add(peca, ColumnIndex, RowIndex);

                    if (vez % 2 == 0)
                    {
                        pic_fundo.Image = vezMD;
                    }
                    else
                    {
                        pic_fundo.Image = vezBQ;
                    }
                }
                else if (posicaoAnterior.Column == ColumnIndex && posicaoAnterior.Row != RowIndex)
                {
                    tabuleiro.Controls.Add(peca, ColumnIndex, RowIndex);

                    if (vez % 2 == 0)
                    {
                        pic_fundo.Image = vezMD;
                    }
                    else
                    {
                        pic_fundo.Image = vezBQ;
                    }
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                    vez--;
                }

                vez++;
            }

            if (tabuleiro.GetControlFromPosition(peca.Location.X + 2, peca.Location.Y) as PictureBox != null)
            {
                pecaLado = tabuleiro.GetControlFromPosition(peca.Location.X + 2, peca.Location.Y) as PictureBox;

                if (tabuleiro.GetControlFromPosition(peca.Location.X + 1, peca.Location.Y) as PictureBox != null)
                {
                    pecaOutroLado = tabuleiro.GetControlFromPosition(peca.Location.X + 1, peca.Location.Y) as PictureBox;

                    if (pecaLado.Image == pecaamarela && pecaOutroLado.Image == pecaazul)
                    {
                        MessageBox.Show("aaa");
                    }
                }
            }
            else if (tabuleiro.GetControlFromPosition(peca.Location.X - 2, peca.Location.Y) as PictureBox != null)
            {
                pecaLado = tabuleiro.GetControlFromPosition(peca.Location.X - 2, peca.Location.Y) as PictureBox;

                if (tabuleiro.GetControlFromPosition(peca.Location.X - 1, peca.Location.Y) as PictureBox != null)
                {
                    pecaOutroLado = tabuleiro.GetControlFromPosition(peca.Location.X - 1, peca.Location.Y) as PictureBox;

                    if (pecaLado.Image == pecaamarela && pecaOutroLado.Image == pecaazul)
                    {
                        MessageBox.Show("aaa");
                    }
                }
            }
        }

        private void TimerCronômetro_Tick(object sender, EventArgs e)
        {
            seg--;
            if (seg == 00 && min != 00)
            {
                min--;
                seg = 59;
            }

            labelCronômetro.Text = min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');

            if (seg == 00  && min == 00)
            {
                timerCronômetro.Enabled = false;
                MessageBox.Show("Acabou o tempo!!");
            }
        }

        private void Jogar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();

            menu.Show();
        }
    }
}
