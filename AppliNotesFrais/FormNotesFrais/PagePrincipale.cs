using LibNotesFrais;
using LibOutils;
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
    public partial class PagePrincipale : Form
    {
        private SceCommercial unSce;
        private string lienFile;

        public PagePrincipale()
        {
            UnSce = new SceCommercial();
            lienFile = "";
            InitializeComponent();
        }

        public SceCommercial UnSce { get => unSce; set => unSce = value; }

        /// <summary>
        /// Ouvre la liste des visiteurs
        /// </summary>
        public void OpenList()
        {
            FormVisitLister frmLister = new FormVisitLister(UnSce);
            StartChild(frmLister);
        }

        /// <summary>
        /// Ouvre un formulaire enfant du contenaire parent (ce formulaire)
        /// </summary>
        /// <param name="child">Le formulaire enfant</param>
        private void StartChild(Form child)
        {
            //Ferme tous les enfants du contenaire Mdi
            foreach (Form mdichild in MdiChildren)
                mdichild.Close();

            //Démarre le formulaire passé en paramètre
            child.MdiParent = this;
            child.Show();
            child.Location = new Point(0, 0);
        }

        /// <summary>
        /// Sauvegarde les données dans un fichier
        /// </summary>
        private void Sauvegarder()
        {
            Serialisation.Enregistrer(lienFile, UnSce);
        }



        private void PagePrincipale_Load(object sender, EventArgs e)
        {
            MnuVisiteur.Enabled = false;
            MnuNotes.Enabled = false;
            MnuSave.Enabled = false;
            MnuQuit.Enabled = false;
        }

        /// <summary>
        /// Affiche le formulaire permettant de consulter les visiteurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuConsult_Click(object sender, EventArgs e)
        {
            FormVisitLister frmLister = new FormVisitLister(UnSce);
            StartChild(frmLister);
        }

        /// <summary>
        /// Affiche le formulaire permettant d'ajouter un visiteur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuAdd_Click(object sender, EventArgs e)
        {
            FormVisitAdd frmAdd = new FormVisitAdd(UnSce);
            StartChild(frmAdd);
        }

        /// <summary>
        /// Affiche le formulaire permettant d'ajouter une note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuAddNote_Click(object sender, EventArgs e)
        {
            FormNoteAdd frmAdd = new FormNoteAdd(UnSce);
            StartChild(frmAdd);
        }

        /// <summary>
        /// Ouvre un fichier binaire contenant les données d'un SceCommercial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuOpen_Click(object sender, EventArgs e)
        {
            //S'il y a déjà un fichier d'ouvert
            if (lienFile != "")
            {
                //Demande si l'utilisateur veux sauvegarder avant de quitter
                DialogResult reponse = MessageBox.Show("Voulez-vous sauvegarder les données ?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (reponse)
                {
                    //Si oui
                    case DialogResult.Yes:
                        //Sauvegarde et fermeture des formulaires existants
                        Sauvegarder();
                        foreach (Form mdichild in MdiChildren)
                            mdichild.Close();

                        //Réinitialisation du lien du fichier
                        lienFile = "";

                        //Désactivation de boutons
                        MnuSave.Enabled = false;
                        MnuQuit.Enabled = false;
                        MnuVisiteur.Enabled = false;
                        MnuNotes.Enabled = false;

                        break;

                    //Si non
                    case DialogResult.No:
                        //Fermeture des formulaires existants
                        foreach (Form mdichild in MdiChildren)
                            mdichild.Close();

                        //Réinitialisation du lien du fichier
                        lienFile = "";

                        //Désactivation de boutons
                        MnuSave.Enabled = false;
                        MnuQuit.Enabled = false;
                        MnuVisiteur.Enabled = false;
                        MnuNotes.Enabled = false;

                        break;

                    //Si annuler
                    case DialogResult.Cancel:
                        //Quitte la méthode
                        return;
                }
            }

            try
            {
                // Paramétrage des propriétés de la boîte de dialogue
                openFileDialog1.FileName = "";
                openFileDialog1.InitialDirectory = "d:\\";
                openFileDialog1.Filter = "bin files (*.bin)|*.bin";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                // Ouverture et test du bouton cliqué. Si oui, récupérer le nom du fichier
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    lienFile = openFileDialog1.FileName;
                    UnSce = (SceCommercial)Serialisation.Charger(lienFile);

                    MnuVisiteur.Enabled = true;
                    MnuNotes.Enabled = true;
                    MnuSave.Enabled = true;
                    MnuQuit.Enabled = true;

                    OpenList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Questionnaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sauvegarde les données d'un SceCommercial dans un fichier binaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuSave_Click(object sender, EventArgs e)
        {
            Sauvegarder();
        }

        /// <summary>
        /// Ferme le fichier binaire contenant les données d'un SceCommercial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuQuit_Click(object sender, EventArgs e)
        {

            //Demande si l'utilisateur veux sauvegarder avant de quitter
            DialogResult reponse = MessageBox.Show("Voulez-vous sauvegarder les données ?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (reponse)
            {
                //Si oui
                case DialogResult.Yes:

                    //Sauvegarde et fermeture des formulaires existants
                    Sauvegarder();
                    foreach (Form mdichild in MdiChildren)
                        mdichild.Close();

                    //Réinitialisation du lien du fichier
                    lienFile = "";

                    //Désactivation de boutons
                    MnuSave.Enabled = false;
                    MnuQuit.Enabled = false;
                    MnuVisiteur.Enabled = false;
                    MnuNotes.Enabled = false;

                    break;

                //Si non
                case DialogResult.No:
                    //Fermeture des formulaires existants
                    foreach (Form mdichild in MdiChildren)
                        mdichild.Close();

                    //Réinitialisation du lien du fichier
                    lienFile = "";

                    //Désactivation de boutons
                    MnuSave.Enabled = false;
                    MnuQuit.Enabled = false;
                    MnuVisiteur.Enabled = false;
                    MnuNotes.Enabled = false;

                    break;
            }
        }

        /// <summary>
        /// Ferme l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
