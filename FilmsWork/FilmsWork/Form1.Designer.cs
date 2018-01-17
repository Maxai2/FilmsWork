namespace FilmsWork
{
    partial class FilmsView
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
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tlPanelButton = new System.Windows.Forms.TableLayoutPanel();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.dGTable = new System.Windows.Forms.DataGridView();
            this.cTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRuntime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cViewed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pDescriptionPhoto = new System.Windows.Forms.Panel();
            this.rTBdescription = new System.Windows.Forms.RichTextBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.lbDescription = new System.Windows.Forms.ListBox();
            this.tlPanel.SuspendLayout();
            this.tlPanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGTable)).BeginInit();
            this.pDescriptionPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tlPanel
            // 
            this.tlPanel.ColumnCount = 2;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.07474F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.92526F));
            this.tlPanel.Controls.Add(this.tlPanelButton, 1, 1);
            this.tlPanel.Controls.Add(this.dGTable, 0, 0);
            this.tlPanel.Controls.Add(this.pDescriptionPhoto, 1, 0);
            this.tlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanel.Location = new System.Drawing.Point(0, 0);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 2;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.6129F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.387096F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPanel.Size = new System.Drawing.Size(668, 463);
            this.tlPanel.TabIndex = 0;
            // 
            // tlPanelButton
            // 
            this.tlPanelButton.ColumnCount = 3;
            this.tlPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tlPanelButton.Controls.Add(this.bAdd, 0, 0);
            this.tlPanelButton.Controls.Add(this.bEdit, 1, 0);
            this.tlPanelButton.Controls.Add(this.bSearch, 2, 0);
            this.tlPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelButton.Location = new System.Drawing.Point(337, 427);
            this.tlPanelButton.MaximumSize = new System.Drawing.Size(329, 34);
            this.tlPanelButton.MinimumSize = new System.Drawing.Size(329, 34);
            this.tlPanelButton.Name = "tlPanelButton";
            this.tlPanelButton.RowCount = 1;
            this.tlPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanelButton.Size = new System.Drawing.Size(329, 34);
            this.tlPanelButton.TabIndex = 1;
            // 
            // bAdd
            // 
            this.bAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAdd.Location = new System.Drawing.Point(3, 3);
            this.bAdd.MinimumSize = new System.Drawing.Size(90, 30);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(107, 30);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bEdit.Location = new System.Drawing.Point(116, 3);
            this.bEdit.MinimumSize = new System.Drawing.Size(90, 30);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(107, 30);
            this.bEdit.TabIndex = 3;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bSearch
            // 
            this.bSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bSearch.Location = new System.Drawing.Point(229, 3);
            this.bSearch.MinimumSize = new System.Drawing.Size(90, 30);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(97, 30);
            this.bSearch.TabIndex = 4;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // dGTable
            // 
            this.dGTable.AllowUserToAddRows = false;
            this.dGTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTitle,
            this.cRuntime,
            this.cViewed});
            this.dGTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dGTable.Location = new System.Drawing.Point(3, 3);
            this.dGTable.Name = "dGTable";
            this.dGTable.ReadOnly = true;
            this.dGTable.RowHeadersWidth = 25;
            this.tlPanel.SetRowSpan(this.dGTable, 2);
            this.dGTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGTable.Size = new System.Drawing.Size(328, 457);
            this.dGTable.TabIndex = 1;
            this.dGTable.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dGTable_RowStateChanged);
            this.dGTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dGTable_KeyDown);
            // 
            // cTitle
            // 
            this.cTitle.HeaderText = "Title";
            this.cTitle.Name = "cTitle";
            this.cTitle.ReadOnly = true;
            this.cTitle.Width = 170;
            // 
            // cRuntime
            // 
            this.cRuntime.HeaderText = "Runtime(min.)";
            this.cRuntime.Name = "cRuntime";
            this.cRuntime.ReadOnly = true;
            this.cRuntime.Width = 75;
            // 
            // cViewed
            // 
            this.cViewed.HeaderText = "Viewed";
            this.cViewed.Name = "cViewed";
            this.cViewed.ReadOnly = true;
            this.cViewed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cViewed.Width = 56;
            // 
            // pDescriptionPhoto
            // 
            this.pDescriptionPhoto.Controls.Add(this.rTBdescription);
            this.pDescriptionPhoto.Controls.Add(this.pbPicture);
            this.pDescriptionPhoto.Controls.Add(this.lbDescription);
            this.pDescriptionPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDescriptionPhoto.Location = new System.Drawing.Point(336, 2);
            this.pDescriptionPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pDescriptionPhoto.Name = "pDescriptionPhoto";
            this.pDescriptionPhoto.Size = new System.Drawing.Size(330, 420);
            this.pDescriptionPhoto.TabIndex = 2;
            // 
            // rTBdescription
            // 
            this.rTBdescription.Location = new System.Drawing.Point(3, 200);
            this.rTBdescription.Name = "rTBdescription";
            this.rTBdescription.Size = new System.Drawing.Size(318, 217);
            this.rTBdescription.TabIndex = 2;
            this.rTBdescription.TabStop = false;
            this.rTBdescription.Text = "";
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(4, 9);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(106, 186);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 1;
            this.pbPicture.TabStop = false;
            // 
            // lbDescription
            // 
            this.lbDescription.FormattingEnabled = true;
            this.lbDescription.Location = new System.Drawing.Point(117, 9);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(207, 186);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.TabStop = false;
            // 
            // FilmsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 463);
            this.Controls.Add(this.tlPanel);
            this.MaximumSize = new System.Drawing.Size(684, 502);
            this.MinimumSize = new System.Drawing.Size(684, 502);
            this.Name = "FilmsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmsView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilmsView_FormClosing);
            this.tlPanel.ResumeLayout(false);
            this.tlPanelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGTable)).EndInit();
            this.pDescriptionPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.TableLayoutPanel tlPanelButton;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.DataGridView dGTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRuntime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cViewed;
        private System.Windows.Forms.Panel pDescriptionPhoto;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.ListBox lbDescription;
        private System.Windows.Forms.RichTextBox rTBdescription;
    }
}

