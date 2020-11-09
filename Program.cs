using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
			Poste p1 = new Poste(1, 1, 1, new Dictionary());
			Poste p2 = new Poste(2, 2, 1, new Dictionary());
			Poste p5 = new Poste(5, 1, 3, new Dictionary());
			Poste p3 = new Poste(3, 1, 2, new Dictionary());

			p3.getLesPostesVisibles().Add(1, p1);
			p3.getLesPostesVisibles().Add(5, p5);

			Poste p4 = new Poste(4, 2, 2, new Dictionary());
			p4.getLesPostesVisibles().Add(2, p2);
			p4.getLesPostesVisibles().Add(3, p3);

			Poste p6 = new Poste(6, 2, 3, new Dictionary());
			p6.getLesPostesVisibles().Add(3, p3);
			p6.getLesPostesVisibles().Add(5, p5);

			Poste p7 = new Poste(7, 3, 3, new Dictionary());
			p7.getLesPostesVisibles().Add(4, p4);
			p7.getLesPostesVisibles().Add(6, p6);
			Dictionary<int, Poste> d = new Dictionary<int, Poste>();
			d.Add(1, p1); d.Add(2, p2); d.Add(3, p3); d.Add(4, p4);
			d.Add(5, p5); d.Add(6, p6); d.Add(7, p7);

			Salle s = new Salle("salle1", d);
			Poste p8 = new Poste(8, 4, 1 new Dictionary<int, Poste>());
			p8.getLesPostesVisibles().Add(4, p4);
			p8.getLesPostesVisibles().Add(2, p2);

		}
    }
}
