using E2BWordBank;
using System.Runtime.InteropServices;

namespace E2BDictionary
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        List<Word> wordList = WordRepository.GetAllWords();
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                wordGridView.Rows.Clear();
                wordGridView.AutoGenerateColumns = false;
                wordGridView.DataSource = wordList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findWordTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchValue = findWordTextBox.Text;
                wordGridView.ClearSelection();
                if (searchValue.Trim() == string.Empty)
                {
                    wordGridView.DataSource = null;
                    //wordGridView.Rows.Clear();
                    wordGridView.DataSource = wordList;
                }
                else
                {
                    int rowIndex = 0;
                    var words = (List<Word>)wordGridView.DataSource;
                    var word = words.FirstOrDefault(c => c.En.ToLower().StartsWith(searchValue.ToLower()));
                    if (word != null)
                    {
                        rowIndex = words.IndexOf(word);
                        wordGridView.Rows[rowIndex].Selected = true;
                        wordGridView.FirstDisplayedScrollingRowIndex = rowIndex;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findBanglaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFindBangla frm = new frmFindBangla();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findEnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFindBangla frm = new frmFindBangla();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
