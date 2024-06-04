using Dapper;
using GoalSettingLibrary;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Windows.Input;
using Microsoft.VisualBasic;

namespace GoalSettingApplication
{
    public partial class GoalSettingForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public GoalSettingForm()
        {
            InitializeComponent();
        }

        private void GoalSettingForm_Load(object sender, EventArgs e)
        {
        }

        private void GoalSettingForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GoalSettingForm_Activated(object sender, EventArgs e)
        {
            DisplayGoals();
            Data.GoalManager.GoalChangeHandler += DisplayGoals;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IGoal selectedGoal;
            if (GoalListBox.SelectedIndex != -1)
            {
                selectedGoal = Data.GoalManager.Goals[GoalListBox.SelectedIndex];

                goalNameLabel.Text = selectedGoal.GoalName;

                if (DateOnly.Parse(selectedGoal.DueDate) < DateOnly.FromDateTime(DateTime.Today)) 
                {
                    DueDateLabel.ForeColor = Color.Red;
                } 
                else 
                { 
                    DueDateLabel.ForeColor = Color.White; 
                }
                DueDateLabel.Text = selectedGoal.DueDate;
                GoalDescriptionRichText.Text = selectedGoal.Description;

            }
        }

        private void AddGoalButton_Click(object sender, EventArgs e)
        {
            Data.GoalToEdit = null;

            Data.GoalAction = GoalAction.Add;

            var goalInputForm = new GoalInputForm();
            goalInputForm.Location = Location;
            goalInputForm.Show();


        }

        private void RemoveGoalButton_Click(object sender, EventArgs e)
        {
            Data.GoalToEdit = null;

            Data.GoalAction = GoalAction.Remove;

            if (GoalListBox.SelectedIndex == -1) 
            {
                return;
            }

            Data.GoalManager.RemoveGoalFromDatabase(Data.GoalManager.Goals[GoalListBox.SelectedIndex]);
            Data.GoalManager.Goals.RemoveAt(GoalListBox.SelectedIndex);
            GoalListBox.Items.Clear();

            foreach (var g in Data.GoalManager.Goals)
            {
                GoalListBox.Items.Add(g.GoalName);
            }

            GoalListBox.SelectedIndex = GoalListBox.Items.Count - 1;
        }

        private void DisplayGoals()
        {
            GoalListBox.Items.Clear();
            for (int i = 0; i < Data.GoalManager.Goals.Count; i++)
            {
                GoalListBox.Items.Add(Data.GoalManager.Goals[i].GoalName);
            }

            GoalListBox.SelectedIndex = GoalListBox.Items.Count - 1;
        }

        private void GoalSettingForm_Deactivate(object sender, EventArgs e)
        {

        }

        private void GoalSettingForm_Shown(object sender, EventArgs e)
        {
            if (!(GoalListBox.Items.Count > 0)) 
            {
                return;
            }

            GoalListBox.SelectedIndex = 0;
            AddGoalButton.Focus();
        }

        private void EditGoalButton_Click(object sender, EventArgs e)
        {
            Data.GoalAction = GoalAction.Edit;

            if (GoalListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select a goal!");
                return;
            }
            int selectedGoalIndex = GoalListBox.SelectedIndex;

            Data.GoalToEdit = Data.GoalManager.Goals[selectedGoalIndex];


            var goalInputForm = new GoalInputForm();
            goalInputForm.Location = Location;
            goalInputForm.Show();

        }
    }
}
