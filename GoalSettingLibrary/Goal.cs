using System;


namespace GoalSettingLibrary
{
    /// <summary>
    ///  Represents a goal that someone sets
    /// </summary>
    public class Goal : IGoal
    {

        /// <summary>
        /// Represents the Id of the goal
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the name of the goal
        /// </summary>
        public string GoalName { get; set; }

        /// <summary>
        /// Represents the due date of the goal
        /// </summary>
        public string DueDate { get; set; }

        /// <summary>
        /// Represents the description of the goal
        /// </summary>
        public string Description { get; set; }
        


        public Goal(int id, string name, DateOnly dueDate, string description)
        {
            Id = id;
            GoalName = name;
            DueDate = dueDate.ToString();
            Description = description;
        }

        public Goal(string name, DateOnly dueDate, string description)
        {
            GoalName = name;
            DueDate = dueDate.ToString();
            Description = description;
        }
    }
}
