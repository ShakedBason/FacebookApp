using FacebookWrapper.ObjectModel;
using System;

namespace FacebookLogic
{
    public class AppUserCachingProxy
    {
        private readonly User r_LoggedInUser;
        private string m_FullName;
        private string m_Email;
        private string m_Birthday;
        private User.eGender? m_Gender;
        private User.eRelationshipStatus? m_RelationshipStatus;
        private string m_ProfilePictureURL;
        private FacebookObjectCollection<Page> m_LikedPages;
        private FacebookObjectCollection<User> m_Friends;
        private FacebookObjectCollection<Post> m_Posts;
        private FacebookObjectCollection<Event> m_Events;
        private FacebookObjectCollection<Album> m_LoggedInUserAlbums;
        private FriendByBirthdaysDictionary m_FriendByBirthdaysDictionary;

        public AppUserCachingProxy(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
        }

        public string FullName
        {
            get
            {
                if (m_FullName == null)
                {
                    m_FullName = r_LoggedInUser.Name;
                }

                return m_FullName;
            }
        }

        public string Email
        {
            get
            {
                if (m_Email == null)
                {
                    m_Email = r_LoggedInUser.Email;
                }

                return m_Email;
            }
        }

        public string Birthday
        {
            get
            {
                if (m_Birthday == null)
                {
                    m_Birthday = r_LoggedInUser.Birthday;
                }

                return m_Birthday;
            }
        }

        public User.eGender? Gender
        {
            get
            {
                if (m_Gender == null)
                {
                    m_Gender = r_LoggedInUser.Gender;
                }

                return m_Gender;
            }
        }

        public User.eRelationshipStatus? RelationshipStatus
        {
            get
            {
                if (m_RelationshipStatus == null)
                {
                    m_RelationshipStatus = r_LoggedInUser.RelationshipStatus;
                }

                return m_RelationshipStatus;
            }
        }

        public string ProfilePictureURL
        {
            get
            {
                if (m_ProfilePictureURL == null)
                {
                    m_ProfilePictureURL = r_LoggedInUser.PictureNormalURL;
                }

                return m_ProfilePictureURL;
            }
        }

        public FacebookObjectCollection<Page> LikedPages
        {
            get
            {
                if (m_LikedPages == null)
                {
                    m_LikedPages = r_LoggedInUser.LikedPages;
                }

                return m_LikedPages;
            }
        }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                if (m_LoggedInUserAlbums == null)
                {
                    m_LoggedInUserAlbums = r_LoggedInUser.Albums;
                }

                return m_LoggedInUserAlbums;
            }
        }

        public FacebookObjectCollection<User> Friends
        {
            get
            {
                if (m_Friends == null)
                {
                    try
                    {
                        m_Friends = r_LoggedInUser.Friends;
                    }
                    catch (Exception)
                    {
                    }
                }

                return m_Friends;
            }
        }

        public FacebookObjectCollection<Post> Posts
        {
            get
            {
                if (m_Posts == null)
                {
                    try
                    {
                        m_Posts = r_LoggedInUser.Posts;
                    }
                    catch (Exception)
                    {
                    }
                }

                return m_Posts;
            }
        }

        public FacebookObjectCollection<Event> Events
        {
            get
            {
                if (m_Events == null)
                {
                    m_Events = r_LoggedInUser.Events;
                }

                return m_Events;
            }
        }

        internal FriendByBirthdaysDictionary FriendByBirthdays
        {
            get
            {
                if (m_FriendByBirthdaysDictionary == null)
                {
                    initFriendsByBirthdayDictionary();
                }

                return m_FriendByBirthdaysDictionary;
            }
        }

        public void initFriendsByBirthdayDictionary()
        {
            m_FriendByBirthdaysDictionary = new FriendByBirthdaysDictionary();

            foreach (User friend in Friends)
            {
                m_FriendByBirthdaysDictionary.Add(friend);
            }
        }

        public Status PostStatus(string i_Message, string i_TaggedInFriendId = null)
        {
            return r_LoggedInUser.PostStatus(i_Message, null, null, i_TaggedInFriendId);
        }
    }
}