using E2BWordBank;
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
    public partial class frmFindBangla : Form
    {
        public frmFindBangla()
        {
            InitializeComponent();
        }

        private List<Word> wordList = WordRepository.GetAllWords(); 
    

        private void FindBangla_Load(object sender, EventArgs e)
        {
        
            searchTextBox.Focus();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            foreach (var data in wordList)
            {
                MyCollection.Add(data.Bn);
            }
            searchTextBox.AutoCompleteCustomSource = MyCollection;
        }

        private void button143_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button143.Text;
        }

   

        private void button135_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button135.Text;
        }

        private void button141_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button141.Text;
        }

        private void button137_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button137.Text;
        }

        private void button128_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button128.Text;
        }

        private void button142_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button142.Text;
        }

        private void button140_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button140.Text;
        }

        private void button132_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button132.Text;
        }

        private void button138_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button138.Text;
        }

        private void button134_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button134.Text;
        }

        private void button127_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button127.Text;
        }

        private void button122_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button122.Text;
        }

        private void button108_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button108.Text;
        }

        private void button96_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button96.Text;
        }

        private void button116_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button116.Text;
        }

        private void button106_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button106.Text;
        }

        private void button94_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button94.Text;
        }

        private void button121_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button121.Text;
        }

        private void button107_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button107.Text;
        }

        private void button95_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button95.Text;
        }

        private void button115_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button115.Text;
        }

        private void button105_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button105.Text;
        }

        private void button93_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button93.Text;
        }

        private void button139_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button139.Text;
        }

        private void button126_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button126.Text;
        }

        private void button114_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button114.Text;
        }

        private void button133_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button133.Text;
        }

        private void button120_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button120.Text;
        }

        private void button110_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button110.Text;
        }

        private void button136_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button136.Text;
        }

        private void button125_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button125.Text;
        }

        private void button113_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button113.Text;
        }

   

        private void button119_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button119.Text;
        }

        private void button109_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button109.Text;
        }

        private void button100_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button100.Text;
        }

        private void button88_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button88.Text;
        }

        private void button84_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button84.Text;
        }

        private void button98_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button98.Text;
        }

        private void button86_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button86.Text;
        }

        private void button82_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button82.Text;
        }

        private void button99_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button99.Text;
        }

        private void button83_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button83.Text;
        }

        private void button97_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button97.Text;
        }

        private void button73_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button73.Text;
        }

        private void button87_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button87.Text;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string value = searchTextBox.Text;
        
            //char[] val = value.ToCharArray();
            //char[]va=new char[val.Count()+2];
            //int falg = 0;
            //if(value.Length==val.Count())
            //{
            //    for (int i = 0; i < val.Count(); i++)
            //    {
            //        if (val[i] == '\r' || val[i] == '\n')
            //        {
            //            falg = 1;
            //          continue; 
            //        }
            //        va[i] = val[i];
            //    }
            //    if(falg==0)
            //    {
            //        va[val.Count()] = '\r';
            //        va[val.Count() + 1] = '\n';
            //    }
            
            //}
            //string mm = "";
            //if(falg==1)
            //{
            //    mm = value;
            //}
            //else
            //{
            //    mm = new string(va);
            //}
         
            var data = wordList.Where(s => s.Bn.Equals(value)).ToList();
            if (searchTextBox.Text == "")
            {
                MessageBox.Show("Please type something .", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (data.Count > 0)
            {

                dataGridView.DataSource =data ;
                dataGridView.Columns[0].Visible = false;
            }
            else
            {
                dataGridView.DataSource = null;
            
                MessageBox.Show("No data Found .", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Trim() == "")
            {
                dataGridView.DataSource = null;
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button74.Text;
        }

        private void button77_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button77.Text;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button75.Text;
        }

        private void button78_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button78.Text;
        }

        private void button76_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button76.Text;
        }

        private void button80_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button80.Text;
        }

        private void button85_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button85.Text;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button79.Text;
        }

        private void button81_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button81.Text;
        }

        private void button91_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button91.Text;
        }

        private void button89_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button89.Text;
        }

        private void button90_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button90.Text;
        }

        private void button92_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button92.Text;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button60.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button22.Text;
        }

        private void button66_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button66.Text;
        }

        private void button60_Click_1(object sender, EventArgs e)
        {
            searchTextBox.Text += button60.Text;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button59.Text;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button51.Text;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button57.Text;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button53.Text;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button46.Text;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button58.Text;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button56.Text;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button48.Text;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button54.Text;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button50.Text;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button45.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button13.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button11.Text;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button39.Text;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button32.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button23.Text;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button42.Text;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button33.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button25.Text;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button38.Text;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button31.Text;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button55.Text;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button44.Text;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button37.Text;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button49.Text;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button41.Text;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button35.Text;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button52.Text;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button43.Text;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button36.Text;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button47.Text;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button40.Text;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button34.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button30.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button21.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button17.Text;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button28.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button18.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button14.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button29.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button16.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button26.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button10.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button20.Text;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button27.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button15.Text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button24.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button9.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button19.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button7.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button6.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button8.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button4.Text;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button63.Text;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button61.Text;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button62.Text;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button64.Text;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button65.Text;
        }

        private void button67_Click(object sender, EventArgs e)
        {
            searchTextBox.Text += button67.Text;
        }
    }
}
