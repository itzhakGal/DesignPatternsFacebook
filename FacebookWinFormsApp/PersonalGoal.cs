using System;

namespace BasicFacebookFeatures
{
    public class PersonalGoal
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime TargetDate { get; set; }
        public int Progress { get; set; }

        public PersonalGoal() { }

        public PersonalGoal(string i_Name, string i_Category, DateTime i_TargetDate)
        {
            Name = i_Name;
            Category = i_Category;
            TargetDate = i_TargetDate;
            Progress = 0;
        }

        public void UpdateProgress(int i_Progress)
        {
            Progress = Math.Min(100, Progress + i_Progress);
        }

        public override string ToString()
        {
            return $"{Name} - {Category} - {Progress}%";
        }
    }
}
