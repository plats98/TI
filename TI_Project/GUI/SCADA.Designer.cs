namespace TIProject.GUI
{
    partial class SCADA
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_DR = new System.Windows.Forms.TabPage();
            this.grid_DR = new System.Windows.Forms.DataGridView();
            this.tab_DA = new System.Windows.Forms.TabPage();
            this.grid_DA = new System.Windows.Forms.DataGridView();
            this.tab_AA = new System.Windows.Forms.TabPage();
            this.grid_AA = new System.Windows.Forms.DataGridView();
            this.tab_AR = new System.Windows.Forms.TabPage();
            this.grid_AR = new System.Windows.Forms.DataGridView();
            this.tab_AI = new System.Windows.Forms.TabPage();
            this.SCADA_Tabview = new System.Windows.Forms.TabControl();
            this.grid_AI = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tab_DR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DR)).BeginInit();
            this.tab_DA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DA)).BeginInit();
            this.tab_AA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_AA)).BeginInit();
            this.tab_AR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_AR)).BeginInit();
            this.tab_AI.SuspendLayout();
            this.SCADA_Tabview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_AI)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SCADA_Tabview);
            this.splitContainer1.Size = new System.Drawing.Size(907, 425);
            this.splitContainer1.SplitterDistance = 302;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "iFix";
            // 
            // tab_DR
            // 
            this.tab_DR.Controls.Add(this.grid_DR);
            this.tab_DR.Location = new System.Drawing.Point(4, 22);
            this.tab_DR.Name = "tab_DR";
            this.tab_DR.Size = new System.Drawing.Size(587, 393);
            this.tab_DR.TabIndex = 3;
            this.tab_DR.Text = "DR";
            this.tab_DR.UseVisualStyleBackColor = true;
            // 
            // grid_DR
            // 
            this.grid_DR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DR.Location = new System.Drawing.Point(1, 1);
            this.grid_DR.Name = "grid_DR";
            this.grid_DR.Size = new System.Drawing.Size(584, 390);
            this.grid_DR.TabIndex = 2;
            // 
            // tab_DA
            // 
            this.tab_DA.Controls.Add(this.grid_DA);
            this.tab_DA.Location = new System.Drawing.Point(4, 22);
            this.tab_DA.Name = "tab_DA";
            this.tab_DA.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DA.Size = new System.Drawing.Size(587, 393);
            this.tab_DA.TabIndex = 1;
            this.tab_DA.Text = "DA";
            this.tab_DA.UseVisualStyleBackColor = true;
            // 
            // grid_DA
            // 
            this.grid_DA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DA.Location = new System.Drawing.Point(1, 1);
            this.grid_DA.Name = "grid_DA";
            this.grid_DA.Size = new System.Drawing.Size(584, 390);
            this.grid_DA.TabIndex = 2;
            // 
            // tab_AA
            // 
            this.tab_AA.Controls.Add(this.grid_AA);
            this.tab_AA.Location = new System.Drawing.Point(4, 22);
            this.tab_AA.Name = "tab_AA";
            this.tab_AA.Size = new System.Drawing.Size(587, 393);
            this.tab_AA.TabIndex = 4;
            this.tab_AA.Text = "AA";
            this.tab_AA.UseVisualStyleBackColor = true;
            // 
            // grid_AA
            // 
            this.grid_AA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_AA.Location = new System.Drawing.Point(1, 1);
            this.grid_AA.Name = "grid_AA";
            this.grid_AA.Size = new System.Drawing.Size(584, 390);
            this.grid_AA.TabIndex = 1;
            // 
            // tab_AR
            // 
            this.tab_AR.Controls.Add(this.grid_AR);
            this.tab_AR.Location = new System.Drawing.Point(4, 22);
            this.tab_AR.Name = "tab_AR";
            this.tab_AR.Size = new System.Drawing.Size(587, 393);
            this.tab_AR.TabIndex = 2;
            this.tab_AR.Text = "AR";
            this.tab_AR.UseVisualStyleBackColor = true;
            // 
            // grid_AR
            // 
            this.grid_AR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_AR.Location = new System.Drawing.Point(1, 1);
            this.grid_AR.Name = "grid_AR";
            this.grid_AR.Size = new System.Drawing.Size(584, 390);
            this.grid_AR.TabIndex = 1;
            // 
            // tab_AI
            // 
            this.tab_AI.Controls.Add(this.grid_AI);
            this.tab_AI.Location = new System.Drawing.Point(4, 22);
            this.tab_AI.Name = "tab_AI";
            this.tab_AI.Padding = new System.Windows.Forms.Padding(3);
            this.tab_AI.Size = new System.Drawing.Size(587, 393);
            this.tab_AI.TabIndex = 0;
            this.tab_AI.Text = "AI";
            this.tab_AI.UseVisualStyleBackColor = true;
            // 
            // SCADA_Tabview
            // 
            this.SCADA_Tabview.Controls.Add(this.tab_AI);
            this.SCADA_Tabview.Controls.Add(this.tab_AR);
            this.SCADA_Tabview.Controls.Add(this.tab_AA);
            this.SCADA_Tabview.Controls.Add(this.tab_DA);
            this.SCADA_Tabview.Controls.Add(this.tab_DR);
            this.SCADA_Tabview.Location = new System.Drawing.Point(3, 3);
            this.SCADA_Tabview.Name = "SCADA_Tabview";
            this.SCADA_Tabview.SelectedIndex = 0;
            this.SCADA_Tabview.Size = new System.Drawing.Size(595, 419);
            this.SCADA_Tabview.TabIndex = 1;
            // 
            // grid_AI
            // 
            this.grid_AI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_AI.Location = new System.Drawing.Point(1, 1);
            this.grid_AI.Name = "grid_AI";
            this.grid_AI.Size = new System.Drawing.Size(584, 390);
            this.grid_AI.TabIndex = 2;
            // 
            // SCADA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 425);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SCADA";
            this.Text = "SCADA";
            this.Load += new System.EventHandler(this.SCADA_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tab_DR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_DR)).EndInit();
            this.tab_DA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_DA)).EndInit();
            this.tab_AA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_AA)).EndInit();
            this.tab_AR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_AR)).EndInit();
            this.tab_AI.ResumeLayout(false);
            this.SCADA_Tabview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_AI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl SCADA_Tabview;
        private System.Windows.Forms.TabPage tab_AI;
        private System.Windows.Forms.TabPage tab_AR;
        private System.Windows.Forms.DataGridView grid_AR;
        private System.Windows.Forms.TabPage tab_AA;
        private System.Windows.Forms.DataGridView grid_AA;
        private System.Windows.Forms.TabPage tab_DA;
        private System.Windows.Forms.DataGridView grid_DA;
        private System.Windows.Forms.TabPage tab_DR;
        private System.Windows.Forms.DataGridView grid_DR;
        private System.Windows.Forms.DataGridView grid_AI;
    }
}