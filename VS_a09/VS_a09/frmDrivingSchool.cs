using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_a09
{
    public partial class frmDrivingSchool : Form
    {
        public frmDrivingSchool()
        {
            InitializeComponent();
        }

        private void classesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.f25_285ADataSet);

        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.f25_285ADataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'f25_285ADataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.f25_285ADataSet.Staff);
            // TODO: This line of code loads data into the 'f25_285ADataSet.Classes' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'f25_285ADataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.f25_285ADataSet.Clients);

            this.classesTableAdapter.Fill(this.f25_285ADataSet.Classes);
        }

        // Clients Tab
        private void rdoTodayClients_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoWeekClients_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoMonthClients_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnScheduleClass_Click(object sender, EventArgs e)
        {

        }

        //Instructors Tab


    }
}
