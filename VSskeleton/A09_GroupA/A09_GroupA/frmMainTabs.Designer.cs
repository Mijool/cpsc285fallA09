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
            Tabs = new System.Windows.Forms.TabControl();
            tbInstructors = new System.Windows.Forms.TabPage();
            tbClients = new System.Windows.Forms.TabPage();
            tbAddClient = new System.Windows.Forms.TabPage();
            Tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.Controls.Add(tbInstructors);
            Tabs.Controls.Add(tbClients);
            Tabs.Controls.Add(tbAddClient);
            Tabs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Tabs.Location = new System.Drawing.Point(0, 0);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new System.Drawing.Size(802, 448);
            Tabs.TabIndex = 0;
            // 
            // tbInstructors
            // 
            tbInstructors.Location = new System.Drawing.Point(4, 29);
            tbInstructors.Name = "tbInstructors";
            tbInstructors.Padding = new System.Windows.Forms.Padding(3);
            tbInstructors.Size = new System.Drawing.Size(794, 415);
            tbInstructors.TabIndex = 0;
            tbInstructors.Text = "Instructors";
            tbInstructors.UseVisualStyleBackColor = true;
            // 
            // tbClients
            // 
            tbClients.Location = new System.Drawing.Point(4, 29);
            tbClients.Name = "tbClients";
            tbClients.Padding = new System.Windows.Forms.Padding(3);
            tbClients.Size = new System.Drawing.Size(794, 415);
            tbClients.TabIndex = 1;
            tbClients.Text = "Clients";
            tbClients.UseVisualStyleBackColor = true;
            // 
            // tbAddClient
            // 
            tbAddClient.Location = new System.Drawing.Point(4, 29);
            tbAddClient.Name = "tbAddClient";
            tbAddClient.Padding = new System.Windows.Forms.Padding(3);
            tbAddClient.Size = new System.Drawing.Size(794, 415);
            tbAddClient.TabIndex = 2;
            tbAddClient.Text = "Add Client";
            tbAddClient.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(Tabs);
            this.Name = "frmMain";
            this.Text = "A09 - Driving School";
            Tabs.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs;
        private TabPage tbInstructors;
        private TabPage tbClients;
        private TabPage tbAddClient;
    }
}