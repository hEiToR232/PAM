using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Roll
    {
        private int nSorteado = 1;
        private int somaLadosOpostos = 0;
        private string image = "";
        
        public int Nsorteado { get => nSorteado; set => nSorteado = value;}
        public int SomaLadosOpostos { get => somaLadosOpostos; set => somaLadosOpostos = value; }
        public string Image { get => image; set => image = value; }

        public int DiceRoller()
        {
            Random sortear = new Random();
            switch (sortear.Next(1,7))
            {
                case 1:
                    Nsorteado = 1;
                    SomaLadosOpostos += 6;
                    Image = "dice1.png";
                    break;
                case 2:
                    Nsorteado = 2;
                    SomaLadosOpostos += 5;
                    Image = "dice2.png";
                    break;
                case 3:
                    Nsorteado = 3;
                    SomaLadosOpostos += 4;
                    Image = "dice3.png";
                    break;
                case 4:
                    Nsorteado = 4;
                    SomaLadosOpostos += 3;
                    Image = "dice4.png";
                    break;
                case 5:
                    Nsorteado = 5;
                    SomaLadosOpostos += 2;
                    Image = "dice5.png";
                    break;
                case 6:
                    Nsorteado = 6;
                    SomaLadosOpostos += 1;
                    Image = "dice6.png";
                    break;
            }
            return Nsorteado;
        }
    }
}
