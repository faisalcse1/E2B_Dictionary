using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2BDictionary
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            hideButton.Visible = false;
            string description = "I am an experienced full-stack developer with a passion for building scalable and efficient web applications." + Environment.NewLine + "I love to learn new technology and teach people throgh my Programming Palli youtube channel.";


            descriptionTextBox.Text = description;

        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            hideButton.Visible = false;
            pictureBox1.Visible = false;
            showImageButton.Visible = true;
        }

        private void showImageButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            showImageButton.Visible = false;
            hideButton.Visible = true;
        }
    }
}
