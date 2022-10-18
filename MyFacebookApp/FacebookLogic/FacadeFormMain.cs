using FacebookLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace FacebookUI
{
    public class FacadeFormMain
    {
        private readonly AppLogic r_AppLogic = AppLogic.Instance;
        private IAlbumsSortStrategy m_AlbumsSortStrategy = new CreatedTimeSortAlbumsStrategy();
        public event EventHandler AlbumsSortStrategyChanged;
        
        public string UserFullName
        {
            get
            {
                return r_AppLogic.LoggedInUser.FullName;
            }
        }

        public string UserEmail
        {
            get
            {
                return r_AppLogic.LoggedInUser.Email;
            }
        }

        public string UserBirthday
        {
            get
            {
                return r_AppLogic.LoggedInUser.Birthday;
            }
        }

        public User.eGender? UserGender
        {
            get
            {
                return r_AppLogic.LoggedInUser.Gender;
            }
        }

        public User.eRelationshipStatus? UserRelationshipStatus
        {
            get
            {
                return r_AppLogic.LoggedInUser.RelationshipStatus;
            }
        }

        public string UserProfilePictureURL
        {
            get
            {
                return r_AppLogic.LoggedInUser.ProfilePictureURL;
            }
        }

        public FacebookObjectCollection<Page> UserLikedPages
        {
            get
            {
                return r_AppLogic.LoggedInUser.LikedPages;
            }
        }

        public FacebookObjectCollection<User> UserFriends
        {
            get
            {
                return r_AppLogic.LoggedInUser.Friends;
            }
        }

        public FacebookObjectCollection<Post> UserPosts
        {
            get
            {
                return r_AppLogic.LoggedInUser.Posts;
            }
        }

        public FacebookObjectCollection<Event> UserEvents
        {
            get
            {
                return r_AppLogic.LoggedInUser.Events;
            }
        }

        public List<Album> GetUserSortedAlbums()
        {
            List<Album> userAlbums = r_AppLogic.LoggedInUser.Albums.ToList();

            return m_AlbumsSortStrategy.Sort(userAlbums);
        }

        public void SetAlbumsSortStrategy(eSortValues i_AlbumSortValue)
        {
            if (i_AlbumSortValue == eSortValues.LikesAmount)
            {
                m_AlbumsSortStrategy = new LikesAmountSortAlbumsStrategy();
            }
            else if (i_AlbumSortValue == eSortValues.CreatedTime)
            {
                m_AlbumsSortStrategy = new CreatedTimeSortAlbumsStrategy();
            }
            else
            {
                m_AlbumsSortStrategy = new UpdateTimeSortAlbumsStrategy();
            }

            OnAlbumsSortStrategyChanged();
        }

        private void OnAlbumsSortStrategyChanged()
        {
            EventArgs e = new EventArgs();

            if (AlbumsSortStrategyChanged != null)
            {
                AlbumsSortStrategyChanged.Invoke(this, e);
            }
        }

        public FacebookObjectCollection<User> GetCelebratorsByDate(DateTime i_BirthdayDate)
        {
            return r_AppLogic.LoggedInUser.FriendByBirthdays.GetFriendsByBirthDate(i_BirthdayDate);
        }

        public FacebookObjectCollection<Event> GetUserThisWeekEvents()
        {
            FacebookObjectCollection<Event> thisWeekEventsList = new FacebookObjectCollection<Event>();
            ThisWeekEvents thisWeekEvents = new ThisWeekEvents(r_AppLogic.LoggedInUser.Events);

            foreach (Event currentEvent in thisWeekEvents)
            {
                thisWeekEventsList.Add(currentEvent);
            }

            return thisWeekEventsList;
        }

        public Status PostStatus(string i_Message, string i_TaggedInFriendId = null)
        {
            return r_AppLogic.LoggedInUser.PostStatus(i_Message, i_TaggedInFriendId);
        }

        public void Logout()
        {
            r_AppLogic.Logout();
        }

        public Point? LastWindowsLocation { get { return r_AppLogic.Settings.LastWindowsLocation; } }

        public void UpdateAndSaveAppSettings(Point i_WindowLocation)
        {
            r_AppLogic.Settings.LastWindowsLocation = i_WindowLocation;
            r_AppLogic.Settings.SaveSettingsToFile();
        }
    }
}
