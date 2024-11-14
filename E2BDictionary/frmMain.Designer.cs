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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            mainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            findBanglaToolStripMenuItem = new ToolStripMenuItem();
            findEnglishToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            youtubeToolStripMenuItem = new ToolStripMenuItem();
            facebookToolStripMenuItem = new ToolStripMenuItem();
            sourceCodeToolStripMenuItem = new ToolStripMenuItem();
            nugetToolStripMenuItem = new ToolStripMenuItem();
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
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            mainMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wordGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.BackColor = SystemColors.ActiveCaption;
            mainMenu.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, findToolStripMenuItem, helpToolStripMenuItem, aboutToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(850, 25);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(41, 21);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(99, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findBanglaToolStripMenuItem, findEnglishToolStripMenuItem });
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(45, 21);
            findToolStripMenuItem.Text = "Find";
            // 
            // findBanglaToolStripMenuItem
            // 
            findBanglaToolStripMenuItem.Name = "findBanglaToolStripMenuItem";
            findBanglaToolStripMenuItem.Size = new Size(147, 22);
            findBanglaToolStripMenuItem.Text = "Find Bangla";
            findBanglaToolStripMenuItem.Click += findBanglaToolStripMenuItem_Click;
            // 
            // findEnglishToolStripMenuItem
            // 
            findEnglishToolStripMenuItem.Name = "findEnglishToolStripMenuItem";
            findEnglishToolStripMenuItem.Size = new Size(147, 22);
            findEnglishToolStripMenuItem.Text = "Find English";
            findEnglishToolStripMenuItem.Click += findEnglishToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { youtubeToolStripMenuItem, facebookToolStripMenuItem, sourceCodeToolStripMenuItem, nugetToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(48, 21);
            helpToolStripMenuItem.Text = "Help";
            // 
            // youtubeToolStripMenuItem
            // 
            youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            youtubeToolStripMenuItem.Size = new Size(180, 22);
            youtubeToolStripMenuItem.Text = "Youtube";
            youtubeToolStripMenuItem.Click += youtubeToolStripMenuItem_Click;
            // 
            // facebookToolStripMenuItem
            // 
            facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            facebookToolStripMenuItem.Size = new Size(180, 22);
            facebookToolStripMenuItem.Text = "Facebook";
            facebookToolStripMenuItem.Click += facebookToolStripMenuItem_Click;
            // 
            // sourceCodeToolStripMenuItem
            // 
            sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            sourceCodeToolStripMenuItem.Size = new Size(180, 22);
            sourceCodeToolStripMenuItem.Text = "Source Code";
            sourceCodeToolStripMenuItem.Click += sourceCodeToolStripMenuItem_Click;
            // 
            // nugetToolStripMenuItem
            // 
            nugetToolStripMenuItem.Name = "nugetToolStripMenuItem";
            nugetToolStripMenuItem.Size = new Size(180, 22);
            nugetToolStripMenuItem.Text = "Nuget";
            nugetToolStripMenuItem.Click += nugetToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(56, 21);
            aboutToolStripMenuItem.Text = "About";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(findWordTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 44);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(507, 13);
            label2.Name = "label2";
            label2.Size = new Size(337, 19);
            label2.TabIndex = 2;
            label2.Text = "Bangla Dictionary With Bangla && English Search";
            // 
            // findWordTextBox
            // 
            findWordTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            findWordTextBox.Location = new Point(114, 9);
            findWordTextBox.Name = "findWordTextBox";
            findWordTextBox.Size = new Size(242, 27);
            findWordTextBox.TabIndex = 1;
            findWordTextBox.TextChanged += findWordTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 0;
            label1.Text = "Find Word";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 534);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 37);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 9);
            label4.Name = "label4";
            label4.Size = new Size(280, 17);
            label4.TabIndex = 2;
            label4.Text = "Web Site: https://faisalcse1.gitlab.io/home";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(633, 9);
            label3.Name = "label3";
            label3.Size = new Size(211, 17);
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
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            wordGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            wordGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            wordGridView.Columns.AddRange(new DataGridViewColumn[] { SL, English, Bangla, Details });
            wordGridView.Location = new Point(0, 141);
            wordGridView.Name = "wordGridView";
            wordGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            wordGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            wordGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            wordGridView.Size = new Size(850, 392);
            wordGridView.TabIndex = 3;
            // 
            // SL
            // 
            SL.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SL.DataPropertyName = "SL";
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SL.DefaultCellStyle = dataGridViewCellStyle2;
            SL.FillWeight = 40.60914F;
            SL.HeaderText = "SL";
            SL.Name = "SL";
            SL.ReadOnly = true;
            SL.Width = 60;
            // 
            // English
            // 
            English.DataPropertyName = "En";
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            English.DefaultCellStyle = dataGridViewCellStyle3;
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
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(680, 43);
            label5.Name = "label5";
            label5.Size = new Size(168, 37);
            label5.TabIndex = 4;
            label5.Text = "Programming Palli";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(74, 25);
            label6.Name = "label6";
            label6.Size = new Size(192, 66);
            label6.TabIndex = 5;
            label6.Text = "E2B Dictionary";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.book1;
            pictureBox1.Location = new Point(16, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(616, 50);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 7;
            label7.Text = "Powered By:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 570);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem findBanglaToolStripMenuItem;
        private ToolStripMenuItem findEnglishToolStripMenuItem;
        private ToolStripMenuItem youtubeToolStripMenuItem;
        private ToolStripMenuItem facebookToolStripMenuItem;
        private ToolStripMenuItem sourceCodeToolStripMenuItem;
        private ToolStripMenuItem nugetToolStripMenuItem;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn English;
        private DataGridViewTextBoxColumn Bangla;
        private DataGridViewTextBoxColumn Details;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
    }
}
