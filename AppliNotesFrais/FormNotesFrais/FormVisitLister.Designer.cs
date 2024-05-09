namespace FormNotesFrais
{
    partial class FormVisitLister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LstVisiteurs = new System.Windows.Forms.ListBox();
            this.LstNotes = new System.Windows.Forms.ListBox();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblCout = new System.Windows.Forms.Label();
            this.LblNbTot = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblParam = new System.Windows.Forms.Label();
            this.LblRegion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstVisiteurs
            // 
            this.LstVisiteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstVisiteurs.FormattingEnabled = true;
            this.LstVisiteurs.ItemHeight = 20;
            this.LstVisiteurs.Location = new System.Drawing.Point(36, 62);
            this.LstVisiteurs.Name = "LstVisiteurs";
            this.LstVisiteurs.Size = new System.Drawing.Size(264, 304);
            this.LstVisiteurs.TabIndex = 0;
            this.LstVisiteurs.SelectedIndexChanged += new System.EventHandler(this.LstVisiteurs_SelectedIndexChanged);
            // 
            // LstNotes
            // 
            this.LstNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstNotes.FormattingEnabled = true;
            this.LstNotes.ItemHeight = 20;
            this.LstNotes.Location = new System.Drawing.Point(444, 62);
            this.LstNotes.Name = "LstNotes";
            this.LstNotes.Size = new System.Drawing.Size(264, 124);
            this.LstNotes.TabIndex = 1;
            this.LstNotes.SelectedIndexChanged += new System.EventHandler(this.LstNotes_SelectedIndexChanged);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(441, 250);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(150, 18);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "Date : XX/YY/ZZZZ";
            this.LblDate.Visible = false;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.Location = new System.Drawing.Point(441, 214);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(116, 18);
            this.LblType.TabIndex = 3;
            this.LblType.Text = "Note de XXXX";
            this.LblType.Visible = false;
            // 
            // LblCout
            // 
            this.LblCout.AutoSize = true;
            this.LblCout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCout.Location = new System.Drawing.Point(441, 287);
            this.LblCout.Name = "LblCout";
            this.LblCout.Size = new System.Drawing.Size(95, 18);
            this.LblCout.TabIndex = 4;
            this.LblCout.Text = "Coût : XX €";
            this.LblCout.Visible = false;
            // 
            // LblNbTot
            // 
            this.LblNbTot.AutoSize = true;
            this.LblNbTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNbTot.Location = new System.Drawing.Point(440, 367);
            this.LblNbTot.Name = "LblNbTot";
            this.LblNbTot.Size = new System.Drawing.Size(294, 24);
            this.LblNbTot.TabIndex = 5;
            this.LblNbTot.Text = "Nombre de notes de frais : XX";
            this.LblNbTot.Visible = false;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(440, 402);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(162, 24);
            this.LblTotal.TabIndex = 6;
            this.LblTotal.Text = "Coût total : XX €";
            this.LblTotal.Visible = false;
            // 
            // LblParam
            // 
            this.LblParam.AutoSize = true;
            this.LblParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblParam.Location = new System.Drawing.Point(441, 324);
            this.LblParam.Name = "LblParam";
            this.LblParam.Size = new System.Drawing.Size(57, 18);
            this.LblParam.TabIndex = 7;
            this.LblParam.Text = "Param";
            this.LblParam.Visible = false;
            // 
            // LblRegion
            // 
            this.LblRegion.AutoSize = true;
            this.LblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegion.Location = new System.Drawing.Point(670, 262);
            this.LblRegion.Name = "LblRegion";
            this.LblRegion.Size = new System.Drawing.Size(87, 18);
            this.LblRegion.TabIndex = 8;
            this.LblRegion.Text = "Région : X";
            this.LblRegion.Visible = false;
            // 
            // FormVisitLister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblRegion);
            this.Controls.Add(this.LblParam);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblNbTot);
            this.Controls.Add(this.LblCout);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LstNotes);
            this.Controls.Add(this.LstVisiteurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVisitLister";
            this.Text = "FormFraisLister";
            this.Load += new System.EventHandler(this.FormVisitLister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstVisiteurs;
        private System.Windows.Forms.ListBox LstNotes;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblCout;
        private System.Windows.Forms.Label LblNbTot;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblParam;
        private System.Windows.Forms.Label LblRegion;
    }
}