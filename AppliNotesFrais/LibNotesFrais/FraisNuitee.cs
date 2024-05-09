using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibNotesFrais
{
    [Serializable]
    public class FraisNuitee : NoteFrais
    {
        private double mttFactureNuitee;
        private int numRegion;

        public FraisNuitee(DateTime dateNF, Visiteur leVisiteur, double mttFactureNuitee, int numRegion) : base(dateNF, leVisiteur)
        {
            MttFactureNuitee = mttFactureNuitee;
            NumRegion = numRegion;
            base.SetMttARembourser();
        }

        public double MttFactureNuitee { get => mttFactureNuitee; set => mttFactureNuitee = value; }
        public int NumRegion { get => numRegion; set => numRegion = value; }

        public override double CalculMttARembourser()
        {
            double mtt = 0;
            char catPro = GetLeVisiteur().CategProf;

            switch (catPro)
            {
                case 'A':
                    mtt = 65;
                    break;

                case 'B':
                    mtt = 55;
                    break;

                case 'C':
                    mtt = 50;
                    break;
            }

            switch (NumRegion)
            {
                case 1:
                    mtt *= 0.9;
                    break;

                case 3:
                    mtt *= 1.15;
                    break;
            }

            if (mtt > MttFactureNuitee)
                mtt = MttFactureNuitee;

            return mtt;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nNuméro de réfion : {NumRegion}\nMontant facture nuitée : {MttFactureNuitee}";
        }
    }
}
