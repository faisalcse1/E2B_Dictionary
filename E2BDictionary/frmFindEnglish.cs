using E2BWordBank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2BDictionary
{
    public partial class frmFindEnglish : Form
    {
        public frmFindEnglish()
        {
            InitializeComponent();
        }

        private List<Word> wordList = WordRepository.GetAllWords();
        private void Form2_Load(object sender, EventArgs e)
        {
            findWordTextBox.Focus();            
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            
            foreach (var data in wordList)
            {
                MyCollection.Add(data.En);
            }
            findWordTextBox.AutoCompleteCustomSource = MyCollection;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "z";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "y";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "x";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "w";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "v";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "u";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "a";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "b";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "c";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "d";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "e";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "f";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "g";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "h";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "i";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "j";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "k";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "l";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "m";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "n";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "o";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "p";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "q";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "r";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "s";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            findWordTextBox.Text += "t";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            findWordTextBox.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //IEnumerable<Words> data = wordList.Where(s => s.English.Equals(WordBook.UppercaseFirst(findWordTextBox.Text)));
            //List<Words> SerchData = new List<Words>();
            //foreach (var vaue in data)
            //{
            //    SerchData.Add(vaue);
            //}
            //if (findWordTextBox.Text == "")
            //{
            //    findWordTextBox.Focus();
            //    MessageBox.Show("Please type something .", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //}
            //else if (SerchData.Count > 0)
            //{

            //    dataGridView1.DataSource = SerchData;
            //    dataGridView1.Columns[0].Visible = false;
            //}
            //else
            //{
            //    dataGridView1.DataSource = null;
            //    MessageBox.Show("No data Found .", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (findWordTextBox.Text.Trim() == "")
            {
                dataGridView1.DataSource = null;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
