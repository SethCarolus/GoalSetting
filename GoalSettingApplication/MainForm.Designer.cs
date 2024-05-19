namespace GoalSettingApplication
{
    partial class GoalSettingForm
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
            panel1 = new Panel();
            EditGoalButton = new Button();
            RemoveGoalButton = new Button();
            AddGoalButton = new Button();
            GoalListBox = new ListBox();
            label2 = new Label();
            closeButton = new Button();
            panel2 = new Panel();
            DueDateLabel = new Label();
            label1 = new Label();
            goalNameLabel = new Label();
            GoalDescriptionRichText = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 50, 72);
            panel1.Controls.Add(EditGoalButton);
            panel1.Controls.Add(RemoveGoalButton);
            panel1.Controls.Add(AddGoalButton);
            panel1.Controls.Add(GoalListBox);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 948);
            panel1.TabIndex = 0;
            // 
            // EditGoalButton
            // 
            EditGoalButton.BackColor = Color.FromArgb(34, 35, 50);
            EditGoalButton.FlatAppearance.BorderSize = 0;
            EditGoalButton.FlatStyle = FlatStyle.Flat;
            EditGoalButton.ForeColor = Color.White;
            EditGoalButton.Location = new Point(14, 829);
            EditGoalButton.Margin = new Padding(3, 4, 3, 4);
            EditGoalButton.Name = "EditGoalButton";
            EditGoalButton.Size = new Size(197, 59);
            EditGoalButton.TabIndex = 6;
            EditGoalButton.Text = "Edit";
            EditGoalButton.UseVisualStyleBackColor = false;
            EditGoalButton.Click += EditGoalButton_Click;
            // 
            // RemoveGoalButton
            // 
            RemoveGoalButton.BackColor = Color.FromArgb(34, 35, 50);
            RemoveGoalButton.FlatAppearance.BorderSize = 0;
            RemoveGoalButton.FlatStyle = FlatStyle.Flat;
            RemoveGoalButton.ForeColor = Color.White;
            RemoveGoalButton.Location = new Point(14, 763);
            RemoveGoalButton.Margin = new Padding(3, 4, 3, 4);
            RemoveGoalButton.Name = "RemoveGoalButton";
            RemoveGoalButton.Size = new Size(197, 59);
            RemoveGoalButton.TabIndex = 5;
            RemoveGoalButton.Text = "Remove";
            RemoveGoalButton.UseVisualStyleBackColor = false;
            RemoveGoalButton.Click += RemoveGoalButton_Click;
            // 
            // AddGoalButton
            // 
            AddGoalButton.BackColor = Color.FromArgb(34, 35, 50);
            AddGoalButton.FlatAppearance.BorderSize = 0;
            AddGoalButton.FlatStyle = FlatStyle.Flat;
            AddGoalButton.ForeColor = Color.White;
            AddGoalButton.Location = new Point(14, 696);
            AddGoalButton.Margin = new Padding(3, 4, 3, 4);
            AddGoalButton.Name = "AddGoalButton";
            AddGoalButton.Size = new Size(197, 59);
            AddGoalButton.TabIndex = 4;
            AddGoalButton.Text = "Add";
            AddGoalButton.UseVisualStyleBackColor = false;
            AddGoalButton.Click += AddGoalButton_Click;
            // 
            // GoalListBox
            // 
            GoalListBox.BackColor = Color.FromArgb(34, 35, 50);
            GoalListBox.BorderStyle = BorderStyle.None;
            GoalListBox.ColumnWidth = 5;
            GoalListBox.ForeColor = Color.White;
            GoalListBox.FormattingEnabled = true;
            GoalListBox.HorizontalScrollbar = true;
            GoalListBox.ItemHeight = 32;
            GoalListBox.Location = new Point(14, 75);
            GoalListBox.Margin = new Padding(3, 4, 3, 4);
            GoalListBox.Name = "GoalListBox";
            GoalListBox.Size = new Size(197, 576);
            GoalListBox.TabIndex = 3;
            GoalListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            GoalListBox.Enter += listBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(67, 12);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 2;
            label2.Text = "Goals";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(34, 35, 50);
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold);
            closeButton.ForeColor = Color.Transparent;
            closeButton.Location = new Point(1062, 5);
            closeButton.Margin = new Padding(3, 4, 3, 4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(49, 47);
            closeButton.TabIndex = 1;
            closeButton.Text = "x";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(DueDateLabel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(goalNameLabel);
            panel2.Controls.Add(GoalDescriptionRichText);
            panel2.Location = new Point(258, 81);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(813, 760);
            panel2.TabIndex = 2;
            // 
            // DueDateLabel
            // 
            DueDateLabel.AutoSize = true;
            DueDateLabel.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold);
            DueDateLabel.ForeColor = Color.White;
            DueDateLabel.Location = new Point(152, 712);
            DueDateLabel.Name = "DueDateLabel";
            DueDateLabel.Size = new Size(0, 32);
            DueDateLabel.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 712);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 4;
            label1.Text = "Due Date:";
            // 
            // goalNameLabel
            // 
            goalNameLabel.AutoSize = true;
            goalNameLabel.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold);
            goalNameLabel.ForeColor = Color.White;
            goalNameLabel.Location = new Point(18, 20);
            goalNameLabel.Name = "goalNameLabel";
            goalNameLabel.Size = new Size(0, 32);
            goalNameLabel.TabIndex = 3;
            // 
            // GoalDescriptionRichText
            // 
            GoalDescriptionRichText.BackColor = Color.FromArgb(49, 50, 72);
            GoalDescriptionRichText.BorderStyle = BorderStyle.None;
            GoalDescriptionRichText.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold);
            GoalDescriptionRichText.ForeColor = Color.White;
            GoalDescriptionRichText.Location = new Point(18, 69);
            GoalDescriptionRichText.Margin = new Padding(3, 4, 3, 4);
            GoalDescriptionRichText.Name = "GoalDescriptionRichText";
            GoalDescriptionRichText.ReadOnly = true;
            GoalDescriptionRichText.Size = new Size(760, 627);
            GoalDescriptionRichText.TabIndex = 0;
            GoalDescriptionRichText.Text = "";
            // 
            // GoalSettingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 35, 50);
            ClientSize = new Size(1117, 948);
            Controls.Add(panel2);
            Controls.Add(closeButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "GoalSettingForm";
            Text = "Goal Setting";
            Activated += GoalSettingForm_Activated;
            Deactivate += GoalSettingForm_Deactivate;
            Load += GoalSettingForm_Load;
            Shown += GoalSettingForm_Shown;
            MouseDown += GoalSettingForm_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button closeButton;
        private ListBox GoalListBox;
        private Panel panel2;
        private Button RemoveGoalButton;
        private Button AddGoalButton;
        private Label goalNameLabel;
        private RichTextBox GoalDescriptionRichText;
        private Label DueDateLabel;
        private Label label1;
        private Button EditGoalButton;
    }
}
