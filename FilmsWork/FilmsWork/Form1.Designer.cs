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
            this.lBox = new System.Windows.Forms.ListBox();
            this.tlPanelButton = new System.Windows.Forms.TableLayoutPanel();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tlPanel.SuspendLayout();
            this.tlPanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPanel
            // 
            this.tlPanel.ColumnCount = 2;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanel.Controls.Add(this.lBox, 0, 0);
            this.tlPanel.Controls.Add(this.tlPanelButton, 1, 1);
            this.tlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanel.Location = new System.Drawing.Point(0, 0);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 2;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.6129F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.387096F));
            this.tlPanel.Size = new System.Drawing.Size(669, 465);
            this.tlPanel.TabIndex = 0;
            // 
            // lBox
            // 
            this.lBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBox.FormattingEnabled = true;
            this.lBox.Location = new System.Drawing.Point(3, 3);
            this.lBox.Name = "lBox";
            this.tlPanel.SetRowSpan(this.lBox, 2);
            this.lBox.Size = new System.Drawing.Size(328, 459);
            this.lBox.TabIndex = 0;
            // 
            // tlPanelButton
            // 
            this.tlPanelButton.ColumnCount = 3;
            this.tlPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tlPanelButton.Controls.Add(this.bAdd, 0, 0);
            this.tlPanelButton.Controls.Add(this.bEdit, 1, 0);
            this.tlPanelButton.Controls.Add(this.button1, 2, 0);
            this.tlPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelButton.Location = new System.Drawing.Point(337, 428);
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
            this.bAdd.MinimumSize = new System.Drawing.Size(111, 28);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(111, 28);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // bEdit
            // 
            this.bEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bEdit.Location = new System.Drawing.Point(120, 3);
            this.bEdit.MinimumSize = new System.Drawing.Size(111, 28);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(111, 28);
            this.bEdit.TabIndex = 0;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(237, 3);
            this.button1.MinimumSize = new System.Drawing.Size(89, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FilmsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 465);
            this.Controls.Add(this.tlPanel);
            this.MinimumSize = new System.Drawing.Size(685, 504);
            this.Name = "FilmsView";
            this.Text = "FilmsView";
            this.tlPanel.ResumeLayout(false);
            this.tlPanelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.ListBox lBox;
        private System.Windows.Forms.TableLayoutPanel tlPanelButton;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button button1;
    }
}

