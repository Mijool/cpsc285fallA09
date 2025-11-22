namespace A09_GroupA
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Tabs = new TabControl();
            tbInstructors = new TabPage();
            tbClients = new TabPage();
            tbAddClient = new TabPage();
            button1 = new Button();
            Tabs.SuspendLayout();
            tbInstructors.SuspendLayout();
            SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.Controls.Add(tbInstructors);
            Tabs.Controls.Add(tbClients);
            Tabs.Controls.Add(tbAddClient);
            Tabs.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Tabs.Location = new Point(0, 0);
            Tabs.Margin = new Padding(3, 4, 3, 4);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(917, 597);
            Tabs.TabIndex = 0;
            // 
            // tbInstructors
            // 
            tbInstructors.Controls.Add(button1);
            tbInstructors.Location = new Point(4, 34);
            tbInstructors.Margin = new Padding(3, 4, 3, 4);
            tbInstructors.Name = "tbInstructors";
            tbInstructors.Padding = new Padding(3, 4, 3, 4);
            tbInstructors.Size = new Size(909, 559);
            tbInstructors.TabIndex = 0;
            tbInstructors.Text = "Instructors";
            tbInstructors.UseVisualStyleBackColor = true;
            // 
            // tbClients
            // 
            tbClients.Location = new Point(4, 34);
            tbClients.Margin = new Padding(3, 4, 3, 4);
            tbClients.Name = "tbClients";
            tbClients.Padding = new Padding(3, 4, 3, 4);
            tbClients.Size = new Size(909, 559);
            tbClients.TabIndex = 1;
            tbClients.Text = "Clients";
            tbClients.UseVisualStyleBackColor = true;
            // 
            // tbAddClient
            // 
            tbAddClient.Location = new Point(4, 34);
            tbAddClient.Margin = new Padding(3, 4, 3, 4);
            tbAddClient.Name = "tbAddClient";
            tbAddClient.Padding = new Padding(3, 4, 3, 4);
            tbAddClient.Size = new Size(909, 559);
            tbAddClient.TabIndex = 2;
            tbAddClient.Text = "Add Client";
            tbAddClient.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(574, 97);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Tabs);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            Text = "A09 - Driving School";
            Tabs.ResumeLayout(false);
            tbInstructors.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs;
        private TabPage tbInstructors;
        private TabPage tbClients;
        private TabPage tbAddClient;
        private Button button1;
    }
}