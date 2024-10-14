using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace BasicFacebookFeatures
{
    public class PersonalGoalManager
    {
        private static PersonalGoalManager s_Instance = null;
        private readonly List<PersonalGoal> r_GoalsList = new List<PersonalGoal>();

        private PersonalGoalManager() { }

        public static PersonalGoalManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = new PersonalGoalManager();
                }
                return s_Instance;
            }
        }

        public IReadOnlyList<PersonalGoal> Goals => r_GoalsList.AsReadOnly();

        public void AddGoal(PersonalGoal i_NewGoal, int i_InitialProgress = 0)
        {
            if (r_GoalsList.Any(goal => goal.Name.Equals(i_NewGoal.Name, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("A goal with this name already exists.");
            }
            i_NewGoal.UpdateProgress(i_InitialProgress);
            r_GoalsList.Add(i_NewGoal);
        }

        public void UpdateGoalProgress(PersonalGoal i_GoalToUpdate, int i_Progress)
        {
            PersonalGoal existingGoal = r_GoalsList.FirstOrDefault(goal => goal.Name == i_GoalToUpdate.Name);
            if (existingGoal != null)
            {
                existingGoal.UpdateProgress(i_Progress);
            }
            else
            {
                throw new KeyNotFoundException("Goal not found.");
            }
        }

        public void RemoveGoal(PersonalGoal i_GoalToRemove)
        {
            r_GoalsList.Remove(i_GoalToRemove);
        }

        public void SaveGoalsToFile(string i_UserId)
        {
            Dictionary<string, List<PersonalGoal>> allUsersGoals;
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                IncludeFields = true,
                WriteIndented = true
            };

            if (File.Exists("goals.json"))
            {
                string json = File.ReadAllText("goals.json");
                allUsersGoals = JsonSerializer.Deserialize<Dictionary<string, List<PersonalGoal>>>(json, options);
            }
            else
            {
                allUsersGoals = new Dictionary<string, List<PersonalGoal>>();
            }
            allUsersGoals[i_UserId] = r_GoalsList;
            string updatedJson = JsonSerializer.Serialize(allUsersGoals, options);
            File.WriteAllText("goals.json", updatedJson);
        }

        public void LoadGoalsFromFile(string i_UserId)
        {
            if (File.Exists("goals.json"))
            {
                string json = File.ReadAllText("goals.json");
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    IncludeFields = true
                };
                var allUsersGoals = JsonSerializer.Deserialize<Dictionary<string, List<PersonalGoal>>>(json, options);
                if (allUsersGoals.ContainsKey(i_UserId))
                {
                    r_GoalsList.Clear();
                    r_GoalsList.AddRange(allUsersGoals[i_UserId]);
                }
                else
                {
                    r_GoalsList.Clear();
                }
            }
            else
            {
                r_GoalsList.Clear();
            }
        }

        public void CleanGoalsFile(string i_UserId)
        {
            Dictionary<string, List<PersonalGoal>> emptyGoalsData = new Dictionary<string, List<PersonalGoal>>();
            string updatedJson = JsonSerializer.Serialize(emptyGoalsData, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("goals.json", updatedJson);
        }
    }
}
