
using Microsoft.VisualBasic;

namespace GoalSettingLibrary
{
    public interface IGoal
    {
        string Description { get; set; }
        string DueDate { get; set; }
        int Id { get; set; }
        string GoalName { get; set; }
    }
}