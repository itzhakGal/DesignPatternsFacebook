using FacebookWrapper.ObjectModel;
using System;

namespace BasicFacebookFeatures
{
    public interface IFacebookObserver
    {
        void UpdateLoginStatus(bool i_IsLoggedIn);
        void UpdateUserData(User i_User);
    }
}
