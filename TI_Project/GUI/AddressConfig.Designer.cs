namespace TIProject.GUI
{
    partial class AddressConfig
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
            this.cb_Device = new System.Windows.Forms.ComboBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.cb_Bit = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Device
            // 
            this.cb_Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Device.FormattingEnabled = true;
            this.cb_Device.Location = new System.Drawing.Point(12, 25);
            this.cb_Device.Name = "cb_Device";
            this.cb_Device.Size = new System.Drawing.Size(224, 21);
            this.cb_Device.TabIndex = 0;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(83, 74);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(100, 20);
            this.txt_Address.TabIndex = 1;
            // 
            // cb_Type
            // 
            this.cb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Location = new System.Drawing.Point(12, 74);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(65, 21);
            this.cb_Type.TabIndex = 2;
            this.cb_Type.SelectedIndexChanged += new System.EventHandler(this.cb_Type_SelectedIndexChanged);
            // 
            // cb_Bit
            // 
            this.cb_Bit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Bit.FormattingEnabled = true;
            this.cb_Bit.Location = new System.Drawing.Point(189, 74);
            this.cb_Bit.Name = "cb_Bit";
            this.cb_Bit.Size = new System.Drawing.Size(47, 21);
            this.cb_Bit.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(161, 193);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Gem";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(83, 192);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Afslut";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // AddressConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cb_Bit);
            this.Controls.Add(this.cb_Type);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.cb_Device);
            this.Name = "AddressConfig";
            this.Text = "AddressConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Device;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.ComboBox cb_Bit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}