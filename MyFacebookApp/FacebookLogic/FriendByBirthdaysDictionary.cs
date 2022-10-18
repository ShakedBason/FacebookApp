using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class FriendByBirthdaysDictionary
    {
        private readonly Dictionary<int, Dictionary<int, FacebookObjectCollection<User>>> r_FriendsByBirthdays = new Dictionary<int, Dictionary<int, FacebookObjectCollection<User>>>();

        public void Clear()
        {
            r_FriendsByBirthdays.Clear();
        }

        public void Add(User i_Friend)
        {
            DateTime o_FriendBirthDay;
            
            if(DateTime.TryParse(i_Friend.Birthday, out o_FriendBirthDay))
            {
                if (!r_FriendsByBirthdays.ContainsKey(o_FriendBirthDay.Month))
                {
                    r_FriendsByBirthdays.Add(o_FriendBirthDay.Month, new Dictionary<int, FacebookObjectCollection<User>>());
                }

                if (!r_FriendsByBirthdays[o_FriendBirthDay.Month].ContainsKey(o_FriendBirthDay.Day))
                {
                    r_FriendsByBirthdays[o_FriendBirthDay.Month].Add(o_FriendBirthDay.Day, new FacebookObjectCollection<User>());
                }

                if (!r_FriendsByBirthdays[o_FriendBirthDay.Month][o_FriendBirthDay.Day].Contains(i_Friend))
                {
                    r_FriendsByBirthdays[o_FriendBirthDay.Month][o_FriendBirthDay.Day].Add(i_Friend);
                }
            }
        }

        public FacebookObjectCollection<User> GetFriendsByBirthDate(int i_Month, int i_Day)
        {
            FacebookObjectCollection<User> friendsByBirthDate;

            if(r_FriendsByBirthdays.ContainsKey(i_Month) && r_FriendsByBirthdays[i_Month].ContainsKey(i_Day))
            {
                friendsByBirthDate = r_FriendsByBirthdays[i_Month][i_Day];
            }
            else
            {
                friendsByBirthDate = new FacebookObjectCollection<User>();
            }

            return friendsByBirthDate;
        }

        public FacebookObjectCollection<User> GetFriendsByBirthDate(DateTime i_Date)
        {
            return GetFriendsByBirthDate(i_Date.Month, i_Date.Day);
        }
    }
}
