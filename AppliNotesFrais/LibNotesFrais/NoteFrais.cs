using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibNotesFrais
{
    [Serializable]
    public class NoteFrais
    {
        private DateTime dateNF;
        private double mttARembourser;
        private bool estRembourse;
        private int numero;
        private Visiteur leVisiteur;

        public NoteFrais(DateTime dateNF, Visiteur leVisiteur)
        {
            DateNF = dateNF;
            this.estRembourse = false;
            LeVisiteur = leVisiteur;
            Numero = leVisiteur.MesNotesFrais.Count() + 1;
            leVisiteur.AjouterNoteFrais(this);
        }


        public Visiteur GetLeVisiteur() { return LeVisiteur; }
        public bool GetEstRembourse() { return estRembourse; }
        public double MttARembourser { get => mttARembourser; set => mttARembourser = value; }
        public DateTime DateNF { get => dateNF; set => dateNF = value; }
        public Visiteur LeVisiteur { get => leVisiteur; set => leVisiteur = value; }
        public int Numero { get => numero; set => numero = value; }

        public void SetEstRembourse() {  estRembourse = true; }

        public void SetMttARembourser() { MttARembourser = CalculMttARembourser(); }

        public virtual double CalculMttARembourser()
        {
            return 0;
        }

        public override string ToString()
        {
            string txt = $"Numéro note de frais : {Numero}\n";
            txt += $"Date : {DateNF.ToString("d")}\n";
            txt += $"Puissance fiscale  : {GetLeVisiteur().PuissanceVeh}\n";
            txt += $"Catégorie visiteur : { GetLeVisiteur().CategProf}\n\n";

            if (!estRembourse)
                txt += $"Montant à rembourser : {MttARembourser} euros - Non remboursé";
            else
                txt += $"Montant à rembourser : {MttARembourser} euros - Remboursé";

            return txt ;
        }
    }
}
