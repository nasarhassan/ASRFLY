namespace ASRFLY.Gui.GuiGategories
{
    partial class AddCategoryForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonSave = new Button();
            buttonSaveAndClose = new Button();
            groupBox1 = new GroupBox();
            richTextBoxDetails = new RichTextBox();
            comboBoxType = new ComboBox();
            textBoxBalance = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 724);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 108);
            panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.Save;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(14, 26);
            buttonSave.Margin = new Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(5);
            buttonSave.Size = new Size(179, 55);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "حفظ";
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.Image = Properties.Resources.Save_1;
            buttonSaveAndClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new Point(644, 26);
            buttonSaveAndClose.Margin = new Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Padding = new Padding(5);
            buttonSaveAndClose.Size = new Size(179, 55);
            buttonSaveAndClose.TabIndex = 2;
            buttonSaveAndClose.Text = "     حفظ و غلق";
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBoxDetails);
            groupBox1.Controls.Add(comboBoxType);
            groupBox1.Controls.Add(textBoxBalance);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1046, 679);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الصنف";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new Point(284, 326);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new Size(674, 246);
            richTextBoxDetails.TabIndex = 3;
            richTextBoxDetails.Text = "";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "صرف", "قبض" });
            comboBoxType.Location = new Point(284, 214);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(674, 45);
            comboBoxType.TabIndex = 2;
            // 
            // textBoxBalance
            // 
            textBoxBalance.Enabled = false;
            textBoxBalance.Location = new Point(284, 628);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(674, 45);
            textBoxBalance.TabIndex = 1;
            textBoxBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 575);
            label4.Name = "label4";
            label4.Size = new Size(67, 37);
            label4.TabIndex = 0;
            label4.Text = "الرصيد";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(562, 286);
            label3.Name = "label3";
            label3.Size = new Size(89, 37);
            label3.TabIndex = 0;
            label3.Text = "التفاصيل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(547, 163);
            label2.Name = "label2";
            label2.Size = new Size(104, 37);
            label2.TabIndex = 0;
            label2.Text = "نوع الصنف";
            label2.Click += label2_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(284, 91);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(674, 45);
            textBoxName.TabIndex = 1;
            textBoxName.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(540, 41);
            label1.Name = "label1";
            label1.Size = new Size(111, 37);
            label1.TabIndex = 0;
            label1.Text = "اسم الصنف";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 832);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 6, 4, 6);
            MinimizeBox = false;
            Name = "AddCategoryForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة/تعديل صنف";
            TopMost = true;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBoxName;
        private ComboBox comboBoxType;
        private TextBox textBoxBalance;
        private Label label4;
        private RichTextBox richTextBoxDetails;
        private Button buttonSave;
        private Button buttonSaveAndClose;
    }
}