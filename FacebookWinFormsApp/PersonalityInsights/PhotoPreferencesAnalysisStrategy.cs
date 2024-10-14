using FacebookWrapper.ObjectModel;
using System;
using System.Linq;

namespace BasicFacebookFeatures.PersonalInsl
{
    public class PhotoPreferencesAnalysisStrategy : IAnalysisStrategy
    {
        public void Analyze(PersonalityProfile i_Profile, User i_User)
        {
            PhotoPreferences preferences = new PhotoPreferences
            {
                TotalPhotos = i_User.Albums.Sum(album => album.Photos != null ? album.Photos.Count : 0)
            };

            int photosLastYear = i_User.Albums
                .SelectMany(album => album.Photos)
                .Where(photo => photo.CreatedTime.HasValue && photo.CreatedTime.Value > DateTime.Now.AddYears(-1))
                .Count();

            preferences.PhotosPerMonth = photosLastYear / 12.0;

            preferences.MostCommonPhotoType = i_User.Albums
                .GroupBy(album => album.Type.ToString())
                .OrderByDescending(group => group.Count())
                .Select(group => group.Key)
                .FirstOrDefault() ?? "Unknown";

            i_Profile.PhotoPreferences = preferences;
        }
    }
}
