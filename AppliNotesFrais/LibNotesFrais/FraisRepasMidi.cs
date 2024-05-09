using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibNotesFrais
{
    [Serializable]
    public class FraisRepasMidi : NoteFrais
    {
        private double mttFactureRepasMidi;

        public FraisRepasMidi(DateTime dateNF, Visiteur leVisiteur, double mttFactureRepasMidi) : base(dateNF, leVisiteur)
        {
            MttFactureRepasMidi = mttFactureRepasMidi;
            base.SetMttARembourser();
        }

        public double MttFactureRepasMidi { get => mttFactureRepasMidi; set => mttFactureRepasMidi = value; }

        public override double CalculMttARembourser()
        {
            double mtt = 0;
            char categ = GetLeVisiteur().CategProf;

            switch (categ)
            {
                case 'A':
                    mtt = 25;
                    break;

                case 'B':
                    mtt = 22;
                    break;

                case 'C':
                    mtt = 20;
                    break;
            }

            if (mtt > MttFactureRepasMidi)
                mtt = MttFactureRepasMidi;

            return mtt;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMontant facturé repas midi : {MttFactureRepasMidi}";
        }
    }
}
