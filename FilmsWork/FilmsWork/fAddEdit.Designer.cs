namespace FilmsWork
{
    partial class fAddEdit
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
            this.tbPicPath = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.pbSearchResult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lTytle
            // 
            this.lTytle.AutoSize = true;
            this.lTytle.Location = new System.Drawing.Point(10, 186);
            this.lTytle.Name = "lTytle";
            this.lTytle.Size = new System.Drawing.Size(27, 13);
            this.lTytle.TabIndex = 0;
            this.lTytle.Text = "Title";
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Location = new System.Drawing.Point(10, 213);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(29, 13);
            this.lYear.TabIndex = 1;
            this.lYear.Text = "Year";
            // 
            // lRuntime
            // 
            this.lRuntime.AutoSize = true;
            this.lRuntime.Location = new System.Drawing.Point(10, 238);
            this.lRuntime.Name = "lRuntime";
            this.lRuntime.Size = new System.Drawing.Size(46, 13);
            this.lRuntime.TabIndex = 2;
            this.lRuntime.Text = "Runtime";
            // 
            // lGenre
            // 
            this.lGenre.AutoSize = true;
            this.lGenre.Location = new System.Drawing.Point(10, 266);
            this.lGenre.Name = "lGenre";
            this.lGenre.Size = new System.Drawing.Size(36, 13);
            this.lGenre.TabIndex = 3;
            this.lGenre.Text = "Genre";
            // 
            // lLanguage
            // 
            this.lLanguage.AutoSize = true;
            this.lLanguage.Location = new System.Drawing.Point(10, 295);
            this.lLanguage.Name = "lLanguage";
            this.lLanguage.Size = new System.Drawing.Size(55, 13);
            this.lLanguage.TabIndex = 4;
            this.lLanguage.Text = "Language";
            // 
            // lDirector
            // 
            this.lDirector.AutoSize = true;
            this.lDirector.Location = new System.Drawing.Point(10, 326);
            this.lDirector.Name = "lDirector";
            this.lDirector.Size = new System.Drawing.Size(44, 13);
            this.lDirector.TabIndex = 5;
            this.lDirector.Text = "Director";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(10, 355);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(60, 13);
            this.lDescription.TabIndex = 7;
            this.lDescription.Text = "Description";
            // 
            // bOk
            // 
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Location = new System.Drawing.Point(18, 494);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 12;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(127, 494);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 13;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // rTBDescription
            // 
            this.rTBDescription.Location = new System.Drawing.Point(77, 355);
            this.rTBDescription.Name = "rTBDescription";
            this.rTBDescription.Size = new System.Drawing.Size(134, 81);
            this.rTBDescription.TabIndex = 9;
            this.rTBDescription.Text = "";
            // 
            // tBDirector
            // 
            this.tBDirector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBDirector.Location = new System.Drawing.Point(77, 326);
            this.tBDirector.Name = "tBDirector";
            this.tBDirector.Size = new System.Drawing.Size(134, 20);
            this.tBDirector.TabIndex = 8;
            // 
            // cBLanguage
            // 
            this.cBLanguage.FormattingEnabled = true;
            this.cBLanguage.Items.AddRange(new object[] {
            "Russian",
            "English",
            "Azerbaijan"});
            this.cBLanguage.Location = new System.Drawing.Point(77, 295);
            this.cBLanguage.Name = "cBLanguage";
            this.cBLanguage.Size = new System.Drawing.Size(134, 21);
            this.cBLanguage.TabIndex = 7;
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
            this.cBGenre.Location = new System.Drawing.Point(77, 266);
            this.cBGenre.Name = "cBGenre";
            this.cBGenre.Size = new System.Drawing.Size(134, 21);
            this.cBGenre.TabIndex = 6;
            // 
            // mtBYear
            // 
            this.mtBYear.Location = new System.Drawing.Point(77, 210);
            this.mtBYear.Mask = "0000";
            this.mtBYear.Name = "mtBYear";
            this.mtBYear.Size = new System.Drawing.Size(30, 20);
            this.mtBYear.TabIndex = 4;
            this.mtBYear.ValidatingType = typeof(System.DateTime);
            // 
            // mtBRuntime
            // 
            this.mtBRuntime.Location = new System.Drawing.Point(77, 238);
            this.mtBRuntime.Mask = "000";
            this.mtBRuntime.Name = "mtBRuntime";
            this.mtBRuntime.Size = new System.Drawing.Size(24, 20);
            this.mtBRuntime.TabIndex = 5;
            this.mtBRuntime.ValidatingType = typeof(int);
            // 
            // lYearN
            // 
            this.lYearN.AutoSize = true;
            this.lYearN.Location = new System.Drawing.Point(113, 213);
            this.lYearN.Name = "lYearN";
            this.lYearN.Size = new System.Drawing.Size(27, 13);
            this.lYearN.TabIndex = 18;
            this.lYearN.Text = "year";
            // 
            // tBTitle
            // 
            this.tBTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBTitle.Location = new System.Drawing.Point(77, 183);
            this.tBTitle.Name = "tBTitle";
            this.tBTitle.Size = new System.Drawing.Size(134, 20);
            this.tBTitle.TabIndex = 3;
            // 
            // lMinuete
            // 
            this.lMinuete.AutoSize = true;
            this.lMinuete.Location = new System.Drawing.Point(107, 241);
            this.lMinuete.Name = "lMinuete";
            this.lMinuete.Size = new System.Drawing.Size(26, 13);
            this.lMinuete.TabIndex = 20;
            this.lMinuete.Text = "min.";
            // 
            // cBViewed
            // 
            this.cBViewed.AutoSize = true;
            this.cBViewed.Location = new System.Drawing.Point(110, 442);
            this.cBViewed.Name = "cBViewed";
            this.cBViewed.Size = new System.Drawing.Size(61, 17);
            this.cBViewed.TabIndex = 10;
            this.cBViewed.Text = "Viewed";
            this.cBViewed.UseVisualStyleBackColor = true;
            // 
            // bAddPic
            // 
            this.bAddPic.Location = new System.Drawing.Point(13, 464);
            this.bAddPic.Margin = new System.Windows.Forms.Padding(2);
            this.bAddPic.Name = "bAddPic";
            this.bAddPic.Size = new System.Drawing.Size(55, 19);
            this.bAddPic.TabIndex = 11;
            this.bAddPic.Text = "Add Pic";
            this.bAddPic.UseVisualStyleBackColor = true;
            this.bAddPic.Click += new System.EventHandler(this.bAddPic_Click);
            // 
            // tbPicPath
            // 
            this.tbPicPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPicPath.Location = new System.Drawing.Point(74, 464);
            this.tbPicPath.Name = "tbPicPath";
            this.tbPicPath.Size = new System.Drawing.Size(137, 20);
            this.tbPicPath.TabIndex = 22;
            this.tbPicPath.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(12, 10);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(135, 20);
            this.tbSearch.TabIndex = 1;
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(154, 10);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(57, 23);
            this.bSearch.TabIndex = 2;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // pbSearchResult
            // 
            this.pbSearchResult.Location = new System.Drawing.Point(12, 37);
            this.pbSearchResult.Name = "pbSearchResult";
            this.pbSearchResult.Size = new System.Drawing.Size(199, 140);
            this.pbSearchResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearchResult.TabIndex = 25;
            this.pbSearchResult.TabStop = false;
            // 
            // fAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 526);
            this.ControlBox = false;
            this.Controls.Add(this.pbSearchResult);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tbPicPath);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(239, 420);
            this.Name = "fAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchResult)).EndInit();
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
        private System.Windows.Forms.TextBox tbPicPath;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.PictureBox pbSearchResult;
    }
}