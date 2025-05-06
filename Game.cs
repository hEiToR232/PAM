using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Game
    {
        private int playerPoint;
        private int streak;

        public int PlayerPoint { get => playerPoint; set => playerPoint = value; }
        public int Streak { get => streak; set => streak = value; }

        public Boolean CheckWinner(int chosen, int drawn)
        {
            if (chosen == drawn)
            {
                PlayerPoint++;
                Streak++;
                return true;
            }
            else
            {
                Streak = 0;
                return false;
            }
                
        }
        
        }

}
