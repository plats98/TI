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

namespace TIProject.GUI
{
    public partial class SCADA : Form
    {
        BindingSource bs_AI = new BindingSource();
        BindingSource bs_AR = new BindingSource();
        BindingSource bs_AA = new BindingSource();
        BindingSource bs_DA = new BindingSource();
        BindingSource bs_DR = new BindingSource();

        public SCADA()
        {
            InitializeComponent();
        }

        private void SCADA_Load(object sender, EventArgs e)
        {
            bs_AI.DataSource = typeof(AI);
            bs_AI.Add(new AI("hej"));
            bs_AI.Add(new AI("dig"));
            bs_AI.Add(new AI("fisk"));
            grid_AI.DataSource = bs_AI;
            grid_AI.AutoGenerateColumns = true;

            bs_AR.DataSource = typeof(AI);
            bs_AR.Add(new AI("med"));
            bs_AR.Add(new AI("hej"));
            bs_AR.Add(new AI("dig"));
            bs_AR.Add(new AI("fisk"));
            grid_AR.DataSource = bs_AR;
            grid_AR.AutoGenerateColumns = true;

            bs_AA.DataSource = typeof(AI);
            bs_AA.Add(new AI("med"));
            bs_AA.Add(new AI("hej"));
            bs_AA.Add(new AI("dig"));
            bs_AA.Add(new AI("fisk"));
            grid_AA.DataSource = bs_AA;
            grid_AA.AutoGenerateColumns = true;

            bs_DA.DataSource = typeof(AI);
            bs_DA.Add(new AI("med"));
            bs_DA.Add(new AI("hej"));
            bs_DA.Add(new AI("dig"));
            bs_DA.Add(new AI("fisk"));
            bs_DA.Add(new AI("med"));
            grid_DA.DataSource = bs_DA;
            grid_DA.AutoGenerateColumns = true;

            bs_DR.DataSource = typeof(AI);
            bs_DR.Add(new AI("hej"));
            bs_DR.Add(new AI("dig"));
            bs_DR.Add(new AI("fisk"));
            bs_DR.Add(new AI("med"));
            grid_DR.DataSource = bs_DR;
            grid_DR.AutoGenerateColumns = true;
        }
        
    }
}
