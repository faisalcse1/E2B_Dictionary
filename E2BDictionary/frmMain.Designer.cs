namespace E2BDictionary
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            mainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label2 = new Label();
            findWordTextBox = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            wordGridView = new DataGridView();
            SL = new DataGridViewTextBoxColumn();
            English = new DataGridViewTextBoxColumn();
            Bangla = new DataGridViewTextBoxColumn();
            Details = new DataGridViewTextBoxColumn();
            mainMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wordGridView).BeginInit();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, findToolStripMenuItem, helpToolStripMenuItem, aboutToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(850, 24);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(42, 20);
            findToolStripMenuItem.Text = "Find";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(findWordTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 44);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(463, 11);
            label2.Name = "label2";
            label2.Size = new Size(379, 21);
            label2.TabIndex = 2;
            label2.Text = "Bangla Dictionary With Bangla && English Search";
            // 
            // findWordTextBox
            // 
            findWordTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            findWordTextBox.Location = new Point(114, 7);
            findWordTextBox.Name = "findWordTextBox";
            findWordTextBox.Size = new Size(242, 27);
            findWordTextBox.TabIndex = 1;
            findWordTextBox.TextChanged += findWordTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 0;
            label1.Text = "Find Word";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 505);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 37);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(6, 8);
            label4.Name = "label4";
            label4.Size = new Size(310, 20);
            label4.TabIndex = 2;
            label4.Text = "Web Site: https://faisalcse1.gitlab.io/home";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(621, 8);
            label3.Name = "label3";
            label3.Size = new Size(223, 20);
            label3.TabIndex = 1;
            label3.Text = "Mail To: faisalcse3@gmail.com";
            // 
            // wordGridView
            // 
            wordGridView.AllowUserToAddRows = false;
            wordGridView.AllowUserToDeleteRows = false;
            wordGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wordGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            wordGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            wordGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            wordGridView.Columns.AddRange(new DataGridViewColumn[] { SL, English, Bangla, Details });
            wordGridView.Location = new Point(0, 70);
            wordGridView.Name = "wordGridView";
            wordGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            wordGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            wordGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            wordGridView.Size = new Size(850, 435);
            wordGridView.TabIndex = 3;
            // 
            // SL
            // 
            SL.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SL.DataPropertyName = "SL";
            SL.FillWeight = 40.60914F;
            SL.HeaderText = "SL";
            SL.Name = "SL";
            SL.ReadOnly = true;
            SL.Width = 60;
            // 
            // English
            // 
            English.DataPropertyName = "En";
            English.FillWeight = 83.94531F;
            English.HeaderText = "English";
            English.Name = "English";
            English.ReadOnly = true;
            // 
            // Bangla
            // 
            Bangla.DataPropertyName = "Bn";
            Bangla.FillWeight = 118.048111F;
            Bangla.HeaderText = "Bangla";
            Bangla.Name = "Bangla";
            Bangla.ReadOnly = true;
            // 
            // Details
            // 
            Details.DataPropertyName = "Details";
            Details.FillWeight = 157.397476F;
            Details.HeaderText = "Details";
            Details.Name = "Details";
            Details.ReadOnly = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 542);
            Controls.Add(wordGridView);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(mainMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenu;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E2B Dictionary By Md Faisal";
            Load += frmMain_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wordGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private TextBox findWordTextBox;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private DataGridView wordGridView;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn English;
        private DataGridViewTextBoxColumn Bangla;
        private DataGridViewTextBoxColumn Details;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
