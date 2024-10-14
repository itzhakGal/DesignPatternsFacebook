using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FacebookManager
    {
        private readonly string r_AppId;
        public LoginResult LoginResult { get; set; }

        private User m_LoggedInUser;

        private readonly List<IFacebookObserver> r_Observers = new List<IFacebookObserver>();

        public FacebookManager(string i_AppId)
        {
            r_AppId = i_AppId;
        }

        public bool Initialize()
        {
            try
            {
                Login();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void RegisterObserver(IFacebookObserver observer)
        {
            r_Observers.Add(observer);
        }

        public void UnregisterObserver(IFacebookObserver observer)
        {
            r_Observers.Remove(observer);
        }

        private void NotifyObservers(bool isLoggedIn)
        {
            foreach (var observer in r_Observers)
            {
                observer.UpdateLoginStatus(isLoggedIn);
                if (isLoggedIn)
                {
                    observer.UpdateUserData(m_LoggedInUser);
                }
            }
        }

        private void Login()
        {
            LoginResult = FacebookService.Login(
                r_AppId,
                "email",
                "public_profile",
                "user_photos",
                "user_likes",
                "user_gender",
                "user_posts",
                "user_friends",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_hometown",
                "user_link",
                "user_location",
                "user_videos"
            );

            if (string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoginResult = null;
                throw new Exception("Failed to login");
            }

            if (string.IsNullOrEmpty(LoginResult.ErrorMessage))
            {
                m_LoggedInUser = LoginResult.LoggedInUser;
                NotifyObservers(true);
            }
            else
            {
                NotifyObservers(false);
            }
        }

        public void Logout()
        {
            FacebookService.Logout();
            m_LoggedInUser = null;
            LoginResult = null;
            NotifyObservers(false);
        }

        public string PostStatus(string i_StatusText)
        {
            if (LoginResult != null && m_LoggedInUser != null)
            {
                Status postedStatus = m_LoggedInUser.PostStatus(i_StatusText);
                return postedStatus.Id;
            }

            throw new InvalidOperationException("User is not logged in.");
        }

        public FacebookObjectCollection<Album> GetAlbums()
        {
            return m_LoggedInUser.Albums;
        }

        public FacebookObjectCollection<Page> GetLikedPages()
        {
            return m_LoggedInUser.LikedPages;
        }

        public FacebookObjectCollection<Group> GetGroups()
        {
            return m_LoggedInUser.Groups;
        }

        public FacebookObjectCollection<Post> GetPosts()
        {
            return m_LoggedInUser.Posts;
        }

        public FacebookObjectCollection<Post> GetLikedPosts()
        {
            return m_LoggedInUser.Posts;
        }

        public FacebookObjectCollection<Photo> GetLikedPhotos()
        {
            return m_LoggedInUser.PhotosTaggedIn;
        }

        public string GetCurrentUserId()
        {
            return m_LoggedInUser?.Id;
        }

        public List<Page> SearchPages(string i_Category)
        {
            var matchingPages = new List<Page>();

            foreach (var page in m_LoggedInUser.LikedPages)
            {
                bool isNameMatch = page.Name != null && page.Name.IndexOf(i_Category, StringComparison.OrdinalIgnoreCase) >= 0;
                bool isCategoryMatch = string.IsNullOrEmpty(i_Category) || (page.Category != null && page.Category.Equals(i_Category, StringComparison.OrdinalIgnoreCase));
                bool isDescriptionMatch = page.Description != null && page.Description.IndexOf(i_Category, StringComparison.OrdinalIgnoreCase) >= 0;

                if (isNameMatch || isDescriptionMatch || isCategoryMatch)
                {
                    matchingPages.Add(page);
                }
            }

            return matchingPages;
        }

        public List<string> GetUserInfo()
        {
            List<string> userInfo = new List<string>
            {
                $"Name: {m_LoggedInUser.Name}",
                $"Email: {m_LoggedInUser.Email}",
                $"Birthday: {m_LoggedInUser.Birthday}"
            };

            return userInfo;
        }
    }
}
