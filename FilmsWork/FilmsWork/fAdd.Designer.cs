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
            this.lType = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.cBType = new System.Windows.Forms.ComboBox();
            this.rTBDescription = new System.Windows.Forms.RichTextBox();
            this.tBDirector = new System.Windows.Forms.TextBox();
            this.cBLanguage = new System.Windows.Forms.ComboBox();
            this.cBGenre = new System.Windows.Forms.ComboBox();
            this.mtBYear = new System.Windows.Forms.MaskedTextBox();
            this.mtBRuntime = new System.Windows.Forms.MaskedTextBox();
            this.lYearN = new System.Windows.Forms.Label();
            this.tBTitle = new System.Windows.Forms.TextBox();
            this.lMinuete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lTytle
            // 
            this.lTytle.AutoSize = true;
            this.lTytle.Location = new System.Drawing.Point(10, 15);
            this.lTytle.Name = "lTytle";
            this.lTytle.Size = new System.Drawing.Size(27, 13);
            this.lTytle.TabIndex = 0;
            this.lTytle.Text = "Title";
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Location = new System.Drawing.Point(10, 42);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(29, 13);
            this.lYear.TabIndex = 1;
            this.lYear.Text = "Year";
            // 
            // lRuntime
            // 
            this.lRuntime.AutoSize = true;
            this.lRuntime.Location = new System.Drawing.Point(10, 67);
            this.lRuntime.Name = "lRuntime";
            this.lRuntime.Size = new System.Drawing.Size(46, 13);
            this.lRuntime.TabIndex = 2;
            this.lRuntime.Text = "Runtime";
            // 
            // lGenre
            // 
            this.lGenre.AutoSize = true;
            this.lGenre.Location = new System.Drawing.Point(10, 95);
            this.lGenre.Name = "lGenre";
            this.lGenre.Size = new System.Drawing.Size(36, 13);
            this.lGenre.TabIndex = 3;
            this.lGenre.Text = "Genre";
            this.lGenre.Click += new System.EventHandler(this.lGenre_Click);
            // 
            // lLanguage
            // 
            this.lLanguage.AutoSize = true;
            this.lLanguage.Location = new System.Drawing.Point(10, 124);
            this.lLanguage.Name = "lLanguage";
            this.lLanguage.Size = new System.Drawing.Size(55, 13);
            this.lLanguage.TabIndex = 4;
            this.lLanguage.Text = "Language";
            // 
            // lDirector
            // 
            this.lDirector.AutoSize = true;
            this.lDirector.Location = new System.Drawing.Point(10, 155);
            this.lDirector.Name = "lDirector";
            this.lDirector.Size = new System.Drawing.Size(44, 13);
            this.lDirector.TabIndex = 5;
            this.lDirector.Text = "Director";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(10, 186);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(31, 13);
            this.lType.TabIndex = 6;
            this.lType.Text = "Type";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(10, 216);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(60, 13);
            this.lDescription.TabIndex = 7;
            this.lDescription.Text = "Description";
            // 
            // bOk
            // 
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Location = new System.Drawing.Point(18, 315);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 8;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(127, 315);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 9;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // cBType
            // 
            this.cBType.FormattingEnabled = true;
            this.cBType.Items.AddRange(new object[] {
            "Movie",
            "Serial"});
            this.cBType.Location = new System.Drawing.Point(77, 186);
            this.cBType.Name = "cBType";
            this.cBType.Size = new System.Drawing.Size(134, 21);
            this.cBType.TabIndex = 7;
            // 
            // rTBDescription
            // 
            this.rTBDescription.Location = new System.Drawing.Point(77, 216);
            this.rTBDescription.Name = "rTBDescription";
            this.rTBDescription.Size = new System.Drawing.Size(134, 81);
            this.rTBDescription.TabIndex = 8;
            this.rTBDescription.Text = "";
            // 
            // tBDirector
            // 
            this.tBDirector.Location = new System.Drawing.Point(77, 155);
            this.tBDirector.Name = "tBDirector";
            this.tBDirector.Size = new System.Drawing.Size(134, 20);
            this.tBDirector.TabIndex = 6;
            // 
            // cBLanguage
            // 
            this.cBLanguage.FormattingEnabled = true;
            this.cBLanguage.Items.AddRange(new object[] {
            "Russian",
            "English",
            "Azerbaijan"});
            this.cBLanguage.Location = new System.Drawing.Point(77, 124);
            this.cBLanguage.Name = "cBLanguage";
            this.cBLanguage.Size = new System.Drawing.Size(134, 21);
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
            this.cBGenre.Location = new System.Drawing.Point(77, 95);
            this.cBGenre.Name = "cBGenre";
            this.cBGenre.Size = new System.Drawing.Size(134, 21);
            this.cBGenre.TabIndex = 4;
            // 
            // mtBYear
            // 
            this.mtBYear.Location = new System.Drawing.Point(77, 39);
            this.mtBYear.Mask = "0000";
            this.mtBYear.Name = "mtBYear";
            this.mtBYear.Size = new System.Drawing.Size(30, 20);
            this.mtBYear.TabIndex = 2;
            this.mtBYear.ValidatingType = typeof(System.DateTime);
            // 
            // mtBRuntime
            // 
            this.mtBRuntime.Location = new System.Drawing.Point(77, 67);
            this.mtBRuntime.Mask = "000";
            this.mtBRuntime.Name = "mtBRuntime";
            this.mtBRuntime.Size = new System.Drawing.Size(24, 20);
            this.mtBRuntime.TabIndex = 3;
            this.mtBRuntime.ValidatingType = typeof(int);
            this.mtBRuntime.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // lYearN
            // 
            this.lYearN.AutoSize = true;
            this.lYearN.Location = new System.Drawing.Point(113, 42);
            this.lYearN.Name = "lYearN";
            this.lYearN.Size = new System.Drawing.Size(27, 13);
            this.lYearN.TabIndex = 18;
            this.lYearN.Text = "year";
            // 
            // tBTitle
            // 
            this.tBTitle.Location = new System.Drawing.Point(77, 12);
            this.tBTitle.Name = "tBTitle";
            this.tBTitle.Size = new System.Drawing.Size(134, 20);
            this.tBTitle.TabIndex = 1;
            // 
            // lMinuete
            // 
            this.lMinuete.AutoSize = true;
            this.lMinuete.Location = new System.Drawing.Point(107, 70);
            this.lMinuete.Name = "lMinuete";
            this.lMinuete.Size = new System.Drawing.Size(26, 13);
            this.lMinuete.TabIndex = 20;
            this.lMinuete.Text = "min.";
            // 
            // fAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 348);
            this.Controls.Add(this.lMinuete);
            this.Controls.Add(this.tBTitle);
            this.Controls.Add(this.lYearN);
            this.Controls.Add(this.mtBRuntime);
            this.Controls.Add(this.mtBYear);
            this.Controls.Add(this.cBGenre);
            this.Controls.Add(this.cBLanguage);
            this.Controls.Add(this.tBDirector);
            this.Controls.Add(this.rTBDescription);
            this.Controls.Add(this.cBType);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.lDirector);
            this.Controls.Add(this.lLanguage);
            this.Controls.Add(this.lGenre);
            this.Controls.Add(this.lRuntime);
            this.Controls.Add(this.lYear);
            this.Controls.Add(this.lTytle);
            this.Name = "fAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.fAdd_Load);
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
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.ComboBox cBType;
        private System.Windows.Forms.RichTextBox rTBDescription;
        private System.Windows.Forms.TextBox tBDirector;
        private System.Windows.Forms.ComboBox cBLanguage;
        private System.Windows.Forms.ComboBox cBGenre;
        private System.Windows.Forms.MaskedTextBox mtBYear;
        private System.Windows.Forms.MaskedTextBox mtBRuntime;
        private System.Windows.Forms.Label lYearN;
        private System.Windows.Forms.TextBox tBTitle;
        private System.Windows.Forms.Label lMinuete;
    }
}