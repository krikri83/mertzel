using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app
{
    class Salle
    {
        private string nom;
        private Dictionary<int, Poste> lesPostes;

        public Salle(string nom, Dictionary<int, Poste> d)
        {
            this.nom = nom;
			this.lesPostes = d;
        }
        /// <summary>
        /// // ajoute un poste dans la salle et met à jour les postes qui voient ce nouveau poste
        /// </summary>
               public void ajouterPoste(Poste unPoste,Dictionary<int, Poste> desPostesQuiVoient)
        {
			this.lesPostes.Add(unPoste.getNumero(), unPoste);
			var lescles = desPostesQuiVoient.Keys;
			//foreach (var i in desPostesQuiVoient)
			//{
			//	desPostesQuiVoient.Add(unPoste.getNumero(), unPoste);
			//}
			foreach (var i in lescles)
			{
				this.lesPostes[i].getLesPostesVisibles().Add(unPoste.getNumero(), unPoste);
			}


		}
		/// <summary>
		/// retire un poste de la salle et met à jour les postes qui voient ce poste
		/// </summary>
		/// <param name="numPoste"></param>
		public void retirerPoste(Poste unPoste)
        {
			var lescles = this.lesPostes.Keys;	
			foreach (var i in lescles)
			{
				
				Poste p = this.lesPostes[i];
				if(this.visible(p, unPoste))
				{
					p.getLesPostesVisibles().Remove(unPoste.getNumero());
				}
			}
			this.lesPostes.Remove(unPoste.getNumero());
		}

		/// <summary>
		/// retourne vrai si le poste 1 est visible du poste 2 ou si le poste 2 est visible du poste 1
		/// </summary>
		public bool visible(Poste poste1, Poste poste2)
        {
			bool ok = false;
			if(poste1.getLesPostesVisibles().ContainsKey(poste2.getNumero()) || poste2.getLesPostesVisibles().ContainsKey(poste1.getNumero()))
			{
				ok = true;
			}
			return ok;
        }
    }
}
