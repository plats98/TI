namespace TIProject.GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_AI = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab_AO = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Case = new System.Windows.Forms.TextBox();
            this.txt_Plant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_CaseNumber = new System.Windows.Forms.Label();
            this.lbl_PlantName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Area2 = new System.Windows.Forms.ComboBox();
            this.cb_Area1 = new System.Windows.Forms.ComboBox();
            this.btn_New = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.åbenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCADAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tab_AI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_AI);
            this.tabControl1.Controls.Add(this.tab_AO);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1159, 440);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_AI
            // 
            this.tab_AI.Controls.Add(this.dataGridView1);
            this.tab_AI.Location = new System.Drawing.Point(4, 22);
            this.tab_AI.Name = "tab_AI";
            this.tab_AI.Padding = new System.Windows.Forms.Padding(3);
            this.tab_AI.Size = new System.Drawing.Size(1151, 414);
            this.tab_AI.TabIndex = 0;
            this.tab_AI.Text = "Analog Input";
            this.tab_AI.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 408);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // tab_AO
            // 
            this.tab_AO.Location = new System.Drawing.Point(4, 22);
            this.tab_AO.Name = "tab_AO";
            this.tab_AO.Padding = new System.Windows.Forms.Padding(3);
            this.tab_AO.Size = new System.Drawing.Size(1151, 414);
            this.tab_AO.TabIndex = 1;
            this.tab_AO.Text = "Analog Output";
            this.tab_AO.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.03196F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.60714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.39286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1165, 600);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Case);
            this.panel1.Controls.Add(this.txt_Plant);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_CaseNumber);
            this.panel1.Controls.Add(this.lbl_PlantName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_Area2);
            this.panel1.Controls.Add(this.cb_Area1);
            this.panel1.Controls.Add(this.btn_New);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 117);
            this.panel1.TabIndex = 2;
            // 
            // txt_Case
            // 
            this.txt_Case.Location = new System.Drawing.Point(197, 15);
            this.txt_Case.Name = "txt_Case";
            this.txt_Case.Size = new System.Drawing.Size(100, 20);
            this.txt_Case.TabIndex = 6;
            // 
            // txt_Plant
            // 
            this.txt_Plant.Location = new System.Drawing.Point(48, 15);
            this.txt_Plant.Name = "txt_Plant";
            this.txt_Plant.Size = new System.Drawing.Size(100, 20);
            this.txt_Plant.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Område 2";
            // 
            // lbl_CaseNumber
            // 
            this.lbl_CaseNumber.AutoSize = true;
            this.lbl_CaseNumber.Location = new System.Drawing.Point(165, 18);
            this.lbl_CaseNumber.Name = "lbl_CaseNumber";
            this.lbl_CaseNumber.Size = new System.Drawing.Size(26, 13);
            this.lbl_CaseNumber.TabIndex = 5;
            this.lbl_CaseNumber.Text = "Sag";
            // 
            // lbl_PlantName
            // 
            this.lbl_PlantName.AutoSize = true;
            this.lbl_PlantName.Location = new System.Drawing.Point(9, 18);
            this.lbl_PlantName.Name = "lbl_PlantName";
            this.lbl_PlantName.Size = new System.Drawing.Size(33, 13);
            this.lbl_PlantName.TabIndex = 5;
            this.lbl_PlantName.Text = "Værk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Område 1";
            // 
            // cb_Area2
            // 
            this.cb_Area2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Area2.FormattingEnabled = true;
            this.cb_Area2.Location = new System.Drawing.Point(738, 45);
            this.cb_Area2.Name = "cb_Area2";
            this.cb_Area2.Size = new System.Drawing.Size(164, 21);
            this.cb_Area2.TabIndex = 4;
            this.cb_Area2.SelectedIndexChanged += new System.EventHandler(this.cb_Area2_SelectedIndexChanged);
            // 
            // cb_Area1
            // 
            this.cb_Area1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Area1.FormattingEnabled = true;
            this.cb_Area1.Location = new System.Drawing.Point(738, 18);
            this.cb_Area1.Name = "cb_Area1";
            this.cb_Area1.Size = new System.Drawing.Size(164, 21);
            this.cb_Area1.TabIndex = 4;
            this.cb_Area1.SelectedIndexChanged += new System.EventHandler(this.cb_Area1_SelectedIndexChanged);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(980, 43);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 3;
            this.btn_New.Text = "Ny værdi";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sCADAToolStripMenuItem,
            this.pLCToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.åbenToolStripMenuItem,
            this.gemToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // åbenToolStripMenuItem
            // 
            this.åbenToolStripMenuItem.Name = "åbenToolStripMenuItem";
            this.åbenToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.åbenToolStripMenuItem.Text = "Åben";
            this.åbenToolStripMenuItem.Click += new System.EventHandler(this.åbenToolStripMenuItem_Click);
            // 
            // gemToolStripMenuItem
            // 
            this.gemToolStripMenuItem.Name = "gemToolStripMenuItem";
            this.gemToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.gemToolStripMenuItem.Text = "Gem";
            this.gemToolStripMenuItem.Click += new System.EventHandler(this.gemToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // sCADAToolStripMenuItem
            // 
            this.sCADAToolStripMenuItem.Name = "sCADAToolStripMenuItem";
            this.sCADAToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.sCADAToolStripMenuItem.Text = "SCADA";
            this.sCADAToolStripMenuItem.Click += new System.EventHandler(this.sCADAToolStripMenuItem_Click);
            // 
            // pLCToolStripMenuItem
            // 
            this.pLCToolStripMenuItem.Name = "pLCToolStripMenuItem";
            this.pLCToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.pLCToolStripMenuItem.Text = "PLC";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 624);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signal liste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_AI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_AI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tab_AO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem sCADAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLCToolStripMenuItem;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.ComboBox cb_Area2;
        private System.Windows.Forms.ComboBox cb_Area1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Plant;
        private System.Windows.Forms.Label lbl_PlantName;
        private System.Windows.Forms.TextBox txt_Case;
        private System.Windows.Forms.Label lbl_CaseNumber;
        private System.Windows.Forms.ToolStripMenuItem gemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem åbenToolStripMenuItem;
    }
}

