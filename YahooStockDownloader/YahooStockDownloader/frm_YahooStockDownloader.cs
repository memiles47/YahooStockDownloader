using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahooStockDownloader
{
    public partial class frm_YahooStockDownloader : Form
    {
        string folder = "";
        string interval = "";

        public frm_YahooStockDownloader()
        {
            InitializeComponent();
            folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            tb_FolderPath.Text = folder;
            cmb_StartMonth.SelectedIndex = 0;
            cmb_EndMonth.SelectedIndex = 0;
            interval = "d";
        }
    }
}
