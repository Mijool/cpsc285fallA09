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
using System.Data.SqlTypes;


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



        

        private SqlConnection cnnF25_285;
        private SqlCommand cmdF25_285;


        //change this in App.config as well
        //private String connectionStr = @"Data Source=cissql;Initial Catalog=F25_285A;Integrated Security=True"; //School DBO
        private String connectionStr = @"Data Source=MACK\MCSQL;Initial Catalog=F25_285A;Integrated Security=True"; //Miguel's DBO



        private void Form1_Load(object sender, EventArgs e)
        {
            


            try
            {
                this.staffTableAdapter.Fill(this.f25_285ADataSet.Staff);
                this.clientsTableAdapter.Fill(this.f25_285ADataSet.Clients);

                for (int i = 800; i <= 1600; i += 70)
                {
                    cboPickClasstime.Items.Add(i.ToString());
                    i += 30;
                    cboPickClasstime.Items.Add(i.ToString());

                }

                cboPickClasstime.SelectedIndex = 0;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            
            }

        }


        private void clientsTabUpdateDataGridHandler(object sender, EventArgs e) {
            rdoMonthClients.Checked = true;
            try
            {
                dataGridViewAlter(cnnF25_285, cmdF25_285, classesDataGridView, connectionStr, Convert.ToInt16(clientIDTextBox.Text), 'c', rdoMonthClients.Text);
            }
            catch (FormatException) //prevents bug when adding clients
            {
                return;
            }

            }

        private void instructorsTabUpdateDataGridHandler(object sender, EventArgs e)
        {
            rdoMonthInstructors.Checked = true;
            dataGridViewAlter(cnnF25_285, cmdF25_285, classesDataGridView1, connectionStr, Convert.ToInt16(staffIDTextBox.Text), 'i', rdoMonthInstructors.Text);
        }

        private void timeframeInstructorRadioButtonUpdateGridHandler(object sender, EventArgs e)
        {
            try
            {
                //captures object sent as a radioButton (it always will be)
                RadioButton radioButton = (RadioButton) sender;
               if (radioButton.Checked == false) { return; }//prevents from processing twice when a button gets unchecked and another gets checked
                dataGridViewAlter(cnnF25_285, cmdF25_285, classesDataGridView1, connectionStr, Convert.ToInt16(staffIDTextBox.Text), 'i', radioButton.Text);
            }
            catch { return; }




        }
        private void timeframeClientRadioButtonUpdateGridHandler(object sender, EventArgs e)
        {
            try
            {
                //captures object sent as a radioButton (it always will be)
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked == false) { return; }//prevents from processing twice when a button gets unchecked and another gets checked
                dataGridViewAlter(cnnF25_285, cmdF25_285, classesDataGridView, connectionStr, Convert.ToInt16(clientIDTextBox.Text), 'c', radioButton.Text);
            }
            catch { return; }

        }

        private static void dataGridViewAlter(SqlConnection cnnView, SqlCommand cmdSelect, DataGridView formsDataGrid, String cnnStr, int idParam, char clientOrInstructor, String timeframe)
        {
            cnnView = new SqlConnection(cnnStr);
            cnnView.Open();

            DataTable dtSchedule = new DataTable();
            String WHEREclause = "";

            switch (clientOrInstructor)
            {
                case 'c':
                    WHEREclause = $"(Clients.ClientID = {idParam}) ";
                    break;
                case 'i':
                    WHEREclause = $"(Staff.StaffID = {idParam}) ";
                    break;
            }

            switch (timeframe)
            {
                case "Today":
                    WHEREclause += " AND (Classes.CDate = GETDATE())";

                    break;
                case "This Week":

                    WHEREclause += " AND (Classes.CDate BETWEEN GETDATE() AND DATEADD(day, 6, GETDATE()))";

                    break;
                case "This Month":
                    WHEREclause += " AND (Classes.CDate BETWEEN GETDATE() AND DATEADD(day, 29, GETDATE()))";

                    break;
                case "All":

                    break;

            }



            String sqlQuery = "SELECT Classes.CDate [Class Date], Classes.CTime [Class Time], Clients.CName [Client], Staff.SName [Staff] " +
                                 " FROM db_owner.Classes inner join db_owner.Clients on Clients.ClientID = Classes.ClientID inner join db_owner.Staff on Staff.StaffID = Classes.StaffID " +
                                 $" WHERE {WHEREclause}" +
                                 $" ORDER BY Classes.CTime";

            cmdSelect = new SqlCommand(sqlQuery, cnnView);



            dtSchedule.Load(cmdSelect.ExecuteReader());

            cnnView.Close();

            //dtSchedule.Columns["Class Time"].DataType = typeof(DateTime);

            formsDataGrid.DataSource = dtSchedule;

            //formsDataGrid.Columns["Class Time"].DefaultCellStyle.Format = "HH:mm";



        }



        private void btnScheduleClass_Click(object sender, EventArgs e) //changes tab
        {

            tabControl_DONotEDIT.SelectTab("tabScheduleClass");
        }

        private void btnAddClient_Click(object sender, EventArgs e) //changes tab
        {
            tabControl_DONotEDIT.SelectTab("tabAddClients");
        }
        
        
        //Instructors Tab - should all use the same method


        private void btnScheduleClass_1_Click(object sender, EventArgs e) //changes tabb
        {
                    tabControl_DONotEDIT.SelectTab("tabScheduleClass");
        }

        //Add client - Taras
        private void btnAddClientToDBO_Click(object sender, EventArgs e)
        {
            String lastName = txtLastName.Text.Trim();
            String firstName = txtFirstName.Text.Trim();    //validation first

            if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Please enter both first and last names.");
                txtFirstName.Focus();
                return;
            }

            if (cboGender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.");
                cboGender.Focus();
                return;
            }
            if (!int.TryParse(txtAge.Text.Trim(), out int age) || age <= 0)  // Age validation with TryParse 
            {
                MessageBox.Show("Please enter a valid age (number greater than 0).");
                txtAge.Focus();
                return;
            }
            String name = lastName + ", " + firstName;

            String gender = cboGender.SelectedItem.ToString().Substring(0, 1);

            try
            {
                SqlConnection cnnF25_285 = new SqlConnection(connectionStr);
                cnnF25_285.Open();

                String sqlInsert =
                $"INSERT INTO db_owner.Clients (CName, Age, Gender) " +
                $"VALUES ('{name}', {age}, '{gender}')";

                SqlCommand cmdInsert = new SqlCommand(sqlInsert, cnnF25_285);

                cmdInsert.ExecuteNonQuery();
                cnnF25_285.Close();

                MessageBox.Show($"Successfully Added {firstName} {lastName}, {cboGender.SelectedItem.ToString()}, Age {age}");

                this.clientsTableAdapter.Fill(this.f25_285ADataSet.Clients); // Reload the Clients table so bindings / combo boxes see the new row
                
                clientsBindingSource.Position = clientsBindingSource.Count; //sets the clients tab to view the newest client added (position = end of list)
                
                tabControl_DONotEDIT.SelectTab("tabClients");
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding client make sure information is filled properly.\v\v" + ex.Message);
            }
            
            
        }


        //Schedule a new Class - Isai
        private void btnInsertScheduledClass_Click(object sender, EventArgs e)
        {

            try
            {

                if (!int.TryParse(cNameComboBox.SelectedValue?.ToString(), out int clientId))
                {
                    MessageBox.Show("Client selection is invalid.");
                    return;
                }

                if (!int.TryParse(sNameComboBox.SelectedValue?.ToString(), out int staffId))
                {
                    MessageBox.Show("Staff selection is invalid.");
                    return;
                }

                DateTime classDate = scheduleDatePicker.Value;

                if (!int.TryParse(cboPickClasstime.SelectedItem?.ToString().Trim(), out int classTime))
                {
                    MessageBox.Show("Please select a valid class time.");
                    return;
                }
                String strSqlClass =
                    "INSERT INTO db_owner.Classes (CDate, CTime, ClientID, StaffID) " +
                    $"VALUES (CAST('{classDate}' as DATE), {classTime}, {clientId}, {staffId})";

                String strCheckExistence =
                     $"SELECT CDate, CTime, ClientID, StaffID " +
                    $" FROM db_owner.Classes " +
                    $" WHERE (CDate = CAST('{classDate}' as DATE)) AND (CTime = {classTime}) AND (ClientID = {clientId}) AND (StaffID = {staffId})";

                try
                {
                    SqlConnection cnnF25_285 = new SqlConnection(connectionStr);
                    cnnF25_285.Open();

                    SqlCommand checkExistence = new SqlCommand(strCheckExistence, cnnF25_285);

                    if (checkExistence.ExecuteReader().HasRows)
                    {
                        cnnF25_285.Close();
                        MessageBox.Show("These two already have a class schedule for this date and time!");
                        return;
                    }
                    cnnF25_285.Close();
                    cnnF25_285.Open();
                    SqlCommand cmdInsertClass = new SqlCommand(strSqlClass, cnnF25_285);

                    cmdInsertClass.ExecuteNonQuery();

                    cnnF25_285.Close();


                    this.classesTableAdapter.Fill(this.f25_285ADataSet.Classes);

                    MessageBox.Show($"Successfully scheduled a class between {sNameComboBox.Text} and {cNameComboBox.Text} at {classTime.ToString()} on {classDate.ToString()}" );

                    tabControl_DONotEDIT.SelectTab("tabInstructors");



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fatal Error Connecting to the Database\v\v" + ex.ToString());
                    return;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting class, make sure everthing is selected.\v\v" + ex.Message);
            }
        }

    }
}


        


