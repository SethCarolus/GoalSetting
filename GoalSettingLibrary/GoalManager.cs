using Dapper;
using System;
using System.Configuration;
using System.Data.SQLite;
using System.Net;

namespace GoalSettingLibrary
{

    public class GoalManager
    {

        public List<Goal> Goals;


        public Action GoalChangeHandler;

        public GoalManager() 
        {
            Goals = GetGoalsFromDatabase();
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


        public void AddGoalToDatabase(IGoal goal)
        {
            ArgumentNullException.ThrowIfNull(goal);

            var sql =
                $"""
                    INSERT 
                    INTO Goals (GoalName, DueDate, Description)
                    VALUES (@GoalName, @DueDate, @Description);

                """;

            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                if (connection == null)
                {
                    throw new NullReferenceException(nameof(connection));
                }

                connection.Open();

                connection.Execute(sql,goal);
            }

        }

        public void RemoveGoalFromDatabase(IGoal goal)
        {
            ArgumentNullException.ThrowIfNull(goal);

            var sql =
                $"""
                    DELETE
                    FROM Goals
                    WHERE Id = {goal.Id};

                """;
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                if (connection == null)
                {
                    throw new NullReferenceException(nameof(connection));
                }

                connection.Open();

                connection.Execute(sql, goal);
            }
        }

        public void UpdateGoalInDatabase(IGoal goal) 
        {
            ArgumentNullException.ThrowIfNull(goal);

            var sql =
                $"""
                    UPDATE Goals
                    SET GoalName = @GoalName, DueDate = @DueDate, Description = @Description
                    WHERE Id = {goal.Id};
                """;

            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                if (connection == null)
                {
                    throw new NullReferenceException(nameof(connection));
                }

                connection.Open();

                connection.Execute(sql, goal);
            }
        }

        private List<Goal> GetGoalsFromDatabase()
        {
            IEnumerable<Goal> goals;

            var sql = """
                    SELECT *
                    FROM Goals;
                """;

            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();
                goals = connection.Query<Goal>(sql);
                return (List<Goal>)goals;
            }
        }

    }
}
