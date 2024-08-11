namespace ASRFLY.Gui.GuiHome
{
    partial class HomeUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            buttonAddInput = new Button();
            buttonAddOutput = new Button();
            buttonAddUser = new Button();
            buttonAddProject = new Button();
            buttonAddSupplier = new Button();
            buttonAddCustomer = new Button();
            buttonAddCategory = new Button();
            label1 = new Label();
            panel2 = new Panel();
            pictureBoxLogo = new PictureBox();
            labelCompanyName = new Label();
            labelWellcome = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 401);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 199);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Smart_1;
            pictureBox1.Location = new Point(454, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(buttonAddInput);
            groupBox1.Controls.Add(buttonAddOutput);
            groupBox1.Controls.Add(buttonAddUser);
            groupBox1.Controls.Add(buttonAddProject);
            groupBox1.Controls.Add(buttonAddSupplier);
            groupBox1.Controls.Add(buttonAddCustomer);
            groupBox1.Controls.Add(buttonAddCategory);
            groupBox1.Location = new Point(91, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(951, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "اضافة";
            // 
            // buttonAddInput
            // 
            buttonAddInput.BackColor = Color.White;
            buttonAddInput.Image = Properties.Resources.Import;
            buttonAddInput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddInput.Location = new Point(18, 46);
            buttonAddInput.Margin = new Padding(5);
            buttonAddInput.Name = "buttonAddInput";
            buttonAddInput.Size = new Size(123, 60);
            buttonAddInput.TabIndex = 1;
            buttonAddInput.Text = "قبض";
            buttonAddInput.TextAlign = ContentAlignment.MiddleRight;
            buttonAddInput.UseVisualStyleBackColor = false;
            // 
            // buttonAddOutput
            // 
            buttonAddOutput.BackColor = Color.White;
            buttonAddOutput.Image = Properties.Resources.Export_1;
            buttonAddOutput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddOutput.Location = new Point(149, 46);
            buttonAddOutput.Margin = new Padding(5);
            buttonAddOutput.Name = "buttonAddOutput";
            buttonAddOutput.Size = new Size(123, 60);
            buttonAddOutput.TabIndex = 1;
            buttonAddOutput.Text = "صرف";
            buttonAddOutput.TextAlign = ContentAlignment.MiddleRight;
            buttonAddOutput.UseVisualStyleBackColor = false;
            // 
            // buttonAddUser
            // 
            buttonAddUser.BackColor = Color.White;
            buttonAddUser.Image = Properties.Resources.Crowd;
            buttonAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddUser.Location = new Point(280, 46);
            buttonAddUser.Margin = new Padding(5);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(123, 60);
            buttonAddUser.TabIndex = 1;
            buttonAddUser.Text = "مستخدم";
            buttonAddUser.TextAlign = ContentAlignment.MiddleRight;
            buttonAddUser.UseVisualStyleBackColor = false;
            // 
            // buttonAddProject
            // 
            buttonAddProject.BackColor = Color.White;
            buttonAddProject.Image = Properties.Resources.Microsoft_Project;
            buttonAddProject.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddProject.Location = new Point(411, 46);
            buttonAddProject.Margin = new Padding(5);
            buttonAddProject.Name = "buttonAddProject";
            buttonAddProject.Size = new Size(123, 60);
            buttonAddProject.TabIndex = 1;
            buttonAddProject.Text = "مشروع";
            buttonAddProject.TextAlign = ContentAlignment.MiddleRight;
            buttonAddProject.UseVisualStyleBackColor = false;
            // 
            // buttonAddSupplier
            // 
            buttonAddSupplier.BackColor = Color.White;
            buttonAddSupplier.Image = Properties.Resources.Crowd_1;
            buttonAddSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddSupplier.Location = new Point(542, 46);
            buttonAddSupplier.Margin = new Padding(5);
            buttonAddSupplier.Name = "buttonAddSupplier";
            buttonAddSupplier.Size = new Size(123, 60);
            buttonAddSupplier.TabIndex = 1;
            buttonAddSupplier.Text = "مورد";
            buttonAddSupplier.UseVisualStyleBackColor = false;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.BackColor = Color.White;
            buttonAddCustomer.Image = Properties.Resources.Users;
            buttonAddCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCustomer.Location = new Point(673, 46);
            buttonAddCustomer.Margin = new Padding(5);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(123, 60);
            buttonAddCustomer.TabIndex = 1;
            buttonAddCustomer.Text = "     عميل";
            buttonAddCustomer.UseVisualStyleBackColor = false;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.BackColor = Color.White;
            buttonAddCategory.Image = Properties.Resources.Categorize;
            buttonAddCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCategory.Location = new Point(804, 46);
            buttonAddCategory.Margin = new Padding(5);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(123, 60);
            buttonAddCategory.TabIndex = 1;
            buttonAddCategory.Text = "    صنف";
            buttonAddCategory.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(517, 12);
            label1.Name = "label1";
            label1.Size = new Size(205, 56);
            label1.TabIndex = 0;
            label1.Text = "الوصول السريع";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Controls.Add(labelCompanyName);
            panel2.Location = new Point(411, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(486, 125);
            panel2.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Right;
            pictureBoxLogo.Image = Properties.Resources.Ruby_2;
            pictureBoxLogo.Location = new Point(368, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(118, 125);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Font = new Font("Cairo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCompanyName.Location = new Point(3, 0);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(362, 125);
            labelCompanyName.TabIndex = 0;
            labelCompanyName.Text = "قناة تكنو U";
            labelCompanyName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelWellcome
            // 
            labelWellcome.Font = new Font("Cairo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWellcome.Location = new Point(158, 147);
            labelWellcome.Name = "labelWellcome";
            labelWellcome.Size = new Size(205, 56);
            labelWellcome.TabIndex = 0;
            labelWellcome.Text = "مرحبا بك";
            labelWellcome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(labelWellcome);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "HomeUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1262, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button buttonAddCategory;
        private GroupBox groupBox1;
        private Button buttonAddSupplier;
        private Button buttonAddCustomer;
        private Button buttonAddUser;
        private Button buttonAddProject;
        private Button buttonAddInput;
        private Button buttonAddOutput;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBoxLogo;
        private Label labelCompanyName;
        private Label labelWellcome;
    }
}
