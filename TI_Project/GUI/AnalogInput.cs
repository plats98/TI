using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIProject.GUI
{
    public partial class AnalogInput : Form
    {
        private Main main;
        
        public AnalogInput(Main main)
        {
            this.main = main;
            InitializeComponent();

            ReloadData();
        }

        private void ReloadData()
        {
            cb_EGU.DataSource = new BLL.Factory().GetEGU();
            lbl_Areas.Text = main.area1.Name + ", " + main.area2.Name;
        }

        private void cb_EGU_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
