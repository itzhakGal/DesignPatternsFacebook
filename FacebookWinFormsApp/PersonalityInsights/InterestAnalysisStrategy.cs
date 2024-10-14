using FacebookWrapper.ObjectModel;
using System.Linq;

namespace BasicFacebookFeatures.PersonalInsl
{
    public class InterestAnalysisStrategy : IAnalysisStrategy
    {
        public void Analyze(PersonalityProfile i_Profile, User i_User)
        {
            i_Profile.MainInterests = i_User.LikedPages
                .Where(page => !string.IsNullOrEmpty(page.Category))
                .GroupBy(page => page.Category)
                .OrderByDescending(group => group.Count())
                .Take(5)
                .Select(group => group.Key)
                .ToList();
        }
    }
}
