namespace TIProject.GUI
{
    partial class Areas
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
            this.txt_Area = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Rename = new System.Windows.Forms.Button();
            this.tree_Areas = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // txt_Area
            // 
            this.txt_Area.Location = new System.Drawing.Point(279, 97);
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.Size = new System.Drawing.Size(161, 20);
            this.txt_Area.TabIndex = 1;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(317, 181);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Slet";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(317, 152);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Tilføj";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Rename
            // 
            this.btn_Rename.Location = new System.Drawing.Point(317, 123);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(75, 23);
            this.btn_Rename.TabIndex = 2;
            this.btn_Rename.Text = "Omdøb";
            this.btn_Rename.UseVisualStyleBackColor = true;
            // 
            // tree_Areas
            // 
            this.tree_Areas.Location = new System.Drawing.Point(12, 12);
            this.tree_Areas.Name = "tree_Areas";
            this.tree_Areas.Size = new System.Drawing.Size(234, 296);
            this.tree_Areas.TabIndex = 3;
            // 
            // Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 317);
            this.Controls.Add(this.tree_Areas);
            this.Controls.Add(this.btn_Rename);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.txt_Area);
            this.Name = "Areas";
            this.Text = "Areas";
            this.Load += new System.EventHandler(this.Areas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Area;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Rename;
        private System.Windows.Forms.TreeView tree_Areas;
    }
}