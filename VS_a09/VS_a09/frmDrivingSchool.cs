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

        //change this in App.config as well
        //private String connectionStr = @"Data Source=cissql;Initial Catalog=F25_285A;Integrated Security=True"; //School DBO
        private String connectionStr = @"Data Source=MACK\MCSQL;Initial Catalog=F25_285A;Integrated Security=True"; //Miguel's DBO
        private SqlConnection cnnF25_285; //generic insantiation of sql objects to be passed into methods
        private SqlCommand cmdF25_285;

        private void Form1_Load(object sender, EventArgs e) //Miguel
        {

            try //populates all tables and comboboxes
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
                MessageBox.Show("Fatal error connecting to the database, check your connection string.\n\n"+ex.ToString());
            
            }

        }

        //event handlers - miguel
        private void clientsTabUpdateDataGridHandler(object sender, EventArgs e) {
            //everytime a clientID is changed, it refreshes the datagridview with a new where clause,
            //this method also applies when adding a new client or scheduling a class and is sensitive to firing,
            //eliminating a lot of direct calls to refresh
            rdoMonthClients.Checked = true; //always sets timeframe to the next month when changing between clients

            try
            {                                                                                  //gets staff/clientID to filter data  clients   the value of the selected radio button

                dataGridViewAlter(cnnF25_285, cmdF25_285, classesDataGridView, connectionStr, Convert.ToInt16(clientIDTextBox.Text), 'c', rdoMonthClients.Text);
                clientsBindingSource.Position = Convert.ToInt16(clientIDTextBox.Text) - 1;

            }
            catch (FormatException) //prevents bug when adding clients
            {

                return;
            }
        }

        private void instructorsTabUpdateDataGridHandler(object sender, EventArgs e) //similar to above, for the instructor tab though
        {
            rdoMonthInstructors.Checked = true;
            dataGridViewAlter(cnnF25_285, cmdF25_285, classesDataGridView1, connectionStr, Convert.ToInt16(staffIDTextBox.Text), 'i', rdoMonthInstructors.Text);
            staffBindingSource.Position = Convert.ToInt16(staffIDTextBox.Text) - 1;
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
        private void timeframeClientRadioButtonUpdateGridHandler(object sender, EventArgs e) //similar to above, for the instructor tab though
        {
            try
            {
                //captures object sent as a radioButton (it always will be)
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked == false) { return; }//prevents from processing twice when a button gets unchecked and another gets checked
                dataGridViewAlter(cnnF25_285, cmdF25_285, classesDataGridView, connectionStr, Convert.ToInt16(clientIDTextBox.Text), 'c', radioButton.Text);
            }
            catch (Exception ex) {
                MessageBox.Show($"Issue sorting data, most likely with your connection to the database, check your connection string\n\n{ex.ToString()}");
                
                return; }

        }

        //timeframe selector and id selector - Jimmy and Miguel
        private static void dataGridViewAlter(SqlConnection cnnView, SqlCommand cmdSelect, DataGridView formsDataGrid, String cnnStr, int idParam, char clientOrInstructor, String timeframe)
        {
            
            //creates needed variables
            DataTable dtSchedule = new DataTable();
            String WHEREclause = "";

            switch (clientOrInstructor)//depending whether the clients or instructors tab called this method, it isolates the selected ID
            {
                case 'c':
                    WHEREclause = $"(Clients.ClientID = {idParam}) ";
                    break;
                case 'i':
                    WHEREclause = $"(Staff.StaffID = {idParam}) ";
                    break;
            }

            switch (timeframe) //depending which radio button is selected, it adjusts the where clause to isolate the respective time frame
            {
                case "Today":
                    WHEREclause += " AND (Classes.CDate BETWEEN GETDATE() AND DATEADD(day, 1, GETDATE()))";
                    break;
                case "This Week":
                    WHEREclause += " AND (Classes.CDate BETWEEN GETDATE() AND DATEADD(day, 6, GETDATE()))";
                    break;
                case "This Month":
                    WHEREclause += " AND (Classes.CDate BETWEEN GETDATE() AND DATEADD(day, 29, GETDATE()))";
                    break;
                //if all radiobutton was selected, doesnt filter where clause and selects all rows

            }
            //builds sql query with added where clause, that was decided above
            String sqlQuery = "SELECT Classes.CDate [Class Date], Classes.CTime [Class Time], Clients.CName [Client], Staff.SName [Staff] " +
                                 " FROM db_owner.Classes inner join db_owner.Clients on Clients.ClientID = Classes.ClientID inner join db_owner.Staff on Staff.StaffID = Classes.StaffID " +
                                 $" WHERE {WHEREclause}" +
                                 $" ORDER BY Classes.CDate, Classes.CTime";

            cnnView = new SqlConnection(cnnStr);
            cnnView.Open();

            cmdSelect = new SqlCommand(sqlQuery, cnnView);

            dtSchedule.Load(cmdSelect.ExecuteReader()); //retrieves and loads select query into a dataTable

            cnnView.Close();

            formsDataGrid.DataSource = dtSchedule; //loads the formDatGrid with the data table above

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


        private void btnScheduleClass_1_Click(object sender, EventArgs e) //changes tab
        {
                    tabControl_DONotEDIT.SelectTab("tabScheduleClass");
        }

        //Add client - Taras
        private void btnAddClientToDBO_Click(object sender, EventArgs e)
        {
            String lastName = txtLastName.Text.Trim();
            String firstName = txtFirstName.Text.Trim(); //stores the currently typed names

            if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName)) //checks if those txtboxes are empty
            {
                MessageBox.Show("Please enter both first and last names.");
                txtFirstName.Focus();
                return;
            }

            if (cboGender.SelectedItem == null) //ensures gender is selected
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
            String name = lastName + ", " + firstName; //builds full name in correct format

            String gender = cboGender.SelectedItem.ToString().Substring(0, 1); //stores just the first letter of the gender (M,F,or O)

            try
            {
                SqlConnection cnnF25_285 = new SqlConnection(connectionStr);
                cnnF25_285.Open();

                String sqlInsert = 
                $"INSERT INTO db_owner.Clients (CName, Age, Gender) " + //builds insert query with the validated data above
                $"VALUES ('{name}', {age}, '{gender}')";

                SqlCommand cmdInsert = new SqlCommand(sqlInsert, cnnF25_285);

                cmdInsert.ExecuteNonQuery(); //executes
                cnnF25_285.Close();

                MessageBox.Show($"Successfully Added {firstName} {lastName}, {cboGender.SelectedItem.ToString()}, Age {age}"); //confirmation screen

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
                //ensures textBoxes are in correct format
                if (!int.TryParse(staffIDTextBox1.Text, out int staffId))
                {
                    MessageBox.Show("Client selection is invalid.");
                    return;
                }

                if (!int.TryParse(clientIDTextBox1.Text, out int clientId))
                {
                    MessageBox.Show("Staff selection is invalid.");
                    return;
                }

                DateTime classDate = scheduleDatePicker.Value;

                if (classDate == null || classDate < DateTime.Now) //ensures class date isnt set in the past
                {
                    MessageBox.Show("Please select a valid class date.");
                    return;
                }

                if (!int.TryParse(cboPickClasstime.SelectedItem?.ToString().Trim(), out int classTime))
                {
                    MessageBox.Show("Please select a valid class time.");
                    return;
                }

                //builds insert query
                String strSqlClass =
                    "INSERT INTO db_owner.Classes (CDate, CTime, ClientID, StaffID) " +
                    $"VALUES (CAST('{classDate.ToString("yyyy-MM-dd")}' as DATE), {classTime}, {clientId}, {staffId})";
                //classdate gets formatted to drop the time at the end, prevents being able to make a class at the same time
                //builds query to check if that class 
                String strCheckExistence =
                     $"SELECT CDate, CTime, ClientID, StaffID " +
                    $" FROM db_owner.Classes " +
                    $" WHERE (CDate = CAST('{classDate.ToString("yyyy-MM-dd")}' as DATE)) AND (CTime = {classTime}) AND (StaffID = {staffId} OR ClientID = {clientId})";
                //checks if the instructor or client already has a class at that time
                try
                {
                    SqlConnection cnnF25_285 = new SqlConnection(connectionStr);
                    cnnF25_285.Open();

                    SqlCommand checkExistence = new SqlCommand(strCheckExistence, cnnF25_285);

                    if (checkExistence.ExecuteReader().HasRows)
                    {
                        cnnF25_285.Close();
                        MessageBox.Show("This instuctor or client already has a class scheduled for this date and time!");
                        return;
                    }
                    cnnF25_285.Close();

                    cnnF25_285.Open();
                    //inserts new class if the check passes
                    SqlCommand cmdInsertClass = new SqlCommand(strSqlClass, cnnF25_285);

                    cmdInsertClass.ExecuteNonQuery();

                    cnnF25_285.Close();

                    //confirmation screen
                    MessageBox.Show($"Successfully scheduled a class between {sNameComboBox.Text} and {cNameComboBox.Text} at {classTime} on {classDate.ToString("yyyy-MM-dd")}" );

                    staffBindingSource.Position = staffId;


                    this.clientsTableAdapter.Fill(this.f25_285ADataSet.Clients);

                    this.staffTableAdapter.Fill(this.f25_285ADataSet.Staff);

                    rdoAllInstructors.Checked = true;

                    tabControl_DONotEDIT.SelectTab("tabInstructors");
                    //these four lines reload data and redirect the user back to the instructors schedule


                }
                catch (ConstraintException ex) //prevents bug not loading data properly
                {
                    staffBindingSource.Position = clientId - 1;

                    this.clientsTableAdapter.Fill(this.f25_285ADataSet.Clients);

                    this.staffTableAdapter.Fill(this.f25_285ADataSet.Staff);

                    rdoAllInstructors.Checked = true;

                    tabControl_DONotEDIT.SelectTab("tabInstructors");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fatal Error Connecting to the Database\n\n" + ex.ToString());
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting class, make sure everthing is selected.\v\v" + ex.Message);
            }
        }



        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.f25_285ADataSet);

        }

    }
}


        


