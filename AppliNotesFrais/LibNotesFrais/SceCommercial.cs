using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibNotesFrais
{
    [Serializable]
    public class SceCommercial
    {
        private List<Visiteur> lesVisiteurs;

        public SceCommercial()
        {
            lesVisiteurs = new List<Visiteur>();
        }

        public List<Visiteur> LesVisiteurs { get => lesVisiteurs; set => lesVisiteurs = value; }

        public void AjouterVisiteur(Visiteur unVisiteur) { LesVisiteurs.Add(unVisiteur); }

        public void AjouterNote(DateTime dateNF, Visiteur unVisiteur, int nbKm) { NoteFrais noteVoit = new FraisTransport(dateNF, unVisiteur, nbKm); }
        public void AjouterNote(DateTime dateNF, Visiteur unVisiteur, double facture) { NoteFrais noteResto = new FraisRepasMidi(dateNF, unVisiteur, facture); }
        public void AjouterNote(DateTime dateNF, Visiteur unVisiteur, double facture, int region) { NoteFrais noteNuit = new FraisNuitee(dateNF, unVisiteur, facture, region); }

        public int NbNotesFraisNonRemboursees()
        {
            int cpt = 0;

            foreach (Visiteur unVisiteur in LesVisiteurs)
                foreach (NoteFrais laNote in unVisiteur.MesNotesFrais)
                    if (!laNote.GetEstRembourse())
                        cpt++;

            return cpt;
        }

        public string CumulNoteFraisParAnneePourTousVisiteur(int annee)
        {
            int cpt = 0;
            double mttTotal = 0;
            string txt = "";
            foreach (Visiteur unVisiteur in LesVisiteurs)
            {
                txt += $"Pour visiteur : {unVisiteur.Nom} {unVisiteur.Prenom}\n\n";
                cpt += unVisiteur.NbNotesParVisiteur(annee);
                double mtt = unVisiteur.CumulNotesFraisParAnnee(annee);

                mttTotal += mtt;
                txt += $"\tNombre de notes de frais : {unVisiteur.NbNotesParVisiteur(annee)}\n\tAnnée {annee} - Total Notes de frais : {mtt} euros\n\n\n";
            }

            txt += $"Année {annee} - Nombre total de notes de frais : {cpt}\nAnnée {annee} - Cumul tous visiteurs : {mttTotal} euros";

            return txt;
        }
    }
}
