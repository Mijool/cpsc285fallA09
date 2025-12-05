using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


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



        

        SqlConnection cnnF25_285;
        SqlCommand cmdF25_285;
        SqlDataReader rdrF25_285;


        //change this in App.config as well
        //private String connectionStr = @"Data Source=cissql;Initial Catalog=F25_285A;Integrated Security=True"; //School DBO
        String connectionStr = @"Data Source=MACK\MCSQL;Initial Catalog=F25_285A;Integrated Security=True"; //Miguel's DBO



        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.staffTableAdapter.Fill(this.f25_285ADataSet.Staff);
                this.clientsTableAdapter.Fill(this.f25_285ADataSet.Clients);
                //this.classesTableAdapter.Fill(this.f25_285ADataSet.Classes);

                //rdoMonthClients.Checked = true;
                //rdoMonthInstructors.Checked = true;
                

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            
            }

        }

        
        private static void dataGridViewAlter(SqlConnection cnnView, SqlCommand cmdSelect, DataGridView formsDataGrid, String cnnStr, int idParam, char clientOrInstructor)
        {
            cnnView = new SqlConnection(cnnStr);
            cnnView.Open();

            DataTable dtSchedule = new DataTable();
            String sqlQuery = buildSelectQuery(idParam, clientOrInstructor, "This Month");


            cmdSelect = new SqlCommand(sqlQuery, cnnView);

            

            dtSchedule.Load(cmdSelect.ExecuteReader());

            formsDataGrid.DataSource = dtSchedule.AsDataView();

            cnnView.Close();
        }

        private void clientsTabUpdateDataGridHandler(object sender, EventArgs e) {
            rdoMonthClients.Checked = true;
            dataGridViewAlter(cnnF25_285, cmdF25_285, classesDataGridView, connectionStr, Convert.ToInt16(clientIDTextBox.Text), 'c', rdoMonthClients.Text);
        }

        private void instructorsTabUpdateDataGridHandler(object sender, EventArgs e)
        {
            rdoMonthInstructors.Checked = true;
            dataGridViewAlter(cnnF25_285, cmdF25_285, classesDataGridView1, connectionStr, Convert.ToInt16(staffIDTextBox.Text), 'i', rdoMonthInstructors.Text);
        }

        private void timeframeRadioButtonUpdateGridHandler(object sender, EventArgs e)
        {
            try
            {
                //captures object sent as a radioButton (it always will be)
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked == false) { return; }
                //works for instructors, figure out how to make it work for both
                dataGridViewAlter(cnnF25_285, cmdF25_285, classesDataGridView1, connectionStr, Convert.ToInt16(staffIDTextBox.Text), 'i', radioButton.Text);


            }
            catch { return; }
            


           
        }

        private static void dataGridViewAlter(SqlConnection cnnView, SqlCommand cmdSelect, DataGridView formsDataGrid, String cnnStr, int idParam, char clientOrInstructor, String timeframe)
        {
            cnnView = new SqlConnection(cnnStr);
            cnnView.Open();

            DataTable dtSchedule = new DataTable();
            String sqlQuery = buildSelectQuery(idParam, clientOrInstructor, timeframe);


            cmdSelect = new SqlCommand(sqlQuery, cnnView);



            dtSchedule.Load(cmdSelect.ExecuteReader());

            formsDataGrid.DataSource = dtSchedule.AsDataView();

            cnnView.Close();
        }

        private static String buildSelectQuery(int idParam, char clientOrInstructor, String timeframe)
        {
            String WHEREclause = "";


            switch (clientOrInstructor)
            {
                case 'c':
                    WHEREclause = $"Clients.ClientID = {idParam}";
                    break;
                case 'i':
                    WHEREclause = $"Clients.ClientID = {idParam}";
                    break;
            }

            switch (timeframe)
            {
                case "Today":
                    WHEREclause += " AND Classes.CDate = GETDATE()";

                    break;
                case "This Week":

                    WHEREclause += " AND (Classes.CDate BETWEEN GETDATE() AND DATEADD(week, 1, GETDATE()))";
                    break;
                case "This Month":
                    WHEREclause += " AND (Classes.CDate BETWEEN GETDATE() AND DATEADD(month, 1, GETDATE()))";
                    //WHEREclause += " AND Classes.CDate <= GETDATE() + 30 AND Classes.CDate >= GETDATE()";
                    break;
            }


            String sqlQuery = "SELECT Classes.CDate [Class Date], Classes.CTime [Class Time], Clients.CName [Client], Staff.SName [Staff] " +
                              " FROM db_owner.Classes inner join db_owner.Clients on Clients.ClientID = Classes.ClientID inner join db_owner.Staff on Staff.StaffID = Classes.StaffID " +
                              $" WHERE {WHEREclause}";
            return sqlQuery;
        }


        /*
         * 
         * 
         * Make sure schedule class tab populates comboboxes properly
         * 
         * 
         * hard code datagrid to load this query
         * 
         * 
         * 
         SELECT ClassID, CDate, CTime, Classes.ClientID, Clients.CName, Staff.SName,Classes.StaffID 
FROM (db_owner.Classes inner join db_owner.Clients on db_owner.Clients.ClientID = db_owner.Classes.ClientID) inner join db_owner.Staff on db_owner.Staff.StaffID = db_owner.Classes.StaffID
         
         */

        // Clients Tab



        //clients tab shouldnt include this buttons will not work (check designer cs file)
        //private void rdoTodayClients_CheckedChanged(object sender, EventArgs e) 
        //{
        //    changeScheduleTimeSpan("today");
        //}

        //private void rdoWeekClients_CheckedChanged(object sender, EventArgs e)
        //{
        //    changeScheduleTimeSpan("week");
        //}

        //private void rdoMonthClients_CheckedChanged(object sender, EventArgs e)
        //{
        //    changeScheduleTimeSpan("month");
        //}

        private void btnScheduleClass_Click(object sender, EventArgs e) //changes tab
        {

            tabControl_DONotEDIT.SelectTab("tabScheduleClass");
        }

        private void btnAddClient_Click(object sender, EventArgs e) //changes tab
        {
            tabControl_DONotEDIT.SelectTab("tabAddClients");
        }
        //Instructors Tab - should all use the same method
        private void rdoTodayInstructors_CheckedChanged(object sender, EventArgs e)
        {
            changeScheduleTimeSpan("today");
        }

        private void rdoWeekInstructors_CheckedChanged(object sender, EventArgs e)
        {
            changeScheduleTimeSpan("week");
        }

        private void rdoMonthInstructors_CheckedChanged(object sender, EventArgs e)
        {
            changeScheduleTimeSpan("month");
        }

        private void btnScheduleClass_1_Click(object sender, EventArgs e) //changes tabb
        {
            tabControl_DONotEDIT.SelectTab("tabScheduleClass");
        }
        
        //method for changing the timeframe on the gridviewList
        private static void changeScheduleTimeSpan(String timeframe)
        {

            switch (timeframe)
            {
                case "today":
                    //change the where clause to show today's date

                    return;
                case "week":
                    return;
                case "month":
                    return;
            }
        }

       



        //Add client - Taras

         private void btnAddClientToDBO_Click(object sender, EventArgs e) 
         {
            int id; //find a way to get the max ID from the table, then +1 it
            String Name = txtLastName.Text + ',' + txtFirstName.Text;
            int age = Convert.ToInt16(txtAge.Text); //this should be a tryparse 
            String gender = cboGender.SelectedItem.ToString().Substring(0, 1); // inserted as M, F, or O (other)

            try
            {
                //insert query
            }
            catch (FormatException ex)
            { 
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
         }

        

        //Schedule a new Class - Isai
        private void btnInsertScheduledClass_Click(object sender, EventArgs e)
        {
            try
            {
                //insert query
            }
            catch (FormatException ex)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
        }

        private void fillbyIncludeNamesToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.classesTableAdapter.FillbyIncludeNames(this.f25_285ADataSet.Classes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
