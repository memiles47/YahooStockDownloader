namespace YahooStockDownloader
{
    partial class frm_FormList
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
            this.lbl_SearchFor = new System.Windows.Forms.Label();
            this.tb_SearchFor = new System.Windows.Forms.TextBox();
            this.lst_FileList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_SearchFor
            // 
            this.lbl_SearchFor.AutoSize = true;
            this.lbl_SearchFor.Location = new System.Drawing.Point(13, 13);
            this.lbl_SearchFor.Name = "lbl_SearchFor";
            this.lbl_SearchFor.Size = new System.Drawing.Size(92, 20);
            this.lbl_SearchFor.TabIndex = 0;
            this.lbl_SearchFor.Text = "Search For:";
            // 
            // tb_SearchFor
            // 
            this.tb_SearchFor.Location = new System.Drawing.Point(112, 13);
            this.tb_SearchFor.Name = "tb_SearchFor";
            this.tb_SearchFor.Size = new System.Drawing.Size(450, 26);
            this.tb_SearchFor.TabIndex = 1;
            this.tb_SearchFor.TextChanged += new System.EventHandler(this.tb_SearchFor_TextChanged);
            // 
            // lst_FileList
            // 
            this.lst_FileList.FormattingEnabled = true;
            this.lst_FileList.ItemHeight = 20;
            this.lst_FileList.Location = new System.Drawing.Point(17, 64);
            this.lst_FileList.Name = "lst_FileList";
            this.lst_FileList.Size = new System.Drawing.Size(545, 564);
            this.lst_FileList.TabIndex = 2;
            this.lst_FileList.SelectedIndexChanged += new System.EventHandler(this.lst_FileList_SelectedIndexChanged);
            // 
            // frm_FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 658);
            this.Controls.Add(this.lst_FileList);
            this.Controls.Add(this.tb_SearchFor);
            this.Controls.Add(this.lbl_SearchFor);
            this.Name = "frm_FormList";
            this.Text = "CSV Files Available";
            this.Load += new System.EventHandler(this.frm_FormList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SearchFor;
        private System.Windows.Forms.TextBox tb_SearchFor;
        private System.Windows.Forms.ListBox lst_FileList;
    }
}