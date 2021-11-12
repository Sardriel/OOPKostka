using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKostka
{

    class Kostka
    {
        private Random random;
        private int pocetSten;
        
        public Kostka()
        {
            
            pocetSten = 6;
            random = new Random();
        }
        public int hod()
        {
            return random.Next(1, pocetSten + 1);
        }
       
    }
}
