using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TI.ReportPlus.BLL;

namespace TI.ReportPlus.GUI
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            ReloadListbox();
        }

        private void listBox_Property_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, string> item = (KeyValuePair<string, string>)listBox_Property.SelectedItem;
            lbl_PropertyName.Text = item.Key;
            lbl_OldValue.Text = item.Value;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> item = (KeyValuePair<string, string>)listBox_Property.SelectedItem;
            Property.Set(item.Key, txtBox_NewValue.Text);

            int index = listBox_Property.SelectedIndex;
            ReloadListbox();
            listBox_Property.SelectedIndex = index;
        }

        private void ReloadListbox()
        {
            SortedDictionary<string, string> list = Property.GetList();
            listBox_Property.DataSource = new BindingSource(list, null);
            listBox_Property.DisplayMember = "Key";
            listBox_Property.ValueMember = "Value";

            check_Info.Checked = Logger.Info_Level;
            check_Warn.Checked = Logger.Warn_Level;
            check_Debug.Checked = Logger.Debug_Level;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Do you want to save changes?",
                    "Save changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.ServiceNotification
                );

            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    Property.Save();
                    Logger.ReloadLevels();
                    break;
                case DialogResult.No:
                    Property.Reload();
                    break;
                default:
                    break;
            }

        }

        private void check_Info_CheckedChanged(object sender, EventArgs e)
        {
            Property.Set("LoggerLevel_INFO", check_Info.Checked);
        }

        private void check_Warn_CheckedChanged(object sender, EventArgs e)
        {
            Property.Set("LoggerLevel_WARN", check_Warn.Checked);
        }

        private void check_Debug_CheckedChanged(object sender, EventArgs e)
        {
            Property.Set("LoggerLevel_DEBUG", check_Debug.Checked);
        }
    }
}
