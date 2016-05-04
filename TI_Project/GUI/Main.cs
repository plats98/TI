using TIProject.BE;
using TIProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace TIProject.GUI
{
    public partial class Main : Form
    {
        BindingSource bindingSource1 = new BindingSource();
        Project project = new Project();
        private Factory factory = new Factory();

        public Main()
        {
            InitializeComponent();
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            Text = Text + " " + version.Major + "." + version.Minor + " (build " + version.Build + ")"; //change form title

            project = factory.LoadList();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //https://web.archive.org/web/20131104125500/http://www.radsoftware.com.au/articles/clipboardmonitor.aspx
        //http://www.codeproject.com/Articles/36850/DataGridView-Copy-and-Paste
        //http://stackoverflow.com/questions/621577/clipboard-event-c-sharp
        private void button1_Click(object sender, EventArgs e)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                if (dataGridView1.RowCount > 0)
                    dataGridView1.Rows.Clear();

                if (dataGridView1.ColumnCount > 0)
                    dataGridView1.Columns.Clear();

                bool columnsAdded = false;
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    if (!columnsAdded)
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            dataGridView1.Columns.Add("col" + i, pastedRowCells[i]);

                        columnsAdded = true;
                        continue;
                    }

                    dataGridView1.Rows.Add();
                    int myRowIndex = dataGridView1.Rows.Count - 1;

                    using (DataGridViewRow myDataGridViewRow = dataGridView1.Rows[myRowIndex])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            myDataGridViewRow.Cells[i].Value = pastedRowCells[i];
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int iFail = 0, iRow = dataGridView1.CurrentCell.RowIndex;
                int iCol = dataGridView1.CurrentCell.ColumnIndex;
                DataGridViewCell oCell;
                foreach (string line in lines)
                {
                    if (iRow < dataGridView1.RowCount && line.Length > 0)
                    {
                        string[] sCells = line.Split('\t');
                        for (int i = 0; i < sCells.GetLength(0); ++i)
                        {
                            if (iCol + i < this.dataGridView1.ColumnCount)
                            {
                                oCell = dataGridView1[iCol + i, iRow];
                                if (!oCell.ReadOnly)
                                {
                                    if (oCell.Value.ToString() != sCells[i])
                                    {
                                        oCell.Value = Convert.ChangeType(sCells[i],
                                                              oCell.ValueType);
                                        oCell.Style.BackColor = Color.Tomato;
                                    }
                                    else
                                        iFail++;
                                    //only traps a fail if the data has changed 
                                    //and you are pasting into a read only cell
                                }
                            }
                            else
                            { break; }
                        }
                        iRow++;
                    }
                    else
                    { break; }
                    if (iFail > 0)
                        MessageBox.Show(string.Format("{0} updates failed due" +
                                        " to read only column setting", iFail));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The data you pasted is in the wrong format for the cell");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Case.Text = project.Plant.Case;
            txt_Plant.Text = project.Plant.Name;

            AddColumns();
            setupCustomGridData();
        }

        // Configures columns for the DataGridView control.
        private void AddColumns()
        {
            //https://msdn.microsoft.com/en-us/library/system.windows.forms.datagridview.autogeneratecolumns%28v=vs.110%29.aspx?f=255&MSPPError=-2147217396

            //Initial settings
            bindingSource1.Clear();
            bindingSource1.DataSource = typeof(AnalogSignal);
            if (!project.AnalogSignals.IsNullOrEmpty())
                bindingSource1.DataSource = project.AnalogSignals;


            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bindingSource1;

            DataGridViewColumn column;
            string fieldNameString;

            // Handle KKS column
            fieldNameString = MemberInfoGetting.GetMemberName(() => new AnalogSignal().KKS);
            if (dataGridView1.Columns.Contains(fieldNameString))
            {
                column = dataGridView1.Columns[fieldNameString];
                column.Name = fieldNameString;
                column.Visible = true;
                column.ReadOnly = true;
                column.Frozen = true;
            }

            // Handle Address column
            fieldNameString = MemberInfoGetting.GetMemberName(() => new AnalogSignal().Address);
            if (dataGridView1.Columns.Contains(fieldNameString))
            {
                column = dataGridView1.Columns[fieldNameString];
                column.Name = fieldNameString;
                column.Visible = true;
                column.ReadOnly = true;
            }


            // Handle Area1 column
            DataGridViewComboBoxColumn dg_cb_Area1 = new DataGridViewComboBoxColumn();
            dg_cb_Area1.Name = MemberInfoGetting.GetMemberName(() => new AnalogSignal().Area1);
            dg_cb_Area1.HeaderText = "Område 1";
            dg_cb_Area1.DisplayMember = "Description";
            dg_cb_Area1.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dg_cb_Area1.ValueMember = "GUID";
            dg_cb_Area1.DataSource = factory.GetAreas(null);
            dataGridView1.Columns.Insert(3, dg_cb_Area1); //TODO: handle index

            // Handle Area2 column
            DataGridViewComboBoxColumn dg_cb_Area2 = new DataGridViewComboBoxColumn();
            dg_cb_Area2.Name = MemberInfoGetting.GetMemberName(() => new AnalogSignal().Area2);
            dg_cb_Area2.HeaderText = "Område 2";
            dg_cb_Area2.DisplayMember = "Description";
            dg_cb_Area2.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dg_cb_Area2.ValueMember = "GUID";
            dg_cb_Area2.DataSource = factory.GetAreas(new Area("", "Fællesanlæg5"));
            dataGridView1.Columns.Insert(4, dg_cb_Area2); //TODO: handle index

            // Handle EGU column
            DataGridViewComboBoxColumn dg_cb_EGU = new DataGridViewComboBoxColumn();
            dg_cb_EGU.Name = MemberInfoGetting.GetMemberName(() => new AnalogSignal().EGU);
            dg_cb_EGU.HeaderText = "Enhed";
            dg_cb_EGU.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dg_cb_EGU.ValueMember = null; //Returned value is full object
            dg_cb_EGU.DataSource = new Factory().GetEGU();
            dataGridView1.Columns.Insert(5, dg_cb_EGU); //TODO: handle index


            /*
            // Add a button column. 
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "Status Request";
            buttonColumn.Text = "Request Status";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(1, buttonColumn); // n is index
            */
        }

        private void setupCustomGridData()
        {
            AnalogSignal current;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.DataBoundItem == null) break;

                current = (AnalogSignal)row.DataBoundItem;
                if (current.Area1 != null)
                    row.Cells[MemberInfoGetting.GetMemberName(() => new AnalogSignal().Area1)].Value = current.Area1.GUID;
                if (current.Area2 != null)
                    row.Cells[MemberInfoGetting.GetMemberName(() => new AnalogSignal().Area2)].Value = current.Area2.GUID;
                if (current.EGU != null)
                    row.Cells[MemberInfoGetting.GetMemberName(() => new AnalogSignal().EGU)].Value = current.EGU;
            }
        }


        private void sCADAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SCADA scada = new SCADA();
            scada.StartPosition = FormStartPosition.Manual;
            scada.Location = new Point(this.Location.X + (this.Width - scada.Width) / 2, this.Location.Y + (this.Height - scada.Height) / 2);
            scada.Show(this);
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell is DataGridViewComboBoxCell)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                dataGridView1.EndEdit();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Make sure the clicked cell isn't the header.
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;

            var datagridview = sender as DataGridView;

            AnalogSignal analogSignal = (AnalogSignal)datagridview.CurrentRow.DataBoundItem;

            // Check to make sure the cell clicked is the cell containing the combobox 
            if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                datagridview.BeginEdit(true);
                ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            }


            if (datagridview.Columns[e.ColumnIndex].Name == MemberInfoGetting.GetMemberName(() => new AnalogSignal().Address))
            {
                AddressConfig ac = new AddressConfig(analogSignal);
                ac.StartPosition = FormStartPosition.Manual;
                ac.Location = new Point(this.Location.X + (this.Width - ac.Width) / 2, this.Location.Y + (this.Height - ac.Height) / 2);
                ac.Show(this);
            }
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            // AnalogSignal current = (AnalogSignal)dataGridView1.CurrentRow.DataBoundItem;
            // dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }

        public void addRow(AnalogSignal analogSignal)
        {
            project.AnalogSignals.Add(analogSignal);
            setupCustomGridData();
        }


        /// <summary>
        /// Update list with combobox data
        /// </summary>
        private void updateGridData()
        {
            DataGridViewCell cell;
            AnalogSignal analogSignal;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.DataBoundItem == null) break;

                analogSignal = (AnalogSignal)row.DataBoundItem;

                //Fix area 1
                cell = row.Cells[MemberInfoGetting.GetMemberName(() => new AnalogSignal().Area1)];
                // http://stackoverflow.com/questions/1175645/find-an-item-in-list-by-linq
                analogSignal.Area1 = factory.GetAreas(null).SingleOrDefault(area => String.Equals(area.GUID,cell.Value.ToString(), StringComparison.OrdinalIgnoreCase));

                //Fix area 2
                cell = row.Cells[MemberInfoGetting.GetMemberName(() => new AnalogSignal().Area2)];
                analogSignal.Area2 = factory.GetAreas(analogSignal.Area1).SingleOrDefault(area => String.Equals(area.GUID, cell.Value.ToString(), StringComparison.OrdinalIgnoreCase));

                //Fix EGU
                cell = row.Cells[MemberInfoGetting.GetMemberName(() => new AnalogSignal().EGU)];
                analogSignal.EGU = "" + cell.Value;
            }

            project.Plant.Name = txt_Plant.Text;
            project.Plant.Case = txt_Case.Text;
        }

        private void gemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateGridData();
            factory.Save(project);
        }

        private void åbenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadGridData();
        }

        private void loadGridData()
        {
            project = factory.LoadList();
            BindingList<AnalogSignal> list = project.AnalogSignals;
            //Initial settings
            bindingSource1.Clear();
            bindingSource1.DataSource = typeof(AnalogSignal);
            if (list != null)
                bindingSource1.DataSource = list;

            setupCustomGridData();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.None:
                    e.Cancel = true;
                    break;
                case CloseReason.WindowsShutDown:
                    e.Cancel = true;
                    break;
                case CloseReason.MdiFormClosing:
                    e.Cancel = true;
                    break;
                case CloseReason.UserClosing:
                    DialogResult result = MessageBox.Show("Er du sikker på at du vil afslutte?", "Afslut program?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes) Environment.Exit(0);
                    break;
                case CloseReason.TaskManagerClosing:
                    e.Cancel = true;
                    break;
                case CloseReason.FormOwnerClosing:
                    e.Cancel = true;
                    break;
                case CloseReason.ApplicationExitCall:
                    e.Cancel = true;
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            updateGridData();
            factory.Save(project);
        }

        private void Btn_Copy_Click(object sender, EventArgs e)
        {
            AnalogSignal analogSignal = (AnalogSignal)dataGridView1.CurrentRow.DataBoundItem;

            AnalogInput ai = new AnalogInput(this, analogSignal);
            ai.StartPosition = FormStartPosition.Manual;
            ai.Location = new Point(this.Location.X + (this.Width - ai.Width) / 2, this.Location.Y + (this.Height - ai.Height) / 2);
            ai.Show(this);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            AnalogSignal analogSignal;

            // Delete all selected rows (only completly selected rows)
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                analogSignal = (AnalogSignal)row.DataBoundItem;
                // TODO save deleted rows
                dataGridView1.Rows.RemoveAt(row.Index);
            }

            /*
            // Delete all rows witch contains selected cells
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                if (oneCell.Selected)
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);            
            */
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            AnalogInput ai = new AnalogInput(this, null);
            ai.StartPosition = FormStartPosition.Manual;
            ai.Location = new Point(this.Location.X + (this.Width - ai.Width) / 2, this.Location.Y + (this.Height - ai.Height) / 2);
            ai.Show(this);
        }

        private void områderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Areas areas = new Areas();
            areas.StartPosition = FormStartPosition.Manual;
            areas.Location = new Point(this.Location.X + (this.Width - areas.Width) / 2, this.Location.Y + (this.Height - areas.Height) / 2);
            areas.Show(this);
        }

        private void pLCToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sCADAToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void netværkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
