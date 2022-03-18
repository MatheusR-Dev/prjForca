using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjJogoForca
{
    class Forca
    {
        
        // propriedades da classe
        private List<string> Palavras;
        private int Pos;
        public Forca(List<string> Palavras)
        {
            this.Palavras = Palavras;
            this.Pos = 0;
        }
        public void Sortear()
        {
            Random sorteio = new Random();
            Pos = sorteio.Next(Palavras.Count());
               
        }
    public string DevolvePalavra()
        {

            return Palavras[Pos];   
        }


    }
}
