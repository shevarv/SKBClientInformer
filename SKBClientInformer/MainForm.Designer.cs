namespace ShevarvProject.SKBClientInformerNamespace
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CbUserGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OkButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.MoveButton = new System.Windows.Forms.Button();
            this.SkbIdLabel = new System.Windows.Forms.Label();
            this.SkbIdTextBox = new System.Windows.Forms.TextBox();
            this.EDRPOULabel = new System.Windows.Forms.Label();
            this.EDRPOUTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.ProgBar = new System.Windows.Forms.ProgressBar();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CbUserGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbUserGrid
            // 
            this.CbUserGrid.AllowUserToAddRows = false;
            this.CbUserGrid.AllowUserToDeleteRows = false;
            this.CbUserGrid.AllowUserToOrderColumns = true;
            this.CbUserGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.CbUserGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbUserGrid.Location = new System.Drawing.Point(0, 24);
            this.CbUserGrid.MultiSelect = false;
            this.CbUserGrid.Name = "CbUserGrid";
            this.CbUserGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.CbUserGrid.RowTemplate.Height = 18;
            this.CbUserGrid.RowTemplate.ReadOnly = true;
            this.CbUserGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CbUserGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CbUserGrid.Size = new System.Drawing.Size(827, 604);
            this.CbUserGrid.TabIndex = 0;
            this.CbUserGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CbUserGrid_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OkButton,
            this.toolStripSeparator1,
            this.SearchButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 628);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(827, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OkButton.Image = ((System.Drawing.Image)(resources.GetObject("OkButton.Image")));
            this.OkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(23, 22);
            this.OkButton.Text = "toolStripButton1";
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SearchButton
            // 
            this.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(23, 22);
            this.SearchButton.Text = "toolStripButton1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.MoveButton);
            this.SearchPanel.Controls.Add(this.SkbIdLabel);
            this.SearchPanel.Controls.Add(this.SkbIdTextBox);
            this.SearchPanel.Controls.Add(this.EDRPOULabel);
            this.SearchPanel.Controls.Add(this.EDRPOUTextBox);
            this.SearchPanel.Controls.Add(this.NameLabel);
            this.SearchPanel.Controls.Add(this.NameTextBox);
            this.SearchPanel.Controls.Add(this.IdLabel);
            this.SearchPanel.Controls.Add(this.IdTextBox);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchPanel.Location = new System.Drawing.Point(786, 24);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(41, 604);
            this.SearchPanel.TabIndex = 2;
            this.SearchPanel.Tag = "Close";
            // 
            // MoveButton
            // 
            this.MoveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MoveButton.Location = new System.Drawing.Point(0, 0);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(40, 604);
            this.MoveButton.TabIndex = 8;
            this.MoveButton.Text = "<<";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // SkbIdLabel
            // 
            this.SkbIdLabel.AutoSize = true;
            this.SkbIdLabel.Location = new System.Drawing.Point(46, 103);
            this.SkbIdLabel.Name = "SkbIdLabel";
            this.SkbIdLabel.Size = new System.Drawing.Size(50, 13);
            this.SkbIdLabel.TabIndex = 7;
            this.SkbIdLabel.Text = "Код СКБ";
            // 
            // SkbIdTextBox
            // 
            this.SkbIdTextBox.Location = new System.Drawing.Point(140, 96);
            this.SkbIdTextBox.Name = "SkbIdTextBox";
            this.SkbIdTextBox.Size = new System.Drawing.Size(93, 20);
            this.SkbIdTextBox.TabIndex = 6;
            // 
            // EDRPOULabel
            // 
            this.EDRPOULabel.AutoSize = true;
            this.EDRPOULabel.Location = new System.Drawing.Point(46, 77);
            this.EDRPOULabel.Name = "EDRPOULabel";
            this.EDRPOULabel.Size = new System.Drawing.Size(54, 13);
            this.EDRPOULabel.TabIndex = 5;
            this.EDRPOULabel.Text = "ЕДРПОУ";
            // 
            // EDRPOUTextBox
            // 
            this.EDRPOUTextBox.Location = new System.Drawing.Point(140, 70);
            this.EDRPOUTextBox.Name = "EDRPOUTextBox";
            this.EDRPOUTextBox.Size = new System.Drawing.Size(93, 20);
            this.EDRPOUTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(46, 51);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(79, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Назва клієнта";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(140, 44);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(265, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(46, 25);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(53, 13);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "Код ОДБ";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(140, 18);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(93, 20);
            this.IdTextBox.TabIndex = 0;
            // 
            // ProgBar
            // 
            this.ProgBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgBar.Location = new System.Drawing.Point(575, 628);
            this.ProgBar.Name = "ProgBar";
            this.ProgBar.Size = new System.Drawing.Size(249, 23);
            this.ProgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgBar.TabIndex = 3;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.BackButton);
            this.InfoPanel.Location = new System.Drawing.Point(0, 24);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(3, 3, 53, 3);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(753, 604);
            this.InfoPanel.TabIndex = 4;
            this.InfoPanel.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.BackButton.Location = new System.Drawing.Point(343, 557);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 653);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.ProgBar);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.CbUserGrid);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Інформація про клієнтів системи \"Клієнт банк\"";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.CbUserGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CbUserGrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OkButton;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label SkbIdLabel;
        private System.Windows.Forms.TextBox SkbIdTextBox;
        private System.Windows.Forms.Label EDRPOULabel;
        private System.Windows.Forms.TextBox EDRPOUTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.ProgressBar ProgBar;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button BackButton;
    }
}

