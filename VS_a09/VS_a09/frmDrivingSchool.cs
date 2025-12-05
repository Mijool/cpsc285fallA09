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



        

        

        //change this in App.config as well
        //private String connectionStr = @"Data Source=cissql;Initial Catalog=F25_285A;Integrated Security=True"; //School DBO
        String connectionStr = @"Data Source=MACK\MCSQL;Initial Catalog=F25_285A;Integrated Security=True"; //Miguel's DBO



        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cnnF25_285;
            SqlCommand cmdF25_285;
            SqlDataReader rdrF25_285;

            DataTable dtSchedule = new DataTable();
            try
            {
                this.staffTableAdapter.Fill(this.f25_285ADataSet.Staff);
                this.clientsTableAdapter.Fill(this.f25_285ADataSet.Clients);
                //this.classesTableAdapter.Fill(this.f25_285ADataSet.Classes);

                cnnF25_285 = new SqlConnection(connectionStr);
                cnnF25_285.Open();

                cmdF25_285 = new SqlCommand();


                cmdF25_285.Connection = cnnF25_285;
                cmdF25_285.CommandType = CommandType.Text;
                cmdF25_285.CommandText = "SELECT [db_owner.Classes.CDate], [db_owner.Classes.CTime], [Clients.CName], [Staff.SName] " +
                    " FROM (db_owner.Classes inner join db_owner.Clients on db_owner.Clients.ClientID = db_owner.Classes.ClientID) inner join db_owner.Staff on db_owner.Staff.StaffID = db_owner.Classes.StaffID " +
                    " WHERE [db_owner.Clients.ClientID] = " + Convert.ToInt16(clientIDTextBox.Text);

                dtSchedule.Load(cmdF25_285.ExecuteReader());

                classesDataGridView.DataSource = dtSchedule;

                //this.classesTableAdapter.Fill(dtSchedule);

                cnnF25_285.Close();

                

            }
            catch (Exception ex) { }

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
