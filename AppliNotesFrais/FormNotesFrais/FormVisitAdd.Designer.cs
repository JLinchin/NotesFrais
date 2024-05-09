namespace FormNotesFrais
{
    partial class FormVisitAdd
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
            this.LblNom = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.LblCat = new System.Windows.Forms.Label();
            this.lblPuis = new System.Windows.Forms.Label();
            this.TxtPren = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtPuis = new System.Windows.Forms.TextBox();
            this.CmbBoxCat = new System.Windows.Forms.ComboBox();
            this.BtnVal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNom.Location = new System.Drawing.Point(61, 132);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(55, 20);
            this.LblNom.TabIndex = 0;
            this.LblNom.Text = "Nom :";
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrenom.Location = new System.Drawing.Point(61, 202);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(80, 20);
            this.LblPrenom.TabIndex = 1;
            this.LblPrenom.Text = "Prénom :";
            // 
            // LblCat
            // 
            this.LblCat.AutoSize = true;
            this.LblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCat.Location = new System.Drawing.Point(386, 132);
            this.LblCat.Name = "LblCat";
            this.LblCat.Size = new System.Drawing.Size(224, 20);
            this.LblCat.TabIndex = 2;
            this.LblCat.Text = "Catégorie professionnelle :";
            // 
            // lblPuis
            // 
            this.lblPuis.AutoSize = true;
            this.lblPuis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuis.Location = new System.Drawing.Point(386, 202);
            this.lblPuis.Name = "lblPuis";
            this.lblPuis.Size = new System.Drawing.Size(196, 20);
            this.lblPuis.TabIndex = 3;
            this.lblPuis.Text = "Puissance du véhicule :";
            // 
            // TxtPren
            // 
            this.TxtPren.Location = new System.Drawing.Point(147, 202);
            this.TxtPren.Name = "TxtPren";
            this.TxtPren.Size = new System.Drawing.Size(143, 20);
            this.TxtPren.TabIndex = 4;
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(147, 132);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(143, 20);
            this.TxtNom.TabIndex = 5;
            // 
            // TxtPuis
            // 
            this.TxtPuis.Location = new System.Drawing.Point(613, 202);
            this.TxtPuis.Name = "TxtPuis";
            this.TxtPuis.Size = new System.Drawing.Size(143, 20);
            this.TxtPuis.TabIndex = 6;
            // 
            // CmbBoxCat
            // 
            this.CmbBoxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxCat.FormattingEnabled = true;
            this.CmbBoxCat.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.CmbBoxCat.Location = new System.Drawing.Point(613, 131);
            this.CmbBoxCat.Name = "CmbBoxCat";
            this.CmbBoxCat.Size = new System.Drawing.Size(143, 21);
            this.CmbBoxCat.TabIndex = 7;
            // 
            // BtnVal
            // 
            this.BtnVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVal.Location = new System.Drawing.Point(337, 295);
            this.BtnVal.Name = "BtnVal";
            this.BtnVal.Size = new System.Drawing.Size(121, 53);
            this.BtnVal.TabIndex = 8;
            this.BtnVal.Text = "Valider";
            this.BtnVal.UseVisualStyleBackColor = true;
            this.BtnVal.Click += new System.EventHandler(this.BtnVal_Click);
            // 
            // FormVisitAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVal);
            this.Controls.Add(this.CmbBoxCat);
            this.Controls.Add(this.TxtPuis);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.TxtPren);
            this.Controls.Add(this.lblPuis);
            this.Controls.Add(this.LblCat);
            this.Controls.Add(this.LblPrenom);
            this.Controls.Add(this.LblNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVisitAdd";
            this.Text = "FormVisitAdd";
            this.Load += new System.EventHandler(this.FormVisitAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblPrenom;
        private System.Windows.Forms.Label LblCat;
        private System.Windows.Forms.Label lblPuis;
        private System.Windows.Forms.TextBox TxtPren;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtPuis;
        private System.Windows.Forms.ComboBox CmbBoxCat;
        private System.Windows.Forms.Button BtnVal;
    }
}