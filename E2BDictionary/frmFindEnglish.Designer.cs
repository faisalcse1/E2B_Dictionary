namespace E2BDictionary
{
    partial class frmFindEnglish
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindEnglish));
            searchButton = new Button();
            findWordTextBox = new TextBox();
            dataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            button22 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            button31 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button10 = new Button();
            button11 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.Location = new Point(381, 128);
            searchButton.Margin = new Padding(4, 3, 4, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(72, 27);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // findWordTextBox
            // 
            findWordTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            findWordTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            findWordTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            findWordTextBox.Location = new Point(128, 129);
            findWordTextBox.Margin = new Padding(4, 3, 4, 3);
            findWordTextBox.Name = "findWordTextBox";
            findWordTextBox.Size = new Size(245, 26);
            findWordTextBox.TabIndex = 6;
            findWordTextBox.TextChanged += findWordTextBox_TextChanged;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(6, 220);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(483, 173);
            dataGridView.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button22);
            groupBox1.Controls.Add(button26);
            groupBox1.Controls.Add(button27);
            groupBox1.Controls.Add(button28);
            groupBox1.Controls.Add(button29);
            groupBox1.Controls.Add(button30);
            groupBox1.Controls.Add(button31);
            groupBox1.Controls.Add(button12);
            groupBox1.Controls.Add(button13);
            groupBox1.Controls.Add(button14);
            groupBox1.Controls.Add(button15);
            groupBox1.Controls.Add(button16);
            groupBox1.Controls.Add(button17);
            groupBox1.Controls.Add(button18);
            groupBox1.Controls.Add(button19);
            groupBox1.Controls.Add(button20);
            groupBox1.Controls.Add(button21);
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(button11);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(findWordTextBox);
            groupBox1.Controls.Add(searchButton);
            groupBox1.Location = new Point(13, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(474, 168);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Panel";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button22
            // 
            button22.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button22.ForeColor = Color.DarkRed;
            button22.Location = new Point(411, 90);
            button22.Margin = new Padding(4, 3, 4, 3);
            button22.Name = "button22";
            button22.Size = new Size(42, 35);
            button22.TabIndex = 39;
            button22.Text = "X";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button22_Click;
            // 
            // button26
            // 
            button26.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button26.ForeColor = SystemColors.Highlight;
            button26.Location = new Point(243, 90);
            button26.Margin = new Padding(4, 3, 4, 3);
            button26.Name = "button26";
            button26.Size = new Size(42, 35);
            button26.TabIndex = 38;
            button26.Text = "z";
            button26.UseVisualStyleBackColor = true;
            button26.Click += button26_Click;
            // 
            // button27
            // 
            button27.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button27.ForeColor = SystemColors.Highlight;
            button27.Location = new Point(201, 90);
            button27.Margin = new Padding(4, 3, 4, 3);
            button27.Name = "button27";
            button27.Size = new Size(42, 35);
            button27.TabIndex = 37;
            button27.Text = "y";
            button27.UseVisualStyleBackColor = true;
            button27.Click += button27_Click;
            // 
            // button28
            // 
            button28.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button28.ForeColor = SystemColors.Highlight;
            button28.Location = new Point(159, 90);
            button28.Margin = new Padding(4, 3, 4, 3);
            button28.Name = "button28";
            button28.Size = new Size(42, 35);
            button28.TabIndex = 36;
            button28.Text = "x";
            button28.UseVisualStyleBackColor = true;
            button28.Click += button28_Click;
            // 
            // button29
            // 
            button29.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button29.ForeColor = SystemColors.Highlight;
            button29.Location = new Point(117, 90);
            button29.Margin = new Padding(4, 3, 4, 3);
            button29.Name = "button29";
            button29.Size = new Size(42, 35);
            button29.TabIndex = 35;
            button29.Text = "w";
            button29.UseVisualStyleBackColor = true;
            button29.Click += button29_Click;
            // 
            // button30
            // 
            button30.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button30.ForeColor = SystemColors.Highlight;
            button30.Location = new Point(75, 90);
            button30.Margin = new Padding(4, 3, 4, 3);
            button30.Name = "button30";
            button30.Size = new Size(42, 35);
            button30.TabIndex = 34;
            button30.Text = "v";
            button30.UseVisualStyleBackColor = true;
            button30.Click += button30_Click;
            // 
            // button31
            // 
            button31.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button31.ForeColor = SystemColors.Highlight;
            button31.Location = new Point(33, 90);
            button31.Margin = new Padding(4, 3, 4, 3);
            button31.Name = "button31";
            button31.Size = new Size(42, 35);
            button31.TabIndex = 33;
            button31.Text = "u";
            button31.UseVisualStyleBackColor = true;
            button31.Click += button31_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = SystemColors.Highlight;
            button12.Location = new Point(411, 54);
            button12.Margin = new Padding(4, 3, 4, 3);
            button12.Name = "button12";
            button12.Size = new Size(42, 35);
            button12.TabIndex = 32;
            button12.Text = "t";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.ForeColor = SystemColors.Highlight;
            button13.Location = new Point(369, 54);
            button13.Margin = new Padding(4, 3, 4, 3);
            button13.Name = "button13";
            button13.Size = new Size(42, 35);
            button13.TabIndex = 31;
            button13.Text = "s";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button14.ForeColor = SystemColors.Highlight;
            button14.Location = new Point(327, 54);
            button14.Margin = new Padding(4, 3, 4, 3);
            button14.Name = "button14";
            button14.Size = new Size(42, 35);
            button14.TabIndex = 30;
            button14.Text = "r";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button15.ForeColor = SystemColors.Highlight;
            button15.Location = new Point(285, 54);
            button15.Margin = new Padding(4, 3, 4, 3);
            button15.Name = "button15";
            button15.Size = new Size(42, 35);
            button15.TabIndex = 29;
            button15.Text = "q";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button16.ForeColor = SystemColors.Highlight;
            button16.Location = new Point(243, 54);
            button16.Margin = new Padding(4, 3, 4, 3);
            button16.Name = "button16";
            button16.Size = new Size(42, 35);
            button16.TabIndex = 28;
            button16.Text = "p";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button17.ForeColor = SystemColors.Highlight;
            button17.Location = new Point(201, 54);
            button17.Margin = new Padding(4, 3, 4, 3);
            button17.Name = "button17";
            button17.Size = new Size(42, 35);
            button17.TabIndex = 27;
            button17.Text = "o";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button18.ForeColor = SystemColors.Highlight;
            button18.Location = new Point(159, 54);
            button18.Margin = new Padding(4, 3, 4, 3);
            button18.Name = "button18";
            button18.Size = new Size(42, 35);
            button18.TabIndex = 26;
            button18.Text = "n";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button19.ForeColor = SystemColors.Highlight;
            button19.Location = new Point(117, 54);
            button19.Margin = new Padding(4, 3, 4, 3);
            button19.Name = "button19";
            button19.Size = new Size(42, 35);
            button19.TabIndex = 25;
            button19.Text = "m";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button20.ForeColor = SystemColors.Highlight;
            button20.Location = new Point(75, 54);
            button20.Margin = new Padding(4, 3, 4, 3);
            button20.Name = "button20";
            button20.Size = new Size(42, 35);
            button20.TabIndex = 24;
            button20.Text = "l";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // button21
            // 
            button21.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button21.ForeColor = SystemColors.Highlight;
            button21.Location = new Point(33, 54);
            button21.Margin = new Padding(4, 3, 4, 3);
            button21.Name = "button21";
            button21.Size = new Size(42, 35);
            button21.TabIndex = 23;
            button21.Text = "k";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button21_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.Highlight;
            button10.Location = new Point(411, 18);
            button10.Margin = new Padding(4, 3, 4, 3);
            button10.Name = "button10";
            button10.Size = new Size(42, 35);
            button10.TabIndex = 22;
            button10.Text = "j";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.ForeColor = SystemColors.Highlight;
            button11.Location = new Point(369, 18);
            button11.Margin = new Padding(4, 3, 4, 3);
            button11.Name = "button11";
            button11.Size = new Size(42, 35);
            button11.TabIndex = 21;
            button11.Text = "i";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.Highlight;
            button6.Location = new Point(327, 18);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(42, 35);
            button6.TabIndex = 20;
            button6.Text = "h";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.Highlight;
            button7.Location = new Point(285, 18);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(42, 35);
            button7.TabIndex = 19;
            button7.Text = "g";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.Highlight;
            button8.Location = new Point(243, 18);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new Size(42, 35);
            button8.TabIndex = 18;
            button8.Text = "f";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.Highlight;
            button9.Location = new Point(201, 18);
            button9.Margin = new Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new Size(42, 35);
            button9.TabIndex = 17;
            button9.Text = "e";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Highlight;
            button4.Location = new Point(159, 18);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(42, 35);
            button4.TabIndex = 16;
            button4.Text = "d";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Highlight;
            button5.Location = new Point(117, 18);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(42, 35);
            button5.TabIndex = 15;
            button5.Text = "c";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Highlight;
            button3.Location = new Point(75, 18);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(42, 35);
            button3.TabIndex = 14;
            button3.Text = "b";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(33, 18);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(42, 35);
            button2.TabIndex = 13;
            button2.Text = "a";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 133);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 11;
            label2.Text = "Find Word ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 193);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 10;
            label1.Text = "Search Result";
            // 
            // frmFindEnglish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 397);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmFindEnglish";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Search English Word";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox findWordTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button22;
    }
}