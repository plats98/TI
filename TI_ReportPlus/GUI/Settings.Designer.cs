namespace TI.ReportPlus.GUI
{
    partial class Settings
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
            this.listBox_Property = new System.Windows.Forms.ListBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txtBox_NewValue = new System.Windows.Forms.TextBox();
            this.lbl_OldValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_PropertyName = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.check_Info = new System.Windows.Forms.CheckBox();
            this.check_Warn = new System.Windows.Forms.CheckBox();
            this.check_Debug = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Property
            // 
            this.listBox_Property.FormattingEnabled = true;
            this.listBox_Property.Location = new System.Drawing.Point(12, 12);
            this.listBox_Property.Name = "listBox_Property";
            this.listBox_Property.Size = new System.Drawing.Size(171, 342);
            this.listBox_Property.TabIndex = 0;
            this.listBox_Property.SelectedIndexChanged += new System.EventHandler(this.listBox_Property_SelectedIndexChanged);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(424, 155);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(103, 23);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txtBox_NewValue
            // 
            this.txtBox_NewValue.Location = new System.Drawing.Point(310, 129);
            this.txtBox_NewValue.Name = "txtBox_NewValue";
            this.txtBox_NewValue.Size = new System.Drawing.Size(217, 20);
            this.txtBox_NewValue.TabIndex = 3;
            // 
            // lbl_OldValue
            // 
            this.lbl_OldValue.AutoSize = true;
            this.lbl_OldValue.Location = new System.Drawing.Point(307, 104);
            this.lbl_OldValue.Name = "lbl_OldValue";
            this.lbl_OldValue.Size = new System.Drawing.Size(67, 13);
            this.lbl_OldValue.TabIndex = 4;
            this.lbl_OldValue.Text = "Not selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "New value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Old value:";
            // 
            // lbl_PropertyName
            // 
            this.lbl_PropertyName.AutoSize = true;
            this.lbl_PropertyName.Location = new System.Drawing.Point(307, 82);
            this.lbl_PropertyName.Name = "lbl_PropertyName";
            this.lbl_PropertyName.Size = new System.Drawing.Size(77, 13);
            this.lbl_PropertyName.TabIndex = 4;
            this.lbl_PropertyName.Text = "Property Name";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(310, 155);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(103, 23);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log level:";
            // 
            // check_Info
            // 
            this.check_Info.AutoSize = true;
            this.check_Info.Location = new System.Drawing.Point(310, 285);
            this.check_Info.Name = "check_Info";
            this.check_Info.Size = new System.Drawing.Size(51, 17);
            this.check_Info.TabIndex = 5;
            this.check_Info.Text = "INFO";
            this.check_Info.UseVisualStyleBackColor = true;
            this.check_Info.CheckedChanged += new System.EventHandler(this.check_Info_CheckedChanged);
            // 
            // check_Warn
            // 
            this.check_Warn.AutoSize = true;
            this.check_Warn.Location = new System.Drawing.Point(367, 285);
            this.check_Warn.Name = "check_Warn";
            this.check_Warn.Size = new System.Drawing.Size(60, 17);
            this.check_Warn.TabIndex = 5;
            this.check_Warn.Text = "WARN";
            this.check_Warn.UseVisualStyleBackColor = true;
            this.check_Warn.CheckedChanged += new System.EventHandler(this.check_Warn_CheckedChanged);
            // 
            // check_Debug
            // 
            this.check_Debug.AutoSize = true;
            this.check_Debug.Location = new System.Drawing.Point(433, 285);
            this.check_Debug.Name = "check_Debug";
            this.check_Debug.Size = new System.Drawing.Size(64, 17);
            this.check_Debug.TabIndex = 5;
            this.check_Debug.Text = "DEBUG";
            this.check_Debug.UseVisualStyleBackColor = true;
            this.check_Debug.CheckedChanged += new System.EventHandler(this.check_Debug_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "*Genstart programmet ved opdate af SQL info";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(599, 366);
            this.Controls.Add(this.check_Debug);
            this.Controls.Add(this.check_Warn);
            this.Controls.Add(this.check_Info);
            this.Controls.Add(this.lbl_PropertyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_OldValue);
            this.Controls.Add(this.txtBox_NewValue);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.listBox_Property);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Property;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txtBox_NewValue;
        private System.Windows.Forms.Label lbl_OldValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_PropertyName;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check_Info;
        private System.Windows.Forms.CheckBox check_Warn;
        private System.Windows.Forms.CheckBox check_Debug;
        private System.Windows.Forms.Label label4;
    }
}