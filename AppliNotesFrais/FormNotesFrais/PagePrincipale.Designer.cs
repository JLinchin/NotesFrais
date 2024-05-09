namespace FormNotesFrais
{
    partial class PagePrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVisiteur = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConsult = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAddNote = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFichier,
            this.MnuVisiteur,
            this.MnuNotes});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(804, 24);
            this.MnuStrip.TabIndex = 1;
            this.MnuStrip.Text = "menuStrip1";
            // 
            // MnuFichier
            // 
            this.MnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuOpen,
            this.toolStripSeparator1,
            this.MnuSave,
            this.MnuQuit,
            this.toolStripSeparator2,
            this.MnuClose});
            this.MnuFichier.Name = "MnuFichier";
            this.MnuFichier.Size = new System.Drawing.Size(54, 20);
            this.MnuFichier.Text = "Fichier";
            // 
            // MnuOpen
            // 
            this.MnuOpen.Name = "MnuOpen";
            this.MnuOpen.Size = new System.Drawing.Size(180, 22);
            this.MnuOpen.Text = "Ouvrir";
            this.MnuOpen.Click += new System.EventHandler(this.MnuOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuSave
            // 
            this.MnuSave.Name = "MnuSave";
            this.MnuSave.Size = new System.Drawing.Size(180, 22);
            this.MnuSave.Text = "Enregistrer";
            this.MnuSave.Click += new System.EventHandler(this.MnuSave_Click);
            // 
            // MnuQuit
            // 
            this.MnuQuit.Name = "MnuQuit";
            this.MnuQuit.Size = new System.Drawing.Size(180, 22);
            this.MnuQuit.Text = "Quitter";
            this.MnuQuit.Click += new System.EventHandler(this.MnuQuit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuClose
            // 
            this.MnuClose.Name = "MnuClose";
            this.MnuClose.Size = new System.Drawing.Size(180, 22);
            this.MnuClose.Text = "Fermer";
            this.MnuClose.Click += new System.EventHandler(this.MnuClose_Click);
            // 
            // MnuVisiteur
            // 
            this.MnuVisiteur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuConsult,
            this.MnuAdd});
            this.MnuVisiteur.Name = "MnuVisiteur";
            this.MnuVisiteur.Size = new System.Drawing.Size(63, 20);
            this.MnuVisiteur.Text = "Visiteurs";
            // 
            // MnuConsult
            // 
            this.MnuConsult.Name = "MnuConsult";
            this.MnuConsult.Size = new System.Drawing.Size(125, 22);
            this.MnuConsult.Text = "Consulter";
            this.MnuConsult.Click += new System.EventHandler(this.MnuConsult_Click);
            // 
            // MnuAdd
            // 
            this.MnuAdd.Name = "MnuAdd";
            this.MnuAdd.Size = new System.Drawing.Size(125, 22);
            this.MnuAdd.Text = "Ajouter";
            this.MnuAdd.Click += new System.EventHandler(this.MnuAdd_Click);
            // 
            // MnuNotes
            // 
            this.MnuNotes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAddNote});
            this.MnuNotes.Name = "MnuNotes";
            this.MnuNotes.Size = new System.Drawing.Size(91, 20);
            this.MnuNotes.Text = "Notes de frais";
            // 
            // MnuAddNote
            // 
            this.MnuAddNote.Name = "MnuAddNote";
            this.MnuAddNote.Size = new System.Drawing.Size(113, 22);
            this.MnuAddNote.Text = "Ajouter";
            this.MnuAddNote.Click += new System.EventHandler(this.MnuAddNote_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 478);
            this.Controls.Add(this.MnuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PagePrincipale";
            this.Text = "Gestion des notes de frais";
            this.Load += new System.EventHandler(this.PagePrincipale_Load);
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuFichier;
        private System.Windows.Forms.ToolStripMenuItem MnuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MnuSave;
        private System.Windows.Forms.ToolStripMenuItem MnuQuit;
        private System.Windows.Forms.ToolStripMenuItem MnuNotes;
        private System.Windows.Forms.ToolStripMenuItem MnuAddNote;
        private System.Windows.Forms.ToolStripMenuItem MnuVisiteur;
        private System.Windows.Forms.ToolStripMenuItem MnuConsult;
        private System.Windows.Forms.ToolStripMenuItem MnuAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MnuClose;
    }
}

