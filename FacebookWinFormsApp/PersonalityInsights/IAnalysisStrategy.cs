using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public interface IAnalysisStrategy
    {
        void Analyze(PersonalityProfile i_Profile, User i_User);
    }
}
