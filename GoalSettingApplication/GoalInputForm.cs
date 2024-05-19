using GoalSettingLibrary;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoalSettingApplication
{

    public partial class GoalInputForm : Form
    {

        public GoalInputForm()
        {
            InitializeComponent();
        }

        private void InputFormCloseButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbGoalName.Text) || string.IsNullOrEmpty(tbDescription.Text))
            {
                Close();
            }

            string goalName = tbGoalName.Text;

            string goalDescription = tbDescription.Text;

            DateOnly goalDueDate = DateOnly.FromDateTime(dtpDueDate.Value.Date);

            Goal goal = new(goalName, goalDueDate, goalDescription);


            if (Data.goalAction == GoalAction.Add)
            { 
            
                Data.GoalManager.Goals.Add(goal);
                Data.GoalManager.AddGoalToDatabase(goal);
            }
            else if (Data.goalAction == GoalAction.Edit)
            {
                goal.Id = Data.GoalToEdit.Id;
                Data.GoalManager.Goals.Remove(Data.GoalToEdit as Goal);
                Data.GoalManager.Goals.Add(goal);
                Data.GoalManager.UpdateGoalInDatabase(goal);
            }
            Data.GoalManager.GoalChangeHandler.Invoke();
            Close();
        }

        private void GoalInputForm_Load(object sender, EventArgs e)
        {
            if (Data.GoalToEdit != null) 
            {
                tbGoalName.Text = Data.GoalToEdit.GoalName;
                tbDescription.Text = Data.GoalToEdit.Description;
                dtpDueDate.Value = DateTime.Parse(Data.GoalToEdit.DueDate);
            }
        }
    }
}
