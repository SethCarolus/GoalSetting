using GoalSettingLibrary;

namespace GoalSettingApplication
{
    public static class Data
    {
        public static IGoal? GoalToEdit;

        public static GoalAction GoalAction;
    }

    public enum GoalAction 
    {
        Add, Remove, Edit
    }
}
