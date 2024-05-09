using LibNotesFrais;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormNotesFrais
{
    public partial class FormVisitLister : Form
    {
        private SceCommercial unSce;
        public FormVisitLister(SceCommercial unSce)
        {
            this.unSce = unSce;
            InitializeComponent();
        }

        /// <summary>
        /// Charge les données nécessaires au fonctionnement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVisitLister_Load(object sender, EventArgs e)
        {
            ChargerVisiteurs();

            if (LstVisiteurs.Items.Count != 0)
                LstVisiteurs.SelectedIndex = 0;
        }

        /// <summary>
        /// Adapte les données au visiteur sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstVisiteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstNotes.Items.Clear();
            Visiteur unVisiteur = unSce.LesVisiteurs[LstVisiteurs.SelectedIndex];
            foreach (NoteFrais uneNote in unVisiteur.MesNotesFrais)
            {
                LstNotes.Items.Add($"{uneNote.DateNF.ToString("d")} - {uneNote.MttARembourser} €");
            }

            //S'il y a un visiteur dans la ListBox
            if (LstNotes.Items.Count > 0)
            {
                //Le premier visiteur est sélectionné
                LstNotes.SelectedIndex = 0;

                //Change la visibilité des labels
                LblCout.Visible = true;
                LblDate.Visible = true;
                LblNbTot.Visible = true;
                LblTotal.Visible = true;
                LblType.Visible = true;
                LblParam.Visible = true;
                LblRegion.Visible = false;

                //Change les paramètres
                SetParamsNote(unVisiteur.MesNotesFrais[LstNotes.SelectedIndex]);
                SetParamsGlob(unVisiteur);
            }
            else
            {
                //Change la visibilité des labels
                LblCout.Visible = false;
                LblDate.Visible = false;
                LblNbTot.Visible = false;
                LblTotal.Visible = false;
                LblType.Visible = false;
                LblParam.Visible = false;
                LblRegion.Visible = false;
            }
        }

        /// <summary>
        /// Adapte les données à la note de frais sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visiteur unVisiteur = unSce.LesVisiteurs[LstVisiteurs.SelectedIndex];
            NoteFrais laNote = unVisiteur.MesNotesFrais[LstNotes.SelectedIndex];

            SetParamsNote(laNote);            
        }


        /// <summary>
        /// Charge les visiteurs dans une liste
        /// </summary>
        private void ChargerVisiteurs()
        {
            foreach (Visiteur unVisit in unSce.LesVisiteurs)
            {
                LstVisiteurs.Items.Add($"{unVisit.Nom} {unVisit.Prenom}");
            }
        }

        /// <summary>
        /// Modifie l'affichage relatif à une note de frais
        /// </summary>
        /// <param name="laNote">La note de frais</param>
        private void SetParamsNote(NoteFrais laNote)
        {
            //Si la note de frais est une note de nuitée
            if (laNote is FraisNuitee)
            {
                FraisNuitee fraisNuitee = (FraisNuitee)laNote;

                //Changement du contenu des labels
                LblType.Text = "Note de frais de nuitée";
                LblParam.Text = $"Montant de la nuitée : {fraisNuitee.MttFactureNuitee} €";
                LblRegion.Text = $"Région : {fraisNuitee.NumRegion}";

                //Affichage du label de la région
                LblRegion.Visible = true;
            }
            else
            {
                //Si la note de frais est une note de repas
                if (laNote is FraisRepasMidi)
                {
                    FraisRepasMidi fraisRepasMidi = (FraisRepasMidi)laNote;

                    //Changement du contenu des labels
                    LblType.Text = "Note de frais de repas de midi";
                    LblParam.Text = $"Montant du repas : {fraisRepasMidi.MttFactureRepasMidi} €";

                    //Suppression du label de la région
                    LblRegion.Visible = false;
                }
                //Si la note de frais est une note de voiturage
                else
                {
                    FraisTransport fraisRepasMidi = (FraisTransport)laNote;

                    LblType.Text = "Note de frais de transport";
                    LblParam.Text = $"Nombre de kilomètres parcourus : {fraisRepasMidi.NbKm} km";

                    //Suppression du label de la région
                    LblRegion.Visible = false;
                }
            }

            //Changement du contenu des labels
            LblDate.Text = $"Date : {laNote.DateNF.ToString("d")}";
            LblCout.Text = $"Coût : {laNote.MttARembourser} €";
        }

        /// <summary>
        /// Modifie l'affichage relatif à un visiteur
        /// </summary>
        /// <param name="unVisiteur">Le visiteur</param>
        private void SetParamsGlob(Visiteur unVisiteur)
        {
            //Nombre de notes de frais
            int nb = unVisiteur.MesNotesFrais.Count;
            double mtt = 0;

            //Calcule le montant total des notes de frais
            foreach (NoteFrais uneNote in unVisiteur.MesNotesFrais)
                mtt += uneNote.MttARembourser;

            LblNbTot.Text = $"Nombre de notes de frais : {nb}";
            LblTotal.Text = $"Coût total : {mtt} €";
        }
    }
}
