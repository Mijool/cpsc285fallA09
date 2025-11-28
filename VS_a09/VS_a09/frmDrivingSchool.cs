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
            changeScheduleTimeSpan("today");
        }

        private void rdoWeekClients_CheckedChanged(object sender, EventArgs e)
        {
            changeScheduleTimeSpan("week");
        }

        private void rdoMonthClients_CheckedChanged(object sender, EventArgs e)
        {
            changeScheduleTimeSpan("month");
        }

        private void btnScheduleClass_Click(object sender, EventArgs e) //changes tab
        {
            tabScheduleClass.Focus();
        }

        private void btnAddClient_Click(object sender, EventArgs e) //changes tab
        {
            tabAddClients.Focus();
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
            tabScheduleClass.Focus();
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

       



        //Add client

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

        

        //Schedule a new Class
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

    }
}
