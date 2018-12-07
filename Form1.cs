using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Joguinho
{
    public partial class Game : Form
    {
        List<string> sequenciaCores = new List<string>();
        List<string> sequenciaJogador = new List<string>();
        int listaIndex, pontos;
        const float brilho = 0.7f;
        string corAtual;
        string[] cores = { "Azul", "Verde", "Amarelo", "Vermelho", };
        bool podeJogar;
        Random rdn = new Random();
        SoundPlayer[] audios = {new SoundPlayer(Properties.Resources.beep_03), new SoundPlayer(Properties.Resources.beep_06),
           new SoundPlayer(Properties.Resources.beep_08b), new SoundPlayer(Properties.Resources.beep_09) };
 


        public Game()
        {
            InitializeComponent();
        }

        private void MostrarCor(PictureBox pic, Color corClara, Color corEscura, SoundPlayer som)
        {
            pic.BackColor = corClara; som.Play(); Application.DoEvents(); Thread.Sleep(850); pic.BackColor = corEscura;

        }

        private void ProcurarCor(String tagPic)
        {
            foreach (var corEncontrada in Controls.OfType<PictureBox>())
            {
                if (corEncontrada.Tag.ToString() == tagPic)
                {
                    string tag = corEncontrada.Tag.ToString();

                    Color piscar = ControlPaint.Light(corEncontrada.BackColor, brilho);
                    SoundPlayer som = tag == "Azul" ? audios[0] : (tag == "Verde" ? audios[1] : (tag == "Amarelo" ? audios[2] : audios[3]));
                    MostrarCor(corEncontrada, piscar, corEncontrada.BackColor, som);
                }
            }
        }

        private void SortearCor()
        {
            corAtual = cores[rdn.Next(0, cores.Length)];
            sequenciaCores.Add(corAtual);

            foreach (var cor in sequenciaCores)
            {
                Application.DoEvents(); Thread.Sleep(250);
                ProcurarCor(cor);
            }

            podeJogar = true;
        }

        private void Clique(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            if (podeJogar)
            {
                podeJogar = false;
                corAtual = pb.Tag.ToString();
                sequenciaJogador.Add(corAtual);
                ProcurarCor(corAtual);

                if (sequenciaJogador[listaIndex] == sequenciaCores[listaIndex])
                {
                    pontos++; lblPontos.Text = "Pontos: " + pontos.ToString();
                    listaIndex++; Checar();
                }

                else
                {
                    MessageBox.Show("Você perdeu ! Volte ao menu e inicie um Novo Jogo");
                }
            }
        }

        private void Checar()
        {
            if (listaIndex == sequenciaCores.Count)
            {
                listaIndex = 0; sequenciaJogador.Clear();
                SortearCor();
            }
            else
            {
                podeJogar = true;
            }
        }

        private void Opcoes(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;

            switch (menu.Text)
            {
                case "Novo Jogo":
                    pontos = 0; lblPontos.Text = "Pontos:"; sequenciaJogador.Clear(); sequenciaCores.Clear();
                    podeJogar = false; listaIndex = 0; SortearCor(); break;

                case "Sobre":
                    string info = "Jogo Select Colors \n Desenvolvimento by SITI \n 2018";
                    MessageBox.Show(info); break;

                case "Sair": Application.Exit(); break;
            }
        }
    }
}    


   
        
           
       






            
