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

namespace SearchDirectoriesAndFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();
            if (fld.ShowDialog() == DialogResult.Cancel)
                return;
            TxtBrowseName.Text = fld.SelectedPath;
        }

        private SearchDirectoriesAndFiles.SearchFileNameOption SearchOption()
        {
            SearchDirectoriesAndFiles.SearchFileNameOption option = SearchDirectoriesAndFiles.SearchFileNameOption.None;
            if (TxtName.Text !=string.Empty)
                {
                if (radioBtnMachCase.Checked)
                    option = SearchDirectoriesAndFiles.SearchFileNameOption.MatchCase;
                else if (radioBtnWholeName.Checked)
                    option = SearchDirectoriesAndFiles.SearchFileNameOption.WholeWord;
                else
                    option = SearchDirectoriesAndFiles.SearchFileNameOption.Normal;
            }
            return option;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<string> resultSaerch = new List<string>();
            listViewResult.Clear();
            if (checkBoxDirectories.Checked)
            {
                SearchDirectoriesAndFiles.GetDirectories(TxtBrowseName.Text, ref resultSaerch, checkBoxHiddenItem.Checked, checkBoxReadOnly.Checked, TxtName.Text, SearchOption());
                foreach (string dir in resultSaerch)
                {
                    listViewResult.Items.Add(Path.GetFileName(dir));
                }
            }

            else if (checkBoxSearchFiles.Checked)
            {
                SearchDirectoriesAndFiles.GetFiles(TxtBrowseName.Text, ref resultSaerch, TxtName.Text, SearchOption());
                //SearchDirectoriesAndFiles.GetFiles(TxtBrowseName.Text, ref resultSaerch, checkBoxHiddenItem.Checked, checkBoxReadOnly.Checked, TxtExtention.Text);
                foreach (string file in resultSaerch)
                {
                    listViewResult.Items.Add(Path.GetFileName(file));
                }
            }

        }
        }
    }
