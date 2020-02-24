using SearchFileApplication.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFileApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(PathTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please select a Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            //List<string> list = new List<string>();
            //SearchIO.GetAllDirectories("E:\\", ref list);

            //List<string> allFiles = SearchIO.SearchFile(PathTextBox.Text);
            //ResultListBox.Items.AddRange(allFiles.ToArray());
            ResultListView.Items.Clear();


            //List<string> allFiles = SearchIO.SearchFile(PathTextBox.Text , ExtensionTextBox.Text);
            //ResultListBox.Items.AddRange(allFiles.ToArray());
            SearchFileNameOption opt = MatchCaseRadioButton.Checked ? SearchFileNameOption.MatchCase :
                                        WholeWordRadioButton.Checked ? SearchFileNameOption.WholeWord :
                                        SearchFileNameOption.Normal;
            List<string> allFiles = new List<string>();
            if (string.IsNullOrEmpty(NameTextBox.Text) && string.IsNullOrEmpty(ExtensionTextBox.Text))
                allFiles = SearchIO.SearchFile(PathTextBox.Text);
            
            else
                allFiles = SearchIO.SearchFile(PathTextBox.Text, NameTextBox.Text, opt, ExtensionTextBox.Text);
            //ResultListBox.Items.AddRange(allFiles.ToArray());


            foreach (string fileName in allFiles)
            {
                ListViewItem item = new ListViewItem()
                {
                    Text = Path.GetFileName(fileName),
                    ImageIndex = 0

                };
                ResultListView.Items.Add(item);
            }






        }

        private void ViewComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResultListView.View =   ViewComboBox.SelectedIndex == 0 ? View.LargeIcon :
                                    ViewComboBox.SelectedIndex == 1 ? View.SmallIcon :
                                    ViewComboBox.SelectedIndex == 2 ? View.List :
                                     View.LargeIcon;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.Cancel)
                return;
            PathTextBox.Text = fbd.SelectedPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ViewComboBox.SelectedIndex = 0;
        }
    }
}


