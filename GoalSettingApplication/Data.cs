using GoalSettingLibrary;

namespace GoalSettingApplication
{
    public static class Data
    {
        public readonly static GoalManager GoalManager = new();

        public static IGoal? GoalToEdit;

        public static GoalAction goalAction;
    }

    public enum GoalAction 
    {
        Add, Remove, Edit
    }
}
