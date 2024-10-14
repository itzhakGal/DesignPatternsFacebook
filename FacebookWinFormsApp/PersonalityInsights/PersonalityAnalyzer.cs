using BasicFacebookFeatures.PersonalInsights;
using BasicFacebookFeatures.PersonalInsl;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class PersonalityAnalyzer
    {
        private readonly User r_LoggedInUser;
        private readonly List<IAnalysisStrategy> r_AnalysisStrategies;

        public PersonalityAnalyzer(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            r_AnalysisStrategies = new List<IAnalysisStrategy>
            {
                new TopicAnalysisStrategy(),
                new SentimentAnalysisStrategy(),
                new InterestAnalysisStrategy(),
                new ActivityPatternAnalysisStrategy(),
                new PhotoPreferencesAnalysisStrategy()
            };
        }

        public PersonalityProfile AnalyzePersonality()
        {
            PersonalityProfile profile = new PersonalityProfile();
            foreach (IAnalysisStrategy strategy in r_AnalysisStrategies)
            {
                strategy.Analyze(profile, r_LoggedInUser);
            }

            return profile;
        }
    }

    public class PersonalityProfile
    {
        public List<string> TopTopics { get; set; }
        public double SentimentScore { get; set; }
        public List<string> MainInterests { get; set; }
        public ActivityPattern ActivityPattern { get; set; }
        public PhotoPreferences PhotoPreferences { get; set; }
    }

    public class ActivityPattern
    {
        public int MostActiveHour { get; set; }
        public double PostFrequency { get; set; }
    }

    public class PhotoPreferences
    {
        public int TotalPhotos { get; set; }
        public double PhotosPerMonth { get; set; }
        public string MostCommonPhotoType { get; set; }
    }
}
