namespace FilmsWork
{
    partial class fAdd
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
            this.lTytle = new System.Windows.Forms.Label();
            this.lYear = new System.Windows.Forms.Label();
            this.lRuntime = new System.Windows.Forms.Label();
            this.lGenre = new System.Windows.Forms.Label();
            this.lLanguage = new System.Windows.Forms.Label();
            this.lDirector = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.rTBDescription = new System.Windows.Forms.RichTextBox();
            this.tBDirector = new System.Windows.Forms.TextBox();
            this.cBLanguage = new System.Windows.Forms.ComboBox();
            this.cBGenre = new System.Windows.Forms.ComboBox();
            this.mtBYear = new System.Windows.Forms.MaskedTextBox();
            this.mtBRuntime = new System.Windows.Forms.MaskedTextBox();
            this.lYearN = new System.Windows.Forms.Label();
            this.tBTitle = new System.Windows.Forms.TextBox();
            this.lMinuete = new System.Windows.Forms.Label();
            this.cBViewed = new System.Windows.Forms.CheckBox();
            this.bAddPic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTytle
            // 
            this.lTytle.AutoSize = true;
            this.lTytle.Location = new System.Drawing.Point(13, 18);
            this.lTytle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTytle.Name = "lTytle";
            this.lTytle.Size = new System.Drawing.Size(35, 17);
            this.lTytle.TabIndex = 0;
            this.lTytle.Text = "Title";
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Location = new System.Drawing.Point(13, 52);
            this.lYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(38, 17);
            this.lYear.TabIndex = 1;
            this.lYear.Text = "Year";
            // 
            // lRuntime
            // 
            this.lRuntime.AutoSize = true;
            this.lRuntime.Location = new System.Drawing.Point(13, 82);
            this.lRuntime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRuntime.Name = "lRuntime";
            this.lRuntime.Size = new System.Drawing.Size(60, 17);
            this.lRuntime.TabIndex = 2;
            this.lRuntime.Text = "Runtime";
            // 
            // lGenre
            // 
            this.lGenre.AutoSize = true;
            this.lGenre.Location = new System.Drawing.Point(13, 117);
            this.lGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGenre.Name = "lGenre";
            this.lGenre.Size = new System.Drawing.Size(48, 17);
            this.lGenre.TabIndex = 3;
            this.lGenre.Text = "Genre";
            // 
            // lLanguage
            // 
            this.lLanguage.AutoSize = true;
            this.lLanguage.Location = new System.Drawing.Point(13, 153);
            this.lLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLanguage.Name = "lLanguage";
            this.lLanguage.Size = new System.Drawing.Size(72, 17);
            this.lLanguage.TabIndex = 4;
            this.lLanguage.Text = "Language";
            // 
            // lDirector
            // 
            this.lDirector.AutoSize = true;
            this.lDirector.Location = new System.Drawing.Point(13, 191);
            this.lDirector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDirector.Name = "lDirector";
            this.lDirector.Size = new System.Drawing.Size(58, 17);
            this.lDirector.TabIndex = 5;
            this.lDirector.Text = "Director";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(13, 226);
            this.lDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(79, 17);
            this.lDescription.TabIndex = 7;
            this.lDescription.Text = "Description";
            // 
            // bOk
            // 
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Location = new System.Drawing.Point(24, 370);
            this.bOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(100, 28);
            this.bOk.TabIndex = 9;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(169, 370);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(100, 28);
            this.bCancel.TabIndex = 10;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // rTBDescription
            // 
            this.rTBDescription.Location = new System.Drawing.Point(103, 226);
            this.rTBDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rTBDescription.Name = "rTBDescription";
            this.rTBDescription.Size = new System.Drawing.Size(177, 99);
            this.rTBDescription.TabIndex = 8;
            this.rTBDescription.Text = "";
            // 
            // tBDirector
            // 
            this.tBDirector.Location = new System.Drawing.Point(103, 191);
            this.tBDirector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBDirector.Name = "tBDirector";
            this.tBDirector.Size = new System.Drawing.Size(177, 22);
            this.tBDirector.TabIndex = 6;
            // 
            // cBLanguage
            // 
            this.cBLanguage.FormattingEnabled = true;
            this.cBLanguage.Items.AddRange(new object[] {
            "Russian",
            "English",
            "Azerbaijan"});
            this.cBLanguage.Location = new System.Drawing.Point(103, 153);
            this.cBLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBLanguage.Name = "cBLanguage";
            this.cBLanguage.Size = new System.Drawing.Size(177, 24);
            this.cBLanguage.TabIndex = 5;
            // 
            // cBGenre
            // 
            this.cBGenre.FormattingEnabled = true;
            this.cBGenre.Items.AddRange(new object[] {
            "Romcom",
            "Sci-fi",
            "Scary",
            "Horror",
            "Documentary",
            "Animated",
            "Action / thriller",
            "Drama",
            "Comedy",
            "Adventure"});
            this.cBGenre.Location = new System.Drawing.Point(103, 117);
            this.cBGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBGenre.Name = "cBGenre";
            this.cBGenre.Size = new System.Drawing.Size(177, 24);
            this.cBGenre.TabIndex = 4;
            // 
            // mtBYear
            // 
            this.mtBYear.Location = new System.Drawing.Point(103, 48);
            this.mtBYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtBYear.Mask = "0000";
            this.mtBYear.Name = "mtBYear";
            this.mtBYear.Size = new System.Drawing.Size(39, 22);
            this.mtBYear.TabIndex = 2;
            this.mtBYear.ValidatingType = typeof(System.DateTime);
            // 
            // mtBRuntime
            // 
            this.mtBRuntime.Location = new System.Drawing.Point(103, 82);
            this.mtBRuntime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtBRuntime.Mask = "000";
            this.mtBRuntime.Name = "mtBRuntime";
            this.mtBRuntime.Size = new System.Drawing.Size(31, 22);
            this.mtBRuntime.TabIndex = 3;
            this.mtBRuntime.ValidatingType = typeof(int);
            // 
            // lYearN
            // 
            this.lYearN.AutoSize = true;
            this.lYearN.Location = new System.Drawing.Point(151, 52);
            this.lYearN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lYearN.Name = "lYearN";
            this.lYearN.Size = new System.Drawing.Size(36, 17);
            this.lYearN.TabIndex = 18;
            this.lYearN.Text = "year";
            // 
            // tBTitle
            // 
            this.tBTitle.Location = new System.Drawing.Point(103, 15);
            this.tBTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBTitle.Name = "tBTitle";
            this.tBTitle.Size = new System.Drawing.Size(177, 22);
            this.tBTitle.TabIndex = 1;
            // 
            // lMinuete
            // 
            this.lMinuete.AutoSize = true;
            this.lMinuete.Location = new System.Drawing.Point(143, 86);
            this.lMinuete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMinuete.Name = "lMinuete";
            this.lMinuete.Size = new System.Drawing.Size(34, 17);
            this.lMinuete.TabIndex = 20;
            this.lMinuete.Text = "min.";
            // 
            // cBViewed
            // 
            this.cBViewed.AutoSize = true;
            this.cBViewed.Location = new System.Drawing.Point(147, 334);
            this.cBViewed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBViewed.Name = "cBViewed";
            this.cBViewed.Size = new System.Drawing.Size(75, 21);
            this.cBViewed.TabIndex = 9;
            this.cBViewed.Text = "Viewed";
            this.cBViewed.UseVisualStyleBackColor = true;
            // 
            // bAddPic
            // 
            this.bAddPic.Location = new System.Drawing.Point(16, 268);
            this.bAddPic.Name = "bAddPic";
            this.bAddPic.Size = new System.Drawing.Size(73, 23);
            this.bAddPic.TabIndex = 21;
            this.bAddPic.Text = "Add Pic";
            this.bAddPic.UseVisualStyleBackColor = true;
            this.bAddPic.Click += new System.EventHandler(this.bAddPic_Click);
            // 
            // fAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 418);
            this.ControlBox = false;
            this.Controls.Add(this.bAddPic);
            this.Controls.Add(this.cBViewed);
            this.Controls.Add(this.lMinuete);
            this.Controls.Add(this.tBTitle);
            this.Controls.Add(this.lYearN);
            this.Controls.Add(this.mtBRuntime);
            this.Controls.Add(this.mtBYear);
            this.Controls.Add(this.cBGenre);
            this.Controls.Add(this.cBLanguage);
            this.Controls.Add(this.tBDirector);
            this.Controls.Add(this.rTBDescription);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lDirector);
            this.Controls.Add(this.lLanguage);
            this.Controls.Add(this.lGenre);
            this.Controls.Add(this.lRuntime);
            this.Controls.Add(this.lYear);
            this.Controls.Add(this.lTytle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(313, 465);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(313, 465);
            this.Name = "fAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTytle;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Label lRuntime;
        private System.Windows.Forms.Label lGenre;
        private System.Windows.Forms.Label lLanguage;
        private System.Windows.Forms.Label lDirector;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.RichTextBox rTBDescription;
        private System.Windows.Forms.TextBox tBDirector;
        private System.Windows.Forms.ComboBox cBLanguage;
        private System.Windows.Forms.ComboBox cBGenre;
        private System.Windows.Forms.MaskedTextBox mtBYear;
        private System.Windows.Forms.MaskedTextBox mtBRuntime;
        private System.Windows.Forms.Label lYearN;
        private System.Windows.Forms.TextBox tBTitle;
        private System.Windows.Forms.Label lMinuete;
        private System.Windows.Forms.CheckBox cBViewed;
        private System.Windows.Forms.Button bAddPic;
    }
}