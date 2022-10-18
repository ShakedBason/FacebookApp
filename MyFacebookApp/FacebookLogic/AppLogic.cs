using FacebookWrapper;
using Facebook;

namespace FacebookLogic
{
    sealed public class AppLogic
    {
        private static AppLogic s_Instance;
        private static readonly object sr_LockGetContext = new object();

        private const int k_AppCollectionLimit = 100;
        private const string k_AppId = "427050739382146";

        private AppUserCachingProxy m_LoggedInUser;
        private LoginResult m_LoginResult;

        private AppLogic()
        {
            FacebookService.s_UseForamttedToStrings = true;
            FacebookWrapper.FacebookService.s_CollectionLimit = k_AppCollectionLimit;
        }

        public static AppLogic Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockGetContext)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new AppLogic();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public AppSettings Settings { get; } = AppSettings.Instance;

        public AppUserCachingProxy LoggedInUser { get { return m_LoggedInUser; } }

        public bool LoggedIn
        {
            get
            {
                return m_LoggedInUser != null;
            }
        }

        public void Login()
        {
            if (Settings.RememberUser && !string.IsNullOrEmpty(Settings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(Settings.LastAccessToken);
            }
            else
            {
                m_LoginResult = FacebookService.Login(k_AppId,
                        "email",
                        "public_profile",
                        "user_birthday",
                        "user_events",
                        "user_friends",
                        "user_photos",
                        "user_posts",
                        "user_likes"
                        );
            }

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = new AppUserCachingProxy(m_LoginResult.LoggedInUser);
                Settings.LastAccessToken = m_LoginResult.AccessToken;
            }
        }

        public void Logout()
        {
            FacebookService.LogoutWithUI();
            m_LoginResult = null;
            m_LoggedInUser = null;
            Settings.RememberUser = false;
        }
    }
}
