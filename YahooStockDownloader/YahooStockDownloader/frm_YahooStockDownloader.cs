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
            dlg_FileBrowser.SelectedPath = folder;
            cmb_StartMonth.SelectedIndex = 0;
            cmb_EndMonth.SelectedIndex = 0;
            interval = "d";

            SetCurrentDate();
        }

        private void SetCurrentDate()
        {
            DateTime todaysDate = DateTime.Today;
            cmb_EndMonth.SelectedIndex = todaysDate.Month - 1;
            nud_EndDay.Value = todaysDate.Day;
            nud_EndYear.Value = todaysDate.Year;
            nud_StartYear.Value = todaysDate.Year;
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            DialogResult result = dlg_FileBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_FolderPath.Text = dlg_FileBrowser.SelectedPath;
                folder = dlg_FileBrowser.SelectedPath;
            }
        }

        private bool DatesVerified()
        {
            try
            {
                DateTime startDate = new DateTime((int)nud_StartYear.Value, 
                    (int)cmb_StartMonth.SelectedIndex + 1, (int)nud_StartDay.Value);
                DateTime endDate = new DateTime((int)nud_EndYear.Value,
                    (int)cmb_EndMonth.SelectedIndex + 1, (int)nud_EndDay.Value);

                if (endDate < startDate)
                {
                    MessageBox.Show("End Date can not be earlier than Start Date");
                    return false;
                }
                else if (endDate > DateTime.Now)
                {
                    MessageBox.Show("End Date can not be beyond Todays date");
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Please enter valid date");
                return false;
            }
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tb_FolderPath.Text))
            {
                MessageBox.Show("Please enter a valid path");
                return;
            }

            if (tb_TickerSymbols.Text == "")
            {
                MessageBox.Show("Please enter Ticker Symbol");
                return;
            }

            if (DatesVerified())
            {
                string tickers = tb_TickerSymbols.Text;
                bool result = tickers.All((c => char.IsLetter(c) || c == ',' || c == ' '));
                if (!result)
                {
                    MessageBox.Show("Please enter only commas and letters: " + Environment.NewLine + "GOOG,AMZN,MSFT");
                    return;
                }

                SetInterval();

                string[] symbols = Helpers.SplitTickers(tickers);

                foreach (string symbol in symbols)
                {
                    //Constructs Yahoo's URL to request data from
                    string path = Path.Combine(folder, symbol + ".csv");
                    string url = "http://real-chart.finance.yahoo.com/table.csv?s=" + symbol + "&a=" +
                        cmb_StartMonth.SelectedIndex + "&b" + nud_StartDay.Value + "&c" + nud_StartYear.Value +
                        "&d" + cmb_EndMonth.SelectedIndex + "&e" + nud_EndDay.Value + "&f" + nud_EndYear.Value +
                        "&g" + interval + "&ignore.csv";

                    try
                    {
                        Helpers.DownloadSymbolsToCSV(url, path, folder, symbol);
                    }
                    catch
                    {

                        MessageBox.Show("Could not locate symbol " + symbol);
                    }
                }

                frm_FormList filelist = new frm_FormList(folder);
                filelist.Show();
            }
        }

        private void SetInterval()
        {
            if (rb_Daily.Checked)
            {
                interval = "d";
            }

            if (rb_Weekly.Checked)
            {
                interval = "w";
            }

            if (rb_Monthly.Checked)
            {
                interval = "m";
            }
        }
    }
}
