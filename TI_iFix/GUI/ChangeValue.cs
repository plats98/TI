using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI.iFix.GUI
{
    public partial class ChangeValue : Form
    {

        public ChangeValue()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeValue_Load(object sender, EventArgs e)
        {

        }

        private void ChangeValue_Click(object sender, EventArgs e)
        {
            txt_Input.Text = "ChangeValue_Click";
        }

        private void ChangeValue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_Input.Text = "ChangeValue_MouseDoubleClick";
        }
    }
}
