namespace TI.ReportPlus.GUI
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.btn_QuickLink = new System.Windows.Forms.Button();
            this.cb_catalogs = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbox_Quicklink = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Printer = new System.Windows.Forms.Button();
            this.timePicker_Printer = new System.Windows.Forms.DateTimePicker();
            this.datePicker_Printer = new System.Windows.Forms.DateTimePicker();
            this.cb_printers = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_PDF = new System.Windows.Forms.Button();
            this.timePicker_PDF = new System.Windows.Forms.DateTimePicker();
            this.datePicker_PDF = new System.Windows.Forms.DateTimePicker();
            this.btn_CreateALL = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timerStatusLabel = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.txt_Printer_Interval = new System.Windows.Forms.TextBox();
            this.txt_PDF_Interval = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.grpbox_Quicklink.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_QuickLink
            // 
            this.btn_QuickLink.Location = new System.Drawing.Point(57, 127);
            this.btn_QuickLink.Name = "btn_QuickLink";
            this.btn_QuickLink.Size = new System.Drawing.Size(75, 23);
            this.btn_QuickLink.TabIndex = 1;
            this.btn_QuickLink.Text = "Create";
            this.btn_QuickLink.UseVisualStyleBackColor = true;
            this.btn_QuickLink.Click += new System.EventHandler(this.btn_QuickLink_Click);
            // 
            // cb_catalogs
            // 
            this.cb_catalogs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_catalogs.FormattingEnabled = true;
            this.cb_catalogs.Location = new System.Drawing.Point(6, 46);
            this.cb_catalogs.Name = "cb_catalogs";
            this.cb_catalogs.Size = new System.Drawing.Size(199, 21);
            this.cb_catalogs.TabIndex = 0;
            this.cb_catalogs.SelectedIndexChanged += new System.EventHandler(this.cb_catalogs_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // grpbox_Quicklink
            // 
            this.grpbox_Quicklink.AutoSize = true;
            this.grpbox_Quicklink.Controls.Add(this.cb_catalogs);
            this.grpbox_Quicklink.Controls.Add(this.btn_QuickLink);
            this.grpbox_Quicklink.Location = new System.Drawing.Point(3, 3);
            this.grpbox_Quicklink.Name = "grpbox_Quicklink";
            this.grpbox_Quicklink.Size = new System.Drawing.Size(211, 169);
            this.grpbox_Quicklink.TabIndex = 3;
            this.grpbox_Quicklink.TabStop = false;
            this.grpbox_Quicklink.Text = "Quick Links";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txt_Printer_Interval);
            this.groupBox1.Controls.Add(this.btn_Printer);
            this.groupBox1.Controls.Add(this.timePicker_Printer);
            this.groupBox1.Controls.Add(this.datePicker_Printer);
            this.groupBox1.Controls.Add(this.cb_printers);
            this.groupBox1.Location = new System.Drawing.Point(220, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 169);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subscriptions - Printer";
            // 
            // btn_Printer
            // 
            this.btn_Printer.Location = new System.Drawing.Point(49, 127);
            this.btn_Printer.Name = "btn_Printer";
            this.btn_Printer.Size = new System.Drawing.Size(75, 23);
            this.btn_Printer.TabIndex = 2;
            this.btn_Printer.Text = "Create";
            this.btn_Printer.UseVisualStyleBackColor = true;
            this.btn_Printer.Click += new System.EventHandler(this.btn_Printer_Click);
            // 
            // timePicker_Printer
            // 
            this.timePicker_Printer.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker_Printer.Location = new System.Drawing.Point(25, 99);
            this.timePicker_Printer.Name = "timePicker_Printer";
            this.timePicker_Printer.ShowUpDown = true;
            this.timePicker_Printer.Size = new System.Drawing.Size(74, 20);
            this.timePicker_Printer.TabIndex = 1;
            this.timePicker_Printer.Value = new System.DateTime(2016, 4, 4, 6, 0, 0, 0);
            // 
            // datePicker_Printer
            // 
            this.datePicker_Printer.Location = new System.Drawing.Point(25, 73);
            this.datePicker_Printer.Name = "datePicker_Printer";
            this.datePicker_Printer.Size = new System.Drawing.Size(143, 20);
            this.datePicker_Printer.TabIndex = 1;
            // 
            // cb_printers
            // 
            this.cb_printers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_printers.FormattingEnabled = true;
            this.cb_printers.Location = new System.Drawing.Point(6, 46);
            this.cb_printers.Name = "cb_printers";
            this.cb_printers.Size = new System.Drawing.Size(184, 21);
            this.cb_printers.TabIndex = 0;
            this.cb_printers.SelectedIndexChanged += new System.EventHandler(this.cb_printers_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 268);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(638, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            this.toolStripStatusLabel.TextChanged += new System.EventHandler(this.toolStripStatusLabel_TextChanged);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Step = 1;
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.toolStripProgressBar.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.grpbox_Quicklink);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.btn_CreateALL);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.helpProvider.SetShowHelp(this.flowLayoutPanel1, false);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(638, 244);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.txt_PDF_Interval);
            this.groupBox2.Controls.Add(this.btn_PDF);
            this.groupBox2.Controls.Add(this.timePicker_PDF);
            this.groupBox2.Controls.Add(this.datePicker_PDF);
            this.groupBox2.Location = new System.Drawing.Point(422, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 169);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subscriptions - PDF";
            // 
            // btn_PDF
            // 
            this.btn_PDF.Location = new System.Drawing.Point(37, 127);
            this.btn_PDF.Name = "btn_PDF";
            this.btn_PDF.Size = new System.Drawing.Size(75, 23);
            this.btn_PDF.TabIndex = 2;
            this.btn_PDF.Text = "Create";
            this.btn_PDF.UseVisualStyleBackColor = true;
            this.btn_PDF.Click += new System.EventHandler(this.btn_PDF_Click);
            // 
            // timePicker_PDF
            // 
            this.timePicker_PDF.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker_PDF.Location = new System.Drawing.Point(6, 72);
            this.timePicker_PDF.Name = "timePicker_PDF";
            this.timePicker_PDF.ShowUpDown = true;
            this.timePicker_PDF.Size = new System.Drawing.Size(74, 20);
            this.timePicker_PDF.TabIndex = 1;
            this.timePicker_PDF.Value = new System.DateTime(2016, 4, 4, 5, 0, 0, 0);
            // 
            // datePicker_PDF
            // 
            this.datePicker_PDF.Location = new System.Drawing.Point(6, 46);
            this.datePicker_PDF.Name = "datePicker_PDF";
            this.datePicker_PDF.Size = new System.Drawing.Size(143, 20);
            this.datePicker_PDF.TabIndex = 1;
            // 
            // btn_CreateALL
            // 
            this.btn_CreateALL.Location = new System.Drawing.Point(3, 178);
            this.btn_CreateALL.Name = "btn_CreateALL";
            this.btn_CreateALL.Size = new System.Drawing.Size(75, 23);
            this.btn_CreateALL.TabIndex = 2;
            this.btn_CreateALL.Text = "Create all";
            this.btn_CreateALL.UseVisualStyleBackColor = true;
            this.btn_CreateALL.Click += new System.EventHandler(this.btn_CreateALL_Click);
            // 
            // timerStatusLabel
            // 
            this.timerStatusLabel.Interval = 3000;
            this.timerStatusLabel.Tick += new System.EventHandler(this.timerStatusLabel_Tick);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // txt_Printer_Interval
            // 
            this.txt_Printer_Interval.Location = new System.Drawing.Point(114, 99);
            this.txt_Printer_Interval.Name = "txt_Printer_Interval";
            this.txt_Printer_Interval.Size = new System.Drawing.Size(54, 20);
            this.txt_Printer_Interval.TabIndex = 3;
            // 
            // txt_PDF_Interval
            // 
            this.txt_PDF_Interval.Location = new System.Drawing.Point(95, 72);
            this.txt_PDF_Interval.Name = "txt_PDF_Interval";
            this.txt_PDF_Interval.Size = new System.Drawing.Size(54, 20);
            this.txt_PDF_Interval.TabIndex = 4;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 290);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Plus";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpbox_Quicklink.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_catalogs;
        private System.Windows.Forms.Button btn_QuickLink;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.GroupBox grpbox_Quicklink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox cb_printers;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker datePicker_Printer;
        private System.Windows.Forms.DateTimePicker timePicker_Printer;
        private System.Windows.Forms.Button btn_Printer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_PDF;
        private System.Windows.Forms.DateTimePicker timePicker_PDF;
        private System.Windows.Forms.DateTimePicker datePicker_PDF;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timerStatusLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Button btn_CreateALL;
        private System.Windows.Forms.TextBox txt_Printer_Interval;
        private System.Windows.Forms.TextBox txt_PDF_Interval;
    }
}

