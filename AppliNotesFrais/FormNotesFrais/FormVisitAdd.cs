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
    public partial class FormVisitAdd : Form
    {
        private SceCommercial unSce;
        public FormVisitAdd(SceCommercial unSce)
        {
            this.unSce = unSce;
            InitializeComponent();
        }

        /// <summary>
        /// Charge les données requises au bon fonctionnement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVisitAdd_Load(object sender, EventArgs e)
        {
            CmbBoxCat.SelectedIndex = 0;
        }

        /// <summary>
        /// Enregistre un nouveau visiteur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVal_Click(object sender, EventArgs e)
        {
            //Si un des champs à remplir est vide
            if (TxtNom.Text == "" || TxtPren.Text == "" || TxtPuis.Text == "")
                //Affichage d'un message d'erreur
                MessageBox.Show("Au moins un des champs est vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Si la puissance du véhicule n'est pas un int
                int res = 0;
                if (!int.TryParse(TxtPuis.Text, out res))
                    //Affichage d'un message d'erreur
                    MessageBox.Show("La puissance du véhicule saisie est incorrecte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string nom = TxtNom.Text;
                    string pren = TxtPren.Text;
                    char catPro = CmbBoxCat.Text.ToCharArray()[0];
                    int puis = int.Parse(TxtPuis.Text);

                    //Ajout d'un nouveau Visiteur
                    Visiteur unVisiteur = new Visiteur(nom, pren, catPro, puis);
                    unSce.AjouterVisiteur(unVisiteur);

                    //Mise à jour du SceCommercial et retour à la liste des visiteurs
                    ((PagePrincipale)MdiParent).UnSce = unSce;
                    ((PagePrincipale)MdiParent).OpenList();
                }
            }
        }
    }
}
