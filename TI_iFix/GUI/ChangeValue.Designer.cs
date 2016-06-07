namespace TI.iFix.GUI
{
    partial class ChangeValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeValue));
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_MinValue = new System.Windows.Forms.Label();
            this.lbl_MaxValue = new System.Windows.Forms.Label();
            this.lbl_Tagname = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test21ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(13, 13);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(205, 20);
            this.txt_Input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Min værdi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maks værdi:";
            // 
            // lbl_MinValue
            // 
            this.lbl_MinValue.AutoSize = true;
            this.lbl_MinValue.Location = new System.Drawing.Point(150, 40);
            this.lbl_MinValue.Name = "lbl_MinValue";
            this.lbl_MinValue.Size = new System.Drawing.Size(42, 13);
            this.lbl_MinValue.TabIndex = 3;
            this.lbl_MinValue.Text = "#####";
            this.lbl_MinValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_MaxValue
            // 
            this.lbl_MaxValue.AutoSize = true;
            this.lbl_MaxValue.Location = new System.Drawing.Point(150, 64);
            this.lbl_MaxValue.Name = "lbl_MaxValue";
            this.lbl_MaxValue.Size = new System.Drawing.Size(42, 13);
            this.lbl_MaxValue.TabIndex = 4;
            this.lbl_MaxValue.Text = "#####";
            this.lbl_MaxValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Tagname
            // 
            this.lbl_Tagname.AutoSize = true;
            this.lbl_Tagname.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tagname.Location = new System.Drawing.Point(16, 121);
            this.lbl_Tagname.Name = "lbl_Tagname";
            this.lbl_Tagname.Size = new System.Drawing.Size(32, 7);
            this.lbl_Tagname.TabIndex = 5;
            this.lbl_Tagname.Text = "Tagnavn";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(16, 90);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(117, 90);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.test2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(80, 48);
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.test1ToolStripMenuItem.Text = "Test 1";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test21ToolStripMenuItem});
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.test2ToolStripMenuItem.Text = "Test 2";
            // 
            // test21ToolStripMenuItem
            // 
            this.test21ToolStripMenuItem.Name = "test21ToolStripMenuItem";
            this.test21ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.test21ToolStripMenuItem.Text = "Test 2.1";
            // 
            // ChangeValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(230, 136);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_Tagname);
            this.Controls.Add(this.lbl_MaxValue);
            this.Controls.Add(this.lbl_MinValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeValue";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeValue";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChangeValue_Load);
            this.Click += new System.EventHandler(this.ChangeValue_Click);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ChangeValue_MouseDoubleClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MinValue;
        private System.Windows.Forms.Label lbl_MaxValue;
        private System.Windows.Forms.Label lbl_Tagname;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test21ToolStripMenuItem;
    }
}