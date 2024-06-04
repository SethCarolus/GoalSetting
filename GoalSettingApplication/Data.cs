using GoalSettingLibrary;

namespace GoalSettingApplication
{
    public static class Data
    {
        public static readonly  GoalManager GoalManager = new();

        public static IGoal? GoalToEdit;

        public static GoalAction GoalAction;
    }

    public enum GoalAction 
    {
        Add, Remove, Edit
    }
}
