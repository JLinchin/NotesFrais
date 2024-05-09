namespace FormNotesFrais
{
    partial class FormNoteAdd
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
            this.CmbVisit = new System.Windows.Forms.ComboBox();
            this.LblVisiteur = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTypeNote = new System.Windows.Forms.ComboBox();
            this.LblParam = new System.Windows.Forms.Label();
            this.CmbRegion = new System.Windows.Forms.ComboBox();
            this.TxtParam = new System.Windows.Forms.TextBox();
            this.BtnVal = new System.Windows.Forms.Button();
            this.CalDate = new System.Windows.Forms.MonthCalendar();
            this.LblRegion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbVisit
            // 
            this.CmbVisit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbVisit.FormattingEnabled = true;
            this.CmbVisit.Location = new System.Drawing.Point(221, 83);
            this.CmbVisit.Name = "CmbVisit";
            this.CmbVisit.Size = new System.Drawing.Size(121, 21);
            this.CmbVisit.TabIndex = 0;
            // 
            // LblVisiteur
            // 
            this.LblVisiteur.AutoSize = true;
            this.LblVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVisiteur.Location = new System.Drawing.Point(56, 83);
            this.LblVisiteur.Name = "LblVisiteur";
            this.LblVisiteur.Size = new System.Drawing.Size(159, 20);
            this.LblVisiteur.TabIndex = 1;
            this.LblVisiteur.Text = "Visiteur concerné :";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(56, 211);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(58, 20);
            this.LblDate.TabIndex = 3;
            this.LblDate.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Note de :";
            // 
            // CmbTypeNote
            // 
            this.CmbTypeNote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTypeNote.FormattingEnabled = true;
            this.CmbTypeNote.Items.AddRange(new object[] {
            "Frais de nuitée",
            "Frais de repas à midi",
            "Frais de transport"});
            this.CmbTypeNote.Location = new System.Drawing.Point(565, 82);
            this.CmbTypeNote.Name = "CmbTypeNote";
            this.CmbTypeNote.Size = new System.Drawing.Size(121, 21);
            this.CmbTypeNote.TabIndex = 4;
            this.CmbTypeNote.SelectedIndexChanged += new System.EventHandler(this.CmbTypeNote_SelectedIndexChanged);
            // 
            // LblParam
            // 
            this.LblParam.AutoSize = true;
            this.LblParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblParam.Location = new System.Drawing.Point(424, 224);
            this.LblParam.Name = "LblParam";
            this.LblParam.Size = new System.Drawing.Size(90, 20);
            this.LblParam.TabIndex = 7;
            this.LblParam.Text = "Param_1 :";
            // 
            // CmbRegion
            // 
            this.CmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRegion.FormattingEnabled = true;
            this.CmbRegion.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CmbRegion.Location = new System.Drawing.Point(647, 283);
            this.CmbRegion.Name = "CmbRegion";
            this.CmbRegion.Size = new System.Drawing.Size(121, 21);
            this.CmbRegion.TabIndex = 8;
            // 
            // TxtParam
            // 
            this.TxtParam.Location = new System.Drawing.Point(647, 224);
            this.TxtParam.Name = "TxtParam";
            this.TxtParam.Size = new System.Drawing.Size(121, 20);
            this.TxtParam.TabIndex = 9;
            // 
            // BtnVal
            // 
            this.BtnVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVal.Location = new System.Drawing.Point(347, 348);
            this.BtnVal.Name = "BtnVal";
            this.BtnVal.Size = new System.Drawing.Size(121, 53);
            this.BtnVal.TabIndex = 10;
            this.BtnVal.Text = "Valider";
            this.BtnVal.UseVisualStyleBackColor = true;
            this.BtnVal.Click += new System.EventHandler(this.BtnVal_Click);
            // 
            // CalDate
            // 
            this.CalDate.Location = new System.Drawing.Point(126, 155);
            this.CalDate.MaxSelectionCount = 1;
            this.CalDate.Name = "CalDate";
            this.CalDate.TabIndex = 2;
            // 
            // LblRegion
            // 
            this.LblRegion.AutoSize = true;
            this.LblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegion.Location = new System.Drawing.Point(424, 284);
            this.LblRegion.Name = "LblRegion";
            this.LblRegion.Size = new System.Drawing.Size(76, 20);
            this.LblRegion.TabIndex = 11;
            this.LblRegion.Text = "Région :";
            // 
            // FormNoteAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblRegion);
            this.Controls.Add(this.BtnVal);
            this.Controls.Add(this.TxtParam);
            this.Controls.Add(this.CmbRegion);
            this.Controls.Add(this.LblParam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbTypeNote);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.CalDate);
            this.Controls.Add(this.LblVisiteur);
            this.Controls.Add(this.CmbVisit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNoteAdd";
            this.Text = "FormNoteAdd";
            this.Load += new System.EventHandler(this.FormNoteAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbVisit;
        private System.Windows.Forms.Label LblVisiteur;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTypeNote;
        private System.Windows.Forms.Label LblParam;
        private System.Windows.Forms.ComboBox CmbRegion;
        private System.Windows.Forms.TextBox TxtParam;
        private System.Windows.Forms.Button BtnVal;
        private System.Windows.Forms.MonthCalendar CalDate;
        private System.Windows.Forms.Label LblRegion;
    }
}