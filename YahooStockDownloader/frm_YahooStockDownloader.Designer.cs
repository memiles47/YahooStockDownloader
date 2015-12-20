namespace YahooStockDownloader
{
    partial class btn_BrowsePath
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
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.dlComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dow30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sP100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasdaq100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_FolderPath = new System.Windows.Forms.Label();
            this.tb_FolderPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_StateDate = new System.Windows.Forms.Label();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.cmb_StartMonth = new System.Windows.Forms.ComboBox();
            this.cmb_EndMonth = new System.Windows.Forms.ComboBox();
            this.nud_StartDay = new System.Windows.Forms.NumericUpDown();
            this.nud_EndDay = new System.Windows.Forms.NumericUpDown();
            this.nud_StartYear = new System.Windows.Forms.NumericUpDown();
            this.nud_EndYear = new System.Windows.Forms.NumericUpDown();
            this.rb_Daily = new System.Windows.Forms.RadioButton();
            this.rb_Weekly = new System.Windows.Forms.RadioButton();
            this.rb_Monthly = new System.Windows.Forms.RadioButton();
            this.btn_Download = new System.Windows.Forms.Button();
            this.txt_Ticker = new System.Windows.Forms.TextBox();
            this.lbl_Tickers = new System.Windows.Forms.Label();
            this.mnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_StartDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EndDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_StartYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EndYear)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dlComponentsToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(979, 33);
            this.mnuStrip.TabIndex = 0;
            this.mnuStrip.Text = "menuStrip1";
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
            this.dow30ToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.dow30ToolStripMenuItem.Text = "Dow 30";
            // 
            // sP100ToolStripMenuItem
            // 
            this.sP100ToolStripMenuItem.Name = "sP100ToolStripMenuItem";
            this.sP100ToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.sP100ToolStripMenuItem.Text = "S&&P 100";
            // 
            // nasdaq100ToolStripMenuItem
            // 
            this.nasdaq100ToolStripMenuItem.Name = "nasdaq100ToolStripMenuItem";
            this.nasdaq100ToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.nasdaq100ToolStripMenuItem.Text = "Nasdaq 100";
            // 
            // lbl_FolderPath
            // 
            this.lbl_FolderPath.AutoSize = true;
            this.lbl_FolderPath.Location = new System.Drawing.Point(52, 62);
            this.lbl_FolderPath.Name = "lbl_FolderPath";
            this.lbl_FolderPath.Size = new System.Drawing.Size(91, 20);
            this.lbl_FolderPath.TabIndex = 1;
            this.lbl_FolderPath.Text = "Folder Path";
            // 
            // tb_FolderPath
            // 
            this.tb_FolderPath.Location = new System.Drawing.Point(181, 62);
            this.tb_FolderPath.Name = "tb_FolderPath";
            this.tb_FolderPath.Size = new System.Drawing.Size(598, 26);
            this.tb_FolderPath.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_StateDate
            // 
            this.lbl_StateDate.AutoSize = true;
            this.lbl_StateDate.Location = new System.Drawing.Point(52, 129);
            this.lbl_StateDate.Name = "lbl_StateDate";
            this.lbl_StateDate.Size = new System.Drawing.Size(87, 20);
            this.lbl_StateDate.TabIndex = 4;
            this.lbl_StateDate.Text = "Start Date:";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(52, 199);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(81, 20);
            this.lbl_EndDate.TabIndex = 5;
            this.lbl_EndDate.Text = "End Date:";
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
            this.cmb_StartMonth.Location = new System.Drawing.Point(181, 129);
            this.cmb_StartMonth.Name = "cmb_StartMonth";
            this.cmb_StartMonth.Size = new System.Drawing.Size(121, 28);
            this.cmb_StartMonth.TabIndex = 6;
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
            this.cmb_EndMonth.Location = new System.Drawing.Point(181, 199);
            this.cmb_EndMonth.Name = "cmb_EndMonth";
            this.cmb_EndMonth.Size = new System.Drawing.Size(121, 28);
            this.cmb_EndMonth.TabIndex = 7;
            // 
            // nud_StartDay
            // 
            this.nud_StartDay.Location = new System.Drawing.Point(355, 131);
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
            this.nud_StartDay.TabIndex = 8;
            this.nud_StartDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_EndDay
            // 
            this.nud_EndDay.Location = new System.Drawing.Point(355, 200);
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
            this.nud_EndDay.TabIndex = 9;
            this.nud_EndDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_StartYear
            // 
            this.nud_StartYear.Location = new System.Drawing.Point(527, 130);
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
            this.nud_StartYear.TabIndex = 10;
            this.nud_StartYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nud_EndYear
            // 
            this.nud_EndYear.Location = new System.Drawing.Point(527, 200);
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
            this.nud_EndYear.TabIndex = 11;
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
            this.rb_Daily.Location = new System.Drawing.Point(674, 129);
            this.rb_Daily.Name = "rb_Daily";
            this.rb_Daily.Size = new System.Drawing.Size(68, 24);
            this.rb_Daily.TabIndex = 12;
            this.rb_Daily.TabStop = true;
            this.rb_Daily.Text = "Daily";
            this.rb_Daily.UseVisualStyleBackColor = true;
            this.rb_Daily.CheckedChanged += new System.EventHandler(this.rb_Daily_CheckedChanged);
            // 
            // rb_Weekly
            // 
            this.rb_Weekly.AutoSize = true;
            this.rb_Weekly.Location = new System.Drawing.Point(674, 165);
            this.rb_Weekly.Name = "rb_Weekly";
            this.rb_Weekly.Size = new System.Drawing.Size(85, 24);
            this.rb_Weekly.TabIndex = 13;
            this.rb_Weekly.TabStop = true;
            this.rb_Weekly.Text = "Weekly";
            this.rb_Weekly.UseVisualStyleBackColor = true;
            // 
            // rb_Monthly
            // 
            this.rb_Monthly.AutoSize = true;
            this.rb_Monthly.Location = new System.Drawing.Point(674, 203);
            this.rb_Monthly.Name = "rb_Monthly";
            this.rb_Monthly.Size = new System.Drawing.Size(89, 24);
            this.rb_Monthly.TabIndex = 14;
            this.rb_Monthly.TabStop = true;
            this.rb_Monthly.Text = "Monthly";
            this.rb_Monthly.UseVisualStyleBackColor = true;
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(820, 165);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(105, 29);
            this.btn_Download.TabIndex = 15;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            // 
            // txt_Ticker
            // 
            this.txt_Ticker.Location = new System.Drawing.Point(181, 276);
            this.txt_Ticker.Multiline = true;
            this.txt_Ticker.Name = "txt_Ticker";
            this.txt_Ticker.Size = new System.Drawing.Size(466, 141);
            this.txt_Ticker.TabIndex = 16;
            this.txt_Ticker.Text = "GOOG,AAPL,AMZN";
            // 
            // lbl_Tickers
            // 
            this.lbl_Tickers.AutoSize = true;
            this.lbl_Tickers.Location = new System.Drawing.Point(52, 276);
            this.lbl_Tickers.Name = "lbl_Tickers";
            this.lbl_Tickers.Size = new System.Drawing.Size(115, 20);
            this.lbl_Tickers.TabIndex = 17;
            this.lbl_Tickers.Text = "Ticker Symbols";
            // 
            // btn_BrowsePath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 453);
            this.Controls.Add(this.lbl_Tickers);
            this.Controls.Add(this.txt_Ticker);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.rb_Monthly);
            this.Controls.Add(this.rb_Weekly);
            this.Controls.Add(this.rb_Daily);
            this.Controls.Add(this.nud_EndYear);
            this.Controls.Add(this.nud_StartYear);
            this.Controls.Add(this.nud_EndDay);
            this.Controls.Add(this.nud_StartDay);
            this.Controls.Add(this.cmb_EndMonth);
            this.Controls.Add(this.cmb_StartMonth);
            this.Controls.Add(this.lbl_EndDate);
            this.Controls.Add(this.lbl_StateDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_FolderPath);
            this.Controls.Add(this.lbl_FolderPath);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "btn_BrowsePath";
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

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem dlComponentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dow30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sP100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nasdaq100ToolStripMenuItem;
        private System.Windows.Forms.Label lbl_FolderPath;
        private System.Windows.Forms.TextBox tb_FolderPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_StateDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.ComboBox cmb_StartMonth;
        private System.Windows.Forms.ComboBox cmb_EndMonth;
        private System.Windows.Forms.NumericUpDown nud_StartDay;
        private System.Windows.Forms.NumericUpDown nud_EndDay;
        private System.Windows.Forms.NumericUpDown nud_StartYear;
        private System.Windows.Forms.NumericUpDown nud_EndYear;
        private System.Windows.Forms.RadioButton rb_Daily;
        private System.Windows.Forms.RadioButton rb_Weekly;
        private System.Windows.Forms.RadioButton rb_Monthly;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.TextBox txt_Ticker;
        private System.Windows.Forms.Label lbl_Tickers;
    }
}

