


namespace GoalSettingLibrary
{
    public static class Factory
    {
        public static IGoal CreateGoal(string name, DateOnly dueDate, string description)
        {
            return new Goal(name, dueDate, description);
        }
    }
}