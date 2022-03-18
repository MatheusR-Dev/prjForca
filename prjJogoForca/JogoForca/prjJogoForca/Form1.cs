using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjJogoForca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> lista = new List<string>(){
           "ABAJUR","ABRIDOR","BACIA","BALANCA","CABIDE","CADEADO","DADO","DARDO","ESCADA","ENXADA","FACA","FICHA","GAIOLA","GAITA","HARPA","HASTE","IMPRESSORA","ISCA","JALECO","JOIA","LAMINA","LAMPADA","MACHADO","MARTELO","NOTEBOOK","NAVALHA","OCULOS","OMBREIRA","PA","PANELA","QUADRICICLO","QUADRO","RADIO","RALADOR","SACO","SALEIRO","TABUA","TABULEIRO","URNA","UNIFORME","VARA","VARAL","WEBCAM","ZIPER"
       };
        Forca jogo;
        Label[] Letras;
        int Erro = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            jogo = new Forca(lista);
            jogo.Sortear();
            DesenharPalavra(jogo.DevolvePalavra());
        }
        
        private void DesenharPalavra(string p)
        {
            int qtd = p.Length;
            Letras = new Label[qtd];
            int cx = 10;
            int cy = 10;
            for (int i = 0; i < qtd; i++)
            {
                Letras[i] = new Label();
                Letras[i].Text = "?";
                Letras[i].AutoSize = false;
                Letras[i].Width = 30;
                Letras[i].Height = 30;
                Letras[i].BorderStyle = BorderStyle.FixedSingle;
                Letras[i].ForeColor = Color.Green;
                Letras[i].BackColor = Color.Red;
                Letras[i].TextAlign = ContentAlignment.MiddleCenter;
                if( i % 5 == 0 && i != 0 )
                {
                    cy += 35;
                    cx = 10;
                }
                Letras[i].Top = cy;
                Letras[i].Left = cx;
                cx += 35;
                pnPalavra.Controls.Add(Letras[i]);
                Letras[i].Show();
            }

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            DesenharLetra(txtLetra.Text);
            txtLetra.Focus();
            txtLetra.SelectAll();
        }
            

        private void DesenharLetra(string letra)
        {
            string p = jogo.DevolvePalavra();
            bool achei = false;
            for (int i = 0; i < p.Length; i++)
            {
                if(p.Substring(i,1).Equals(letra))
                {
                    Letras[i].Text = letra;
                    achei = true;
                }
            }
            if (achei == false)
            {
                Erro++;
                DesenharBoneco();
            }
        }

        private void DesenharBoneco()
        {
            string arquivo = Environment.CurrentDirectory +
                "\\imagens\\forca" + Erro + ".png";
            pbBoneco.Image = Image.FromFile(arquivo);
        }
    }

}
