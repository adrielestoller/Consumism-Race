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
        int turno = 0;
        bool movExtra = false;
        PictureBox selecionado = null;

        List<PictureBox> pecabq = new List<PictureBox>();
        List<PictureBox> pecamc = new List<PictureBox>();

        public Jogo()
        {
            InitializeComponent();
        }

        private void carregarLista()
        {
            pecabq.Add(pecabq1);
            pecabq.Add(pecabq2);
            pecabq.Add(pecabq3);
            pecabq.Add(pecabq4);
            pecabq.Add(pecabq5);
            pecabq.Add(pecabq6);
            pecabq.Add(pecabq7);
            pecabq.Add(pecabq8);
            pecabq.Add(pecabq9);
            pecabq.Add(pecabq10);
            pecabq.Add(pecabq11);
            pecabq.Add(pecabq12);
            pecabq.Add(pecabq13);
            pecabq.Add(pecabq14);
            pecabq.Add(pecabq15);
            pecabq.Add(pecabq16);
            pecabq.Add(pecabq17);
            pecabq.Add(pecabq18);

            pecamc.Add(pecamc1);
            pecamc.Add(pecamc2);
            pecamc.Add(pecamc3);
            pecamc.Add(pecamc4);
            pecamc.Add(pecamc5);
            pecamc.Add(pecamc6);
            pecamc.Add(pecamc7);
            pecamc.Add(pecamc8);
            pecamc.Add(pecamc9);
            pecamc.Add(pecamc10);
            pecamc.Add(pecamc11);
            pecamc.Add(pecamc12);
            pecamc.Add(pecamc13);
            pecamc.Add(pecamc14);
            pecamc.Add(pecamc15);
            pecamc.Add(pecamc16);
            pecamc.Add(pecamc17);
            pecamc.Add(pecamc18);
        }

        public void selecao(object objeto)
        {
            try {selecionado.BackColor = Color.Transparent; }
            catch { }
            PictureBox ficha = (PictureBox)objeto;
            selecionado = ficha;
            selecionado.BackColor = Color.Lime;
        }

        private void tabluleiro_MouseClick(object sender, MouseEventArgs e)
        {
            movimento((PictureBox)sender);
        }

        private void movimento(PictureBox tabuleiro)
        {
            if (selecionado != null)
            {

                string color = selecionado.Name.ToString().Substring(0, 4);

                if (validacao(selecionado, tabuleiro, color))
                {
                    Point anterior = selecionado.Location;
                    selecionado.Location = tabuleiro.Location;
                    int avance = anterior.Y - tabuleiro.Location.Y;

                    if (true)
                    {
                        turno++;
                        selecionado.BackColor = Color.Transparent;
                        selecionado = null;
                        movExtra = false;
                    }
                    else 
                    {
                        movExtra = true;
                    }
                }
            }
        }

        private bool MovExtra(string color)
        {
            List<PictureBox> bandoContrario = color == "pecabq" ? pecamc : pecabq;
            List<Point> posicoes = new List<Point>();
            int sigPosicao = color == "pecabq" ? -100 : 100;

            posicoes.Add(new Point(selecionado.Location.X + 100, selecionado.Location.Y + sigPosicao));
            posicoes.Add(new Point(selecionado.Location.X - 100, selecionado.Location.Y + sigPosicao));

            bool resultado = false;

            for (int i = 0; i < posicoes.Count; i++)
            {
                if (posicoes[i].X >= 50 && posicoes[i].X <= 400 && posicoes[i].Y >= 50 && posicoes[i].Y <= 400)
                {
                    if (!ocupado(posicoes[i], pecabq) && !ocupado(posicoes[i], pecamc))
                    {
                        Point pontoMedio = new Point(promedia(posicoes[i].X, selecionado.Location.X), promedia(posicoes[i].Y, selecionado.Location.Y));
                        
                        if (ocupado(pontoMedio, bandoContrario))
                        {
                            resultado = true;  
                        }
                    }
                }
            }

            return resultado;
        }

        private bool ocupado(Point ponto, List<PictureBox> bando)
        {
            for (int i = 0; i < bando.Count; i++)
            {
                if (ponto == bando[i].Location)
                {
                    return true;
                }
            }
            return false;
        }

        private int promedia(int n1, int n2)
        {
            int resultado = n1 + n2;
            resultado /= 2;

            return Math.Abs(resultado);

        }

        private bool validacao(PictureBox origem, PictureBox destino, string color)
        {
            Point pontoOrigem = origem.Location;
            Point pontoDestino = destino.Location;

            int avance = pontoOrigem.Y - pontoDestino.Y;
            avance = color == "pecabq" ? avance : (avance * -1);

            if (avance == 50)
            {
                return true;
            }
            else if (avance == 100)
            {
                Point pontoMedio = new Point(promedia(pontoOrigem.X, pontoDestino.X), promedia(pontoOrigem.Y, pontoDestino.Y));
                
                List<PictureBox> bandoContrario = color == "pecabq" ? pecamc: pecabq;

                for (int i = 0; i < bandoContrario.Count; i++)
			    {
                    if (bandoContrario[i].Location == pontoMedio)
	                {
                        bandoContrario[i].Location = new Point(0, 0);
                        bandoContrario[i].Visible = false;
                        return true;
	                }			 
		    	}
            }
            return false;
        }

        private void pecabq_MouseClick(object sender, MouseEventArgs e)
        {
            selecao(sender);
        }

        private void pecamc_MouseClick(object sender, MouseEventArgs e)
        {
            selecao(sender);
        }
    }
}
