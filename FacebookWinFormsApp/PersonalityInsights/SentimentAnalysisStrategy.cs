using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures.PersonalInsl
{
    public class SentimentAnalysisStrategy : IAnalysisStrategy
    {
        public void Analyze(PersonalityProfile i_Profile, User i_User)
        {
            List<string> positiveWords = new List<string>
            {
                "happy", "great", "awesome", "love", "excited", "wonderful", "fantastic", "amazing"
            };

            List<string> negativeWords = new List<string>
            {
                "sad", "angry", "hate", "disappointed", "frustrated", "terrible", "awful", "horrible"
            };

            int positiveCount = 0;
            int negativeCount = 0;

            foreach (Post post in i_User.Posts)
            {
                if (post.Message != null)
                {
                    string lowerMessage = post.Message.ToLower();
                    positiveCount += positiveWords.Count(word => lowerMessage.Contains(word));
                    negativeCount += negativeWords.Count(word => lowerMessage.Contains(word));
                }
            }

            int totalCount = positiveCount + negativeCount;
            i_Profile.SentimentScore = totalCount > 0 ? (double)positiveCount / totalCount : 0.5;
        }
    }
}
