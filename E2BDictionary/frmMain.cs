using E2BWordBank;
using System.Diagnostics;
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
                        if (rowIndex < 100)
                        {
                            wordGridView.FirstDisplayedScrollingRowIndex = rowIndex;
                        }
                        else
                        {
                            wordGridView.FirstDisplayedScrollingRowIndex = rowIndex - 10;
                        }

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
                frmFindEnglish frm = new frmFindEnglish();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://www.youtube.com/programmingpalli") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://www.facebook.com/programmingpalli") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://github.com/faisalcse1/E2B_Dictionary") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nugetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://www.nuget.org/packages/E2BWordBank") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                About about = new About();
                about.ShowDialog(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
