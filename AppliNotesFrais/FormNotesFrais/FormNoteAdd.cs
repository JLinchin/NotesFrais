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
    public partial class FormNoteAdd : Form
    {
        private SceCommercial unSce;
        public FormNoteAdd(SceCommercial unSce)
        {
            this.unSce = unSce;
            InitializeComponent();
        }

        /// <summary>
        /// Charge les données requises au bon fonctionnement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormNoteAdd_Load(object sender, EventArgs e)
        {
            LoadVisiteur(unSce.LesVisiteurs);

            //Modification de la valeur par défaut des ComboBox
            CmbVisit.SelectedIndex = 0;
            CmbTypeNote.SelectedIndex = 0;
            CmbRegion.SelectedIndex = 0;
        }

        /// <summary>
        /// Adapte les données du formulaire au type de note de frais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbTypeNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            int typeNote = CmbTypeNote.SelectedIndex;

            switch (typeNote)
            {
                //Si la note de frais est un frais de nuitée
                case (0):
                    //Changement du contenu du label
                    LblParam.Text = "Montant de la nuitée :";

                    //Affichage des label et ComboBox relatifs à la région
                    LblRegion.Visible = true;
                    CmbRegion.Visible = true;

                    break;

                case (1):
                    //Changement du contenu du label
                    LblParam.Text = "Montant du repas :";

                    //Dissimulation des label et ComboBox relatifs à la région
                    LblRegion.Visible = false;
                    CmbRegion.Visible = false;

                    break;

                case (2):
                    //Changement du contenu du label
                    LblParam.Text = "Nombre de kilomètres :";

                    //Dissimulation des label et ComboBox relatifs à la région
                    LblRegion.Visible = false;
                    CmbRegion.Visible = false;

                    break;
            }
        }

        /// <summary>
        /// Charge les visiteurs dans une ListBox
        /// </summary>
        /// <param name="lesVisiteurs">La liste des visiteurs</param>
        private void LoadVisiteur(List<Visiteur> lesVisiteurs)
        {
            foreach (Visiteur unVisit in lesVisiteurs)
                CmbVisit.Items.Add($"{unVisit.Nom} {unVisit.Prenom}");
        }

        /// <summary>
        /// Enregistre une nouvelle note de frais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVal_Click(object sender, EventArgs e)
        {
            //Récupération de la date et du type de note
            DateTime laDate = CalDate.SelectionRange.Start;
            int typeNote = CmbTypeNote.SelectedIndex;

            switch (typeNote)
            {
                //Si la note est une note de frais de nuitée
                case (0):
                    double res = 0;

                    //Est-ce que le montant est en double ?
                    if (double.TryParse(TxtParam.Text, out res))
                    {
                        double mtt = double.Parse(TxtParam.Text);
                        int num = int.Parse(CmbRegion.Text);

                        //Ajout d'une note de frais de nuitée
                        NoteFrais uneNote = new FraisNuitee(laDate, unSce.LesVisiteurs[CmbVisit.SelectedIndex], mtt, num);
                    }
                    else
                        MessageBox.Show("Erreur, montant invalide");

                    break;

                //Si la note est une note de frais de repas
                case (1):
                    res = 0;

                    //Est-ce que le montant est en double ?
                    if (double.TryParse(TxtParam.Text, out res))
                    {
                        double mtt = double.Parse(TxtParam.Text);

                        //Ajout d'une note de frais de repas
                        NoteFrais uneNote = new FraisRepasMidi(laDate, unSce.LesVisiteurs[CmbVisit.SelectedIndex], mtt);
                    }
                    else
                        MessageBox.Show("Erreur, montant invalide");

                    break;

                //Si la note est une note de frais de déplacement
                case (2):
                    int resKm = 0;

                    //Est-ce que le montant est en double ?
                    if (int.TryParse(TxtParam.Text, out resKm))
                    {
                        int nbKm = int.Parse(TxtParam.Text);

                        //Ajout d'une note de frais de déplacement
                        NoteFrais uneNote = new FraisTransport(laDate, unSce.LesVisiteurs[CmbVisit.SelectedIndex], nbKm);
                    }
                    else
                        MessageBox.Show("Erreur, nombre de kilomètres invalides");

                    break;
            }

            //Mise à jour du SceCommercial & retour à la liste des visiteurs
            ((PagePrincipale)MdiParent).UnSce = unSce;
            ((PagePrincipale)MdiParent).OpenList();
        }
    }
}
