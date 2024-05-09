using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibNotesFrais
{
    [Serializable]
    public class Visiteur
    {
        private char categProf;
        private string nom;
        private string prenom;
        private int puissanceVeh;
        private List<NoteFrais> mesNotesFrais;

        public Visiteur(string nom, string prenom, char categProf, int puissanceVeh)
        {
            CategProf = categProf;
            Nom = nom;
            Prenom = prenom;
            PuissanceVeh = puissanceVeh;
            MesNotesFrais = new List<NoteFrais>();
        }

        public char CategProf { get => categProf; set => categProf = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int PuissanceVeh { get => puissanceVeh; set => puissanceVeh = value; }
        public List<NoteFrais> MesNotesFrais { get => mesNotesFrais; set => mesNotesFrais = value; }

        public void AjouterNoteFrais(NoteFrais uneNoteFrais) { MesNotesFrais.Add(uneNoteFrais); }

        public int NbNotesParVisiteur(int annee) 
        {
            int cpt = 0;

            foreach (NoteFrais uneNoteFrais in MesNotesFrais)
                if (uneNoteFrais.DateNF.Year == annee)
                    cpt++;

            return cpt;
        }

        public double CumulNotesFraisParAnnee(int annee)
        {
            double mtt = 0;
            foreach (NoteFrais laNote in MesNotesFrais)
            {
                if (laNote.DateNF.Year == annee)
                    mtt += laNote.MttARembourser;
            }

            return mtt;
        }

        public override string ToString()
        {
            string txt = $"Nom/prénom : {Nom} {Prenom}\n";
            txt += $"Catégorie professionnelle : {CategProf}\n";
            txt += $"Puissance véhicule : {PuissanceVeh}\n";

            return txt;
        }
    }
}
