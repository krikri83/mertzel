using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app
{
    class Poste
    {
        private int numPoste;
        private int numTravee;
        private int numRangee;
        private Dictionary<int, Poste> lesPostesVisibles;
        public Poste(int numPoste, int numTravee, int numRangee,
             Dictionary<int, Poste> desPostesVisibles)
        {
            this.numPoste = numPoste;
            this.numRangee = numRangee;
            this.numTravee = numTravee;
            this.lesPostesVisibles = desPostesVisibles;
        }
        public int getNumero() { return this.numPoste; }
        public  Dictionary<int, Poste> getLesPostesVisibles()
        { return this.lesPostesVisibles;}
        

    }
}
