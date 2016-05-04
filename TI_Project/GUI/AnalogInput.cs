using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIProject.BE;
using TIProject.BLL;

namespace TIProject.GUI
{
    public partial class AnalogInput : Form
    {
        private Factory factory = new Factory();
        private Main _Main;
        private AnalogSignal _AnalogSignal;


        public AnalogInput(Main main, AnalogSignal analogSignal)
        {
            _AnalogSignal = analogSignal;
            _Main = main;

            if (_Main == null) Close();
            if (_AnalogSignal == null) _AnalogSignal = new AnalogSignal();

            InitializeComponent();
            ReloadData();
        }

        private void ReloadData()
        {
            cb_EGU.DataSource = new BLL.Factory().GetEGU();

          //  if (_AnalogSignal.Area1 == null) _AnalogSignal.Area1 = _Main.area1;
          //  if (_AnalogSignal.Area2 == null) _AnalogSignal.Area2 = _Main.area2;
         //   lbl_Areas.Text = _AnalogSignal.Area1.Name + ", " + _AnalogSignal.Area2.Name;


            txt_Desc.Text = _AnalogSignal.Description;
            txt_KKS.Text = _AnalogSignal.KKS;
            check_LowHigh.Checked = _AnalogSignal.LowHigh;
            check_LowLowHighHigh.Checked = _AnalogSignal.LowLowHighHigh;
            check_Historian.Checked = _AnalogSignal.Historian;
            cb_EGU.SelectedItem = _AnalogSignal.EGU;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
        //    if (_AnalogSignal.Area1 == null) _AnalogSignal.Area1 = _Main.area1;
        //    if (_AnalogSignal.Area2 == null) _AnalogSignal.Area2 = _Main.area2;

            _AnalogSignal.Description = txt_Desc.Text;
            _AnalogSignal.KKS = txt_KKS.Text;
            _AnalogSignal.LowHigh = check_LowHigh.Checked;
            _AnalogSignal.LowLowHighHigh = check_LowLowHighHigh.Checked;
            _AnalogSignal.Historian = check_Historian.Checked;
            _AnalogSignal.EGU = cb_EGU.SelectedItem.ToString();

            _Main.addRow(_AnalogSignal);
            Close();
        }

        private void cb_Area1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //area1 = (Area)cb_Area1.SelectedItem;


            BindingSource bs_Area2 = new BindingSource();
            bs_Area2.DataSource = factory.GetAreas(new Area("", "test"));
            cb_Area2.DataSource = bs_Area2.DataSource;
            if (cb_Area2.Items.Count > 0) cb_Area2.SelectedIndex = 0;

            cb_Area2.DisplayMember = "Description";
            cb_Area2.ValueMember = null;
        }

        private void cb_Area2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //area2 = (Area)cb_Area2.SelectedItem;
        }
    }
}
