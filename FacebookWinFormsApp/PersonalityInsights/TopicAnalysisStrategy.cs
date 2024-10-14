using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures.PersonalInsl
{
    public class TopicAnalysisStrategy : IAnalysisStrategy
    {
        public void Analyze(PersonalityProfile i_Profile, User i_User)
        {
            Dictionary<string, int> wordsFrequency = new Dictionary<string, int>();

            foreach (Post post in i_User.Posts)
            {
                if (!string.IsNullOrEmpty(post.Message))
                {
                    string[] postWords = post.Message
                        .ToLower()
                        .Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in postWords)
                    {
                        if (word.Length > 3)
                        {
                            if (!wordsFrequency.ContainsKey(word))
                            {
                                wordsFrequency[word] = 0;
                            }

                            wordsFrequency[word]++;
                        }
                    }
                }
            }

            i_Profile.TopTopics = wordsFrequency
                .OrderByDescending(word => word.Value)
                .Take(5)
                .Select(word => word.Key)
                .ToList();
        }
    }
}
