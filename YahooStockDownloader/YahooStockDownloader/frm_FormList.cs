using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace YahooStockDownloader
{
    public partial class frm_FormList : Form
    {
        string folderPath = "";

        public frm_FormList(string folder)
        {
            InitializeComponent();
            folderPath = folder;
        }

        private void frm_FormList_Load(object sender, EventArgs e)
        {
            string[] csvFiles = Directory.GetFiles(folderPath, "*.csv");
            lst_FileList.Items.AddRange(csvFiles);
        }

        private void lst_FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_FileList.SelectedItem != null)
            {
                Process.Start("notepad.exe", lst_FileList.SelectedItem.ToString());
            }
        }

        private void tb_SearchFor_TextChanged(object sender, EventArgs e)
        {
            lst_FileList.Items.Clear();
            List<string> allPathFiles = Directory.GetFiles(folderPath, "*.csv").ToList();

            var onlySomeFiles = allPathFiles.Where(x => Path.GetFileNameWithoutExtension(x)
                .Contains(tb_SearchFor.Text.ToUpper()));

            //show reduced file set in list box
            lst_FileList.Items.AddRange(onlySomeFiles.ToArray());
        }
    }
}
