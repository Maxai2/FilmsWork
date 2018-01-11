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
            this.bAPI = new System.Windows.Forms.Button();
            this.dGTable = new System.Windows.Forms.DataGridView();
            this.lbDescription = new System.Windows.Forms.ListBox();
            this.cTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRuntime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cViewed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tlPanel.SuspendLayout();
            this.tlPanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tlPanel
            // 
            this.tlPanel.ColumnCount = 2;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.07474F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.92526F));
            this.tlPanel.Controls.Add(this.tlPanelButton, 1, 1);
            this.tlPanel.Controls.Add(this.dGTable, 0, 0);
            this.tlPanel.Controls.Add(this.lbDescription, 1, 0);
            this.tlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanel.Location = new System.Drawing.Point(0, 0);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 2;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.6129F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.387096F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPanel.Size = new System.Drawing.Size(669, 465);
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
            this.tlPanelButton.Controls.Add(this.bAPI, 2, 0);
            this.tlPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelButton.Location = new System.Drawing.Point(338, 428);
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
            // 
            // bAPI
            // 
            this.bAPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAPI.Location = new System.Drawing.Point(229, 3);
            this.bAPI.MinimumSize = new System.Drawing.Size(90, 30);
            this.bAPI.Name = "bAPI";
            this.bAPI.Size = new System.Drawing.Size(97, 30);
            this.bAPI.TabIndex = 4;
            this.bAPI.Text = "API";
            this.bAPI.UseVisualStyleBackColor = true;
            // 
            // dGTable
            // 
            this.dGTable.AllowUserToDeleteRows = false;
            this.dGTable.AllowUserToOrderColumns = true;
            this.dGTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTitle,
            this.cRuntime,
            this.cViewed});
            this.dGTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dGTable.Location = new System.Drawing.Point(3, 3);
            this.dGTable.Name = "dGTable";
            this.dGTable.RowHeadersWidth = 30;
            this.tlPanel.SetRowSpan(this.dGTable, 2);
            this.dGTable.Size = new System.Drawing.Size(329, 459);
            this.dGTable.TabIndex = 1;
            // 
            // lbDescription
            // 
            this.lbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDescription.FormattingEnabled = true;
            this.lbDescription.Location = new System.Drawing.Point(338, 3);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(328, 419);
            this.lbDescription.TabIndex = 3;
            this.lbDescription.SelectedIndexChanged += new System.EventHandler(this.lbDescription_SelectedIndexChanged);
            // 
            // cTitle
            // 
            this.cTitle.HeaderText = "Title";
            this.cTitle.Name = "cTitle";
            this.cTitle.ReadOnly = true;
            // 
            // cRuntime
            // 
            this.cRuntime.HeaderText = "Runtime";
            this.cRuntime.Name = "cRuntime";
            this.cRuntime.ReadOnly = true;
            this.cRuntime.Width = 50;
            // 
            // cViewed
            // 
            this.cViewed.HeaderText = "Viewed";
            this.cViewed.Name = "cViewed";
            this.cViewed.ReadOnly = true;
            this.cViewed.Width = 50;
            // 
            // FilmsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 465);
            this.Controls.Add(this.tlPanel);
            this.MaximumSize = new System.Drawing.Size(685, 504);
            this.MinimumSize = new System.Drawing.Size(685, 504);
            this.Name = "FilmsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmsView";
            this.tlPanel.ResumeLayout(false);
            this.tlPanelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.TableLayoutPanel tlPanelButton;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bAPI;
        private System.Windows.Forms.DataGridView dGTable;
        private System.Windows.Forms.ListBox lbDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRuntime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cViewed;
    }
}

