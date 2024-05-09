using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibNotesFrais
{
    [Serializable]
    public class FraisTransport : NoteFrais
    {
        private int nbKm;


        public FraisTransport(DateTime dateNF, Visiteur leVisiteur, int nbKm) : base(dateNF, leVisiteur)
        {
            NbKm = nbKm;
            base.SetMttARembourser();
        }

        public int NbKm { get => nbKm; set => nbKm = value; }

        public override double CalculMttARembourser()
        {
            double mtt = 0;

            int puiss = GetLeVisiteur().PuissanceVeh;
            if (puiss > 10)
                mtt = 0.3 * NbKm;
            else
            { 
                if (puiss >= 5)
                    mtt = 0.2 * nbKm;
                else
                    mtt = 0.1 * nbKm;
            }

            return mtt;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nNombre kilomètres : {NbKm}";
        }
    }
}
