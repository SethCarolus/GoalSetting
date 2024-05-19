using Microsoft.VisualBasic.Devices;

namespace GoalSettingApplication
{
    partial class GoalInputForm
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
            closeButton = new Button();
            InputFormCloseButton = new Button();
            tbGoalName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbDescription = new TextBox();
            label3 = new Label();
            dtpDueDate = new DateTimePicker();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(34, 35, 50);
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold);
            closeButton.ForeColor = Color.Transparent;
            closeButton.Location = new Point(751, 0);
            closeButton.Margin = new Padding(3, 4, 3, 4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(1117, 948);
            closeButton.TabIndex = 2;
            closeButton.Text = "x";
            closeButton.UseVisualStyleBackColor = false;
            // 
            // InputFormCloseButton
            // 
            InputFormCloseButton.BackColor = Color.FromArgb(34, 35, 50);
            InputFormCloseButton.FlatAppearance.BorderSize = 0;
            InputFormCloseButton.FlatStyle = FlatStyle.Flat;
            InputFormCloseButton.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold);
            InputFormCloseButton.ForeColor = Color.Transparent;
            InputFormCloseButton.Location = new Point(447, 1);
            InputFormCloseButton.Margin = new Padding(3, 4, 3, 4);
            InputFormCloseButton.Name = "InputFormCloseButton";
            InputFormCloseButton.Size = new Size(49, 47);
            InputFormCloseButton.TabIndex = 3;
            InputFormCloseButton.Text = "x";
            InputFormCloseButton.UseVisualStyleBackColor = false;
            InputFormCloseButton.Click += InputFormCloseButton_Click;
            // 
            // tbGoalName
            // 
            tbGoalName.BackColor = Color.FromArgb(49, 50, 72);
            tbGoalName.BorderStyle = BorderStyle.None;
            tbGoalName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbGoalName.ForeColor = Color.White;
            tbGoalName.Location = new Point(32, 113);
            tbGoalName.Name = "tbGoalName";
            tbGoalName.Size = new Size(429, 31);
            tbGoalName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 65);
            label1.Name = "label1";
            label1.Size = new Size(133, 31);
            label1.TabIndex = 5;
            label1.Text = "Goal Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 167);
            label2.Name = "label2";
            label2.Size = new Size(136, 31);
            label2.TabIndex = 6;
            label2.Text = "Description:";
            // 
            // tbDescription
            // 
            tbDescription.BackColor = Color.FromArgb(49, 50, 72);
            tbDescription.BorderStyle = BorderStyle.None;
            tbDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDescription.ForeColor = Color.White;
            tbDescription.Location = new Point(29, 212);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(429, 188);
            tbDescription.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 416);
            label3.Name = "label3";
            label3.Size = new Size(108, 31);
            label3.TabIndex = 8;
            label3.Text = "DueDate:";
            // 
            // dtpDueDate
            // 
            dtpDueDate.CalendarForeColor = Color.White;
            dtpDueDate.CalendarMonthBackground = Color.FromArgb(49, 50, 72);
            dtpDueDate.CalendarTitleBackColor = Color.FromArgb(49, 50, 72);
            dtpDueDate.CalendarTitleForeColor = Color.FromArgb(49, 50, 72);
            dtpDueDate.DropDownAlign = LeftRightAlignment.Right;
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(32, 468);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(250, 27);
            dtpDueDate.TabIndex = 9;
            // 
            // GoalInputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 35, 50);
            ClientSize = new Size(496, 527);
            Controls.Add(dtpDueDate);
            Controls.Add(label3);
            Controls.Add(tbDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbGoalName);
            Controls.Add(InputFormCloseButton);
            Controls.Add(closeButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GoalInputForm";
            Text = "GoalInputForm";
            Load += GoalInputForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private Button InputFormCloseButton;
        private TextBox tbGoalName;
        private Label label1;
        private Label label2;
        private TextBox tbDescription;
        private Label label3;
        private DateTimePicker dtpDueDate;
    }
}