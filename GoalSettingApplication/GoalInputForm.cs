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

        private async void InputFormCloseButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbGoalName.Text) || string.IsNullOrEmpty(tbDescription.Text))
            {
                Close();
            }

            string goalName = tbGoalName.Text;

            string goalDescription = tbDescription.Text;

            DateOnly goalDueDate = DateOnly.FromDateTime(dtpDueDate.Value.Date);

            Goal goal = new(goalName, goalDueDate, goalDescription);


            if (Data.GoalAction == GoalAction.Add)
            { 
            
                GoalManager.Goals.Add(goal);
                await GoalManager.AddGoalToDatabaseAsync(goal);
            }
            else if (Data.GoalAction == GoalAction.Edit)
            {

                if (Data.GoalToEdit == null) throw new Exception("GoalToEdit should not be nulll");

                goal.Id = Data.GoalToEdit.Id;
                GoalManager.Goals.Remove(Data.GoalToEdit as Goal);
                GoalManager.Goals.Add(goal);
                await GoalManager.UpdateGoalInDatabaseAsync(goal);
            }
            GoalManager.GoalChangeHandler.Invoke();
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
