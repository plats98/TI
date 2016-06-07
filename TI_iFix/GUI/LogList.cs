using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TI.iFix.BE;
using TI.iFix.BLL;

namespace TI.iFix.GUI
{
    public partial class LogList : Form
    {
        /// <summary>
        /// The List type
        /// </summary>
        private string listType = "not known created by RASMUS PLATS";
        
        public string ListType
        {
            get
            {
                return listType;
            }
            set
            {
                listType = value;
            }
        }

        public LogList()
        {
            InitializeComponent();

            LogHandler logHandler = new LogHandler();


            var source = new BindingSource();
            List<BEChangeLog> list = logHandler.TestData();
            source.DataSource = list;
            dataGridView1.DataSource = source;

            dataGridView1.Columns[0].DisplayIndex = 2;
            dataGridView1.Columns[2].DisplayIndex = 1;
            dataGridView1.Columns[1].DisplayIndex = 0;
        }

        public string getValue()
        {
            return comboBox1.Text;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("R" + dataGridView1.SelectedCells[0].RowIndex + " C" + dataGridView1.SelectedCells[0].ColumnIndex);
        }

        private void LogList_Load(object sender, EventArgs e)
        {
            LogHandler logHandler =  new LogHandler();


            var source = new BindingSource();
            List<BEChangeLog> list = logHandler.TestData();
            source.DataSource = list;
            dataGridView1.DataSource = source;
            
            dataGridView1.Columns[0].DisplayIndex = 2;
            dataGridView1.Columns[2].DisplayIndex = 1;
            dataGridView1.Columns[1].DisplayIndex = 0;
        }
        
    }
}
