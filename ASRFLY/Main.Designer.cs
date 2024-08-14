namespace ASRFLY
{
    partial class Main
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonHome = new Button();
            buttonCategory = new Button();
            buttonCustomers = new Button();
            buttonSuppliers = new Button();
            buttonProjects = new Button();
            buttonUsers = new Button();
            buttonSettings = new Button();
            buttonLogout = new Button();
            buttonHelp = new Button();
            buttonAbout = new Button();
            panelContainer = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(buttonHome);
            flowLayoutPanel1.Controls.Add(buttonCategory);
            flowLayoutPanel1.Controls.Add(buttonCustomers);
            flowLayoutPanel1.Controls.Add(buttonSuppliers);
            flowLayoutPanel1.Controls.Add(buttonProjects);
            flowLayoutPanel1.Controls.Add(buttonUsers);
            flowLayoutPanel1.Controls.Add(buttonSettings);
            flowLayoutPanel1.Controls.Add(buttonLogout);
            flowLayoutPanel1.Controls.Add(buttonHelp);
            flowLayoutPanel1.Controls.Add(buttonAbout);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 600);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(1262, 73);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonHome
            // 
            buttonHome.Image = Properties.Resources.Home;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(1061, 10);
            buttonHome.Margin = new Padding(5);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(165, 55);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "الرئيسية";
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonCategory
            // 
            buttonCategory.Image = Properties.Resources.Categorize;
            buttonCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCategory.Location = new Point(886, 10);
            buttonCategory.Margin = new Padding(5);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Size = new Size(165, 55);
            buttonCategory.TabIndex = 1;
            buttonCategory.Text = "الاصناف";
            buttonCategory.UseVisualStyleBackColor = true;
            // 
            // buttonCustomers
            // 
            buttonCustomers.Image = Properties.Resources.Crowd;
            buttonCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCustomers.Location = new Point(711, 10);
            buttonCustomers.Margin = new Padding(5);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(165, 55);
            buttonCustomers.TabIndex = 2;
            buttonCustomers.Text = "العملاء";
            buttonCustomers.UseVisualStyleBackColor = true;
            // 
            // buttonSuppliers
            // 
            buttonSuppliers.Image = Properties.Resources.Crowd_1;
            buttonSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSuppliers.Location = new Point(536, 10);
            buttonSuppliers.Margin = new Padding(5);
            buttonSuppliers.Name = "buttonSuppliers";
            buttonSuppliers.Size = new Size(165, 55);
            buttonSuppliers.TabIndex = 3;
            buttonSuppliers.Text = "الموردين";
            buttonSuppliers.UseVisualStyleBackColor = true;
            // 
            // buttonProjects
            // 
            buttonProjects.Image = Properties.Resources.Microsoft_Project;
            buttonProjects.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProjects.Location = new Point(361, 10);
            buttonProjects.Margin = new Padding(5);
            buttonProjects.Name = "buttonProjects";
            buttonProjects.Size = new Size(165, 55);
            buttonProjects.TabIndex = 4;
            buttonProjects.Text = "المشاريع";
            buttonProjects.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            buttonUsers.Image = Properties.Resources.Users;
            buttonUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUsers.Location = new Point(186, 10);
            buttonUsers.Margin = new Padding(5);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(165, 55);
            buttonUsers.TabIndex = 5;
            buttonUsers.Text = "    المستخدمين";
            // 
            // buttonSettings
            // 
            buttonSettings.Image = Properties.Resources.Settings;
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(11, 10);
            buttonSettings.Margin = new Padding(5);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(165, 55);
            buttonSettings.TabIndex = 6;
            buttonSettings.Text = "الاعدادات";
            buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            buttonLogout.Image = Properties.Resources.Logout_1;
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(1061, 75);
            buttonLogout.Margin = new Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(165, 55);
            buttonLogout.TabIndex = 7;
            buttonLogout.Text = "خروج";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = Properties.Resources.Help;
            buttonHelp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHelp.Location = new Point(886, 75);
            buttonHelp.Margin = new Padding(5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(165, 55);
            buttonHelp.TabIndex = 8;
            buttonHelp.Text = "المساعدة ";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            buttonAbout.Image = Properties.Resources.About;
            buttonAbout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbout.Location = new Point(711, 75);
            buttonAbout.Margin = new Padding(5);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(165, 55);
            buttonAbout.TabIndex = 9;
            buttonAbout.Text = "حول";
            buttonAbout.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1262, 600);
            panelContainer.TabIndex = 0;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelContainer);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "Main";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonCategory;
        private Button buttonCustomers;
        private Button buttonSuppliers;
        private Button buttonProjects;
        private Button buttonUsers;
        private Button buttonSettings;
        private Button buttonLogout;
        private Button buttonHelp;
        private Button buttonAbout;
        private Button buttonHome;
        public Panel panelContainer;
    }
}
