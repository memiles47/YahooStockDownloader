namespace YahooStockDownloader
{
    partial class frm_YahooStockDownloader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_FolderPath = new System.Windows.Forms.Label();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.dlComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dow30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sP100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasdaq100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.tb_FolderPath = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.cmb_StartMonth = new System.Windows.Forms.ComboBox();
            this.cmb_EndMonth = new System.Windows.Forms.ComboBox();
            this.nud_StartDay = new System.Windows.Forms.NumericUpDown();
            this.nud_EndDay = new System.Windows.Forms.NumericUpDown();
            this.nud_StartYear = new System.Windows.Forms.NumericUpDown();
            this.nud_EndYear = new System.Windows.Forms.NumericUpDown();
            this.rb_Daily = new System.Windows.Forms.RadioButton();
            this.rb_Monthly = new System.Windows.Forms.RadioButton();
            this.rb_Weekly = new System.Windows.Forms.RadioButton();
            this.btn_Download = new System.Windows.Forms.Button();
            this.tb_TickerSymbols = new System.Windows.Forms.TextBox();
            this.lbl_TickerSymbols = new System.Windows.Forms.Label();
            this.dlg_FileBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_ClearSymbols = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_StartDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EndDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_StartYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EndYear)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FolderPath
            // 
            this.lbl_FolderPath.AutoSize = true;
            this.lbl_FolderPath.Location = new System.Drawing.Point(40, 80);
            this.lbl_FolderPath.Name = "lbl_FolderPath";
            this.lbl_FolderPath.Size = new System.Drawing.Size(91, 20);
            this.lbl_FolderPath.TabIndex = 1;
            this.lbl_FolderPath.Text = "Folder Path";
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dlComponentsToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(1007, 33);
            this.mnuStrip.TabIndex = 2;
            this.mnuStrip.Text = "menuStrip2";
            // 
            // dlComponentsToolStripMenuItem
            // 
            this.dlComponentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dow30ToolStripMenuItem,
            this.sP100ToolStripMenuItem,
            this.nasdaq100ToolStripMenuItem});
            this.dlComponentsToolStripMenuItem.Name = "dlComponentsToolStripMenuItem";
            this.dlComponentsToolStripMenuItem.Size = new System.Drawing.Size(175, 29);
            this.dlComponentsToolStripMenuItem.Text = "Index Components";
            // 
            // dow30ToolStripMenuItem
            // 
            this.dow30ToolStripMenuItem.Name = "dow30ToolStripMenuItem";
            this.dow30ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.dow30ToolStripMenuItem.Text = "Dow 30";
            this.dow30ToolStripMenuItem.Click += new System.EventHandler(this.dow30ToolStripMenuItem_Click);
            // 
            // sP100ToolStripMenuItem
            // 
            this.sP100ToolStripMenuItem.Name = "sP100ToolStripMenuItem";
            this.sP100ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.sP100ToolStripMenuItem.Text = "S&&P 100";
            this.sP100ToolStripMenuItem.Click += new System.EventHandler(this.sP100ToolStripMenuItem_Click);
            // 
            // nasdaq100ToolStripMenuItem
            // 
            this.nasdaq100ToolStripMenuItem.Name = "nasdaq100ToolStripMenuItem";
            this.nasdaq100ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.nasdaq100ToolStripMenuItem.Text = "Nasdaq 100";
            this.nasdaq100ToolStripMenuItem.Click += new System.EventHandler(this.nasdaq100ToolStripMenuItem_Click);
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(40, 148);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(87, 20);
            this.lbl_StartDate.TabIndex = 3;
            this.lbl_StartDate.Text = "Start Date:";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(40, 223);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(81, 20);
            this.lbl_EndDate.TabIndex = 4;
            this.lbl_EndDate.Text = "End Date:";
            // 
            // tb_FolderPath
            // 
            this.tb_FolderPath.Location = new System.Drawing.Point(181, 80);
            this.tb_FolderPath.Name = "tb_FolderPath";
            this.tb_FolderPath.Size = new System.Drawing.Size(625, 26);
            this.tb_FolderPath.TabIndex = 5;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(830, 80);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(100, 30);
            this.btn_Browse.TabIndex = 6;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // cmb_StartMonth
            // 
            this.cmb_StartMonth.FormattingEnabled = true;
            this.cmb_StartMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cmb_StartMonth.Location = new System.Drawing.Point(181, 148);
            this.cmb_StartMonth.Name = "cmb_StartMonth";
            this.cmb_StartMonth.Size = new System.Drawing.Size(121, 28);
            this.cmb_StartMonth.TabIndex = 7;
            // 
            // cmb_EndMonth
            // 
            this.cmb_EndMonth.FormattingEnabled = true;
            this.cmb_EndMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cmb_EndMonth.Location = new System.Drawing.Point(181, 223);
            this.cmb_EndMonth.Name = "cmb_EndMonth";
            this.cmb_EndMonth.Size = new System.Drawing.Size(121, 28);
            this.cmb_EndMonth.TabIndex = 8;
            // 
            // nud_StartDay
            // 
            this.nud_StartDay.Location = new System.Drawing.Point(351, 148);
            this.nud_StartDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nud_StartDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_StartDay.Name = "nud_StartDay";
            this.nud_StartDay.Size = new System.Drawing.Size(120, 26);
            this.nud_StartDay.TabIndex = 9;
            this.nud_StartDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_EndDay
            // 
            this.nud_EndDay.Location = new System.Drawing.Point(351, 223);
            this.nud_EndDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nud_EndDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_EndDay.Name = "nud_EndDay";
            this.nud_EndDay.Size = new System.Drawing.Size(120, 26);
            this.nud_EndDay.TabIndex = 10;
            this.nud_EndDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_StartYear
            // 
            this.nud_StartYear.Location = new System.Drawing.Point(527, 148);
            this.nud_StartYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nud_StartYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nud_StartYear.Name = "nud_StartYear";
            this.nud_StartYear.Size = new System.Drawing.Size(120, 26);
            this.nud_StartYear.TabIndex = 11;
            this.nud_StartYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nud_EndYear
            // 
            this.nud_EndYear.Location = new System.Drawing.Point(527, 223);
            this.nud_EndYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nud_EndYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nud_EndYear.Name = "nud_EndYear";
            this.nud_EndYear.Size = new System.Drawing.Size(120, 26);
            this.nud_EndYear.TabIndex = 12;
            this.nud_EndYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // rb_Daily
            // 
            this.rb_Daily.AutoSize = true;
            this.rb_Daily.Checked = true;
            this.rb_Daily.Location = new System.Drawing.Point(717, 159);
            this.rb_Daily.Name = "rb_Daily";
            this.rb_Daily.Size = new System.Drawing.Size(68, 24);
            this.rb_Daily.TabIndex = 13;
            this.rb_Daily.TabStop = true;
            this.rb_Daily.Text = "Daily";
            this.rb_Daily.UseVisualStyleBackColor = true;
            // 
            // rb_Monthly
            // 
            this.rb_Monthly.AutoSize = true;
            this.rb_Monthly.Location = new System.Drawing.Point(717, 219);
            this.rb_Monthly.Name = "rb_Monthly";
            this.rb_Monthly.Size = new System.Drawing.Size(89, 24);
            this.rb_Monthly.TabIndex = 14;
            this.rb_Monthly.Text = "Monthly";
            this.rb_Monthly.UseVisualStyleBackColor = true;
            // 
            // rb_Weekly
            // 
            this.rb_Weekly.AutoSize = true;
            this.rb_Weekly.Location = new System.Drawing.Point(717, 189);
            this.rb_Weekly.Name = "rb_Weekly";
            this.rb_Weekly.Size = new System.Drawing.Size(85, 24);
            this.rb_Weekly.TabIndex = 15;
            this.rb_Weekly.Text = "Weekly";
            this.rb_Weekly.UseVisualStyleBackColor = true;
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(830, 159);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(100, 30);
            this.btn_Download.TabIndex = 16;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // tb_TickerSymbols
            // 
            this.tb_TickerSymbols.Location = new System.Drawing.Point(181, 305);
            this.tb_TickerSymbols.Multiline = true;
            this.tb_TickerSymbols.Name = "tb_TickerSymbols";
            this.tb_TickerSymbols.Size = new System.Drawing.Size(466, 196);
            this.tb_TickerSymbols.TabIndex = 17;
            this.tb_TickerSymbols.Text = "GOOG,AAPL,AMZN";
            // 
            // lbl_TickerSymbols
            // 
            this.lbl_TickerSymbols.AutoSize = true;
            this.lbl_TickerSymbols.Location = new System.Drawing.Point(40, 305);
            this.lbl_TickerSymbols.Name = "lbl_TickerSymbols";
            this.lbl_TickerSymbols.Size = new System.Drawing.Size(119, 20);
            this.lbl_TickerSymbols.TabIndex = 18;
            this.lbl_TickerSymbols.Text = "Ticker Symbols:";
            // 
            // btn_ClearSymbols
            // 
            this.btn_ClearSymbols.Location = new System.Drawing.Point(44, 337);
            this.btn_ClearSymbols.Name = "btn_ClearSymbols";
            this.btn_ClearSymbols.Size = new System.Drawing.Size(127, 30);
            this.btn_ClearSymbols.TabIndex = 19;
            this.btn_ClearSymbols.Text = "Clear Symbols";
            this.btn_ClearSymbols.UseVisualStyleBackColor = true;
            this.btn_ClearSymbols.Click += new System.EventHandler(this.btn_ClearSymbols_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frm_YahooStockDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 528);
            this.Controls.Add(this.btn_ClearSymbols);
            this.Controls.Add(this.lbl_TickerSymbols);
            this.Controls.Add(this.tb_TickerSymbols);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.rb_Weekly);
            this.Controls.Add(this.rb_Monthly);
            this.Controls.Add(this.rb_Daily);
            this.Controls.Add(this.nud_EndYear);
            this.Controls.Add(this.nud_StartYear);
            this.Controls.Add(this.nud_EndDay);
            this.Controls.Add(this.nud_StartDay);
            this.Controls.Add(this.cmb_EndMonth);
            this.Controls.Add(this.cmb_StartMonth);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.tb_FolderPath);
            this.Controls.Add(this.lbl_EndDate);
            this.Controls.Add(this.lbl_StartDate);
            this.Controls.Add(this.lbl_FolderPath);
            this.Controls.Add(this.mnuStrip);
            this.Name = "frm_YahooStockDownloader";
            this.Text = "Yahoo Stock Downloader";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_StartDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EndDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_StartYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EndYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FolderPath;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem dlComponentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dow30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sP100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nasdaq100ToolStripMenuItem;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.TextBox tb_FolderPath;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.ComboBox cmb_StartMonth;
        private System.Windows.Forms.ComboBox cmb_EndMonth;
        private System.Windows.Forms.NumericUpDown nud_StartDay;
        private System.Windows.Forms.NumericUpDown nud_EndDay;
        private System.Windows.Forms.NumericUpDown nud_StartYear;
        private System.Windows.Forms.NumericUpDown nud_EndYear;
        private System.Windows.Forms.RadioButton rb_Daily;
        private System.Windows.Forms.RadioButton rb_Monthly;
        private System.Windows.Forms.RadioButton rb_Weekly;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.TextBox tb_TickerSymbols;
        private System.Windows.Forms.Label lbl_TickerSymbols;
        private System.Windows.Forms.FolderBrowserDialog dlg_FileBrowser;
        private System.Windows.Forms.Button btn_ClearSymbols;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

