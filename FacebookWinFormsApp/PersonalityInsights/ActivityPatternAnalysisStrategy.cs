using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures.PersonalInsights
{
    public class ActivityPatternAnalysisStrategy : IAnalysisStrategy
    {
        public void Analyze(PersonalityProfile i_Profile, User i_User)
        {
            ActivityPattern activityPattern = new ActivityPattern();

            if (i_User.Posts.Any())
            {
                List<TimeSpan> postTimes = i_User.Posts
                    .Where(i_Post => i_Post.CreatedTime.HasValue)
                    .Select(i_Post => i_Post.CreatedTime.Value.TimeOfDay)
                    .ToList();

                if (postTimes.Any())
                {
                    activityPattern.MostActiveHour = postTimes
                        .GroupBy(i_Time => i_Time.Hours)
                        .OrderByDescending(i_Group => i_Group.Count())
                        .First().Key;

                    DateTime? oldestPost = i_User.Posts.Min(i_Post => i_Post.CreatedTime);
                    DateTime? newestPost = i_User.Posts.Max(i_Post => i_Post.CreatedTime);
                    if (oldestPost.HasValue && newestPost.HasValue)
                    {
                        double totalDays = (newestPost.Value - oldestPost.Value).TotalDays;
                        activityPattern.PostFrequency = totalDays > 0 ? i_User.Posts.Count / totalDays : 0;
                    }
                }
            }

            i_Profile.ActivityPattern = activityPattern;
        }
    }
}
