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
    public partial class Areas : Form
    {
        private Factory factory = new Factory();

        public Areas()
        {
            InitializeComponent();
        }

        private void Areas_Load(object sender, EventArgs e)
        {
            // tree_Areas.Nodes.Add("6D0C5F11-B001-4376-8ED0-BA7FA40F8306", "Områder");

            foreach (Area area1 in factory.GetAreas(null))
            {
                tree_Areas.Nodes.Add(area1.GUID, area1.Description);
                foreach (Area area2 in factory.GetAreas(area1))
                {
                    tree_Areas.Nodes[area1.GUID].Nodes.Add(area1.GUID, area1.Description);
                }
            }
            
        }
    }
}
