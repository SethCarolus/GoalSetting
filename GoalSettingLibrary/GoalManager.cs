using Dapper;
using System;
using System.Configuration;
using System.Data.SQLite;
using System.Net;

namespace GoalSettingLibrary
{

    public static class GoalManager
    {

        public static List<Goal> Goals = GetGoalsFromDatabaseAsync().Result;


        public static Action GoalChangeHandler;


        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


        public static async Task AddGoalToDatabaseAsync(IGoal goal)
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

                await connection.ExecuteAsync(sql,goal);
            }

        }

        public static async Task RemoveGoalFromDatabaseAsync(IGoal goal)
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

                await connection.ExecuteAsync(sql, goal);
            }
        }

        public static async Task UpdateGoalInDatabaseAsync(IGoal goal) 
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

                await connection.ExecuteAsync(sql, goal);
            }
        }

        private static async Task<List<Goal>> GetGoalsFromDatabaseAsync()
        {
            IEnumerable<Goal> goals;

            var sql = """
                    SELECT *
                    FROM Goals;
                """;

            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();
                goals = await connection.QueryAsync<Goal>(sql);
                return (List<Goal>)goals;
            }
        }

    }
}
