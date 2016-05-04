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
    public partial class AddressConfig : Form
    {
        private Factory factory = new Factory();
        private AnalogSignal analogSignal;

        public AddressConfig(AnalogSignal analogSignal)
        {
            this.analogSignal = analogSignal;
            InitializeComponent();

            // DEVICETYPE
            cb_Device.DataSource = Enum.GetValues(typeof(DEVICETYPE))
                                    .Cast<DEVICETYPE>()
                                    .Select(p => new { Key = (int)p, Value = p.ToString() })
                                    //  .OrderBy(item => item.value)
                                    .ToList();
            cb_Device.DisplayMember = "Value";
            cb_Device.ValueMember = "Key";

            // WORDTYPE
            cb_Type.DataSource = Enum.GetValues(typeof(WORDTYPE))
                                    .Cast<WORDTYPE>()
                                    .Select(p => new { Key = (int)p, Value = p.ToString() })
                                    //  .OrderBy(item => item.value)
                                    .ToList();
            cb_Type.DisplayMember = "Value";
            cb_Type.ValueMember = "Key";

            // Bit
            cb_Bit.DataSource = factory.GetBitsPLC();

            // Default values
            cb_Device.SelectedIndex = (int)analogSignal.Address.DeviceType;
            cb_Type.SelectedIndex = (int)analogSignal.Address.WordType;
            txt_Address.Text = analogSignal.Address.Address.ToString();
            cb_Bit.SelectedIndex = analogSignal.Address.Bit;
        }

        private void cb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((WORDTYPE)cb_Type.SelectedIndex)
            {
                case WORDTYPE.INT:
                    cb_Bit.Enabled = true;
                    break;
                case WORDTYPE.DINT:
                    cb_Bit.Enabled = true;
                    break;
                case WORDTYPE.FLOAT:
                    cb_Bit.Enabled = true;
                    break;
                case WORDTYPE.BOOL:
                    cb_Bit.Enabled = false;
                    break;
                default:
                    // Error
                    break;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            analogSignal.Address.DeviceType = (DEVICETYPE)cb_Device.SelectedIndex;
            analogSignal.Address.WordType = (WORDTYPE)cb_Type.SelectedIndex;
            analogSignal.Address.Address = int.Parse(txt_Address.Text);
            analogSignal.Address.Bit = int.Parse(cb_Bit.Text);
            this.Close();
        }
    }
}
