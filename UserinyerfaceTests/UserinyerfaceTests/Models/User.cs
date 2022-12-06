using System;
using System.Collections.Generic;
using System.Linq;

namespace UserinyerfaceTests.BusinessObjects
{
    public class User
    {
        public string EmailUserName { get; set; }

        public string EmailDomain { get; set; }

        public string EmailTopLevelDomain { get; set; }

        public string Password { get; set; }

        public string AvatarName { get; set; }

        public List<string> Interests { get; set; }

        public User(string emailUserName, string emailDomain, string emailTopLevelDomain, string password, string avatarName, List<string> interests)
        {
            EmailUserName = emailUserName;
            EmailDomain = emailDomain;
            EmailTopLevelDomain = emailTopLevelDomain;
            Password = password;
            AvatarName = avatarName;
            Interests = interests;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   EmailUserName == user.EmailUserName &&
                   EmailDomain == user.EmailDomain &&
                   EmailTopLevelDomain == user.EmailTopLevelDomain &&
                   Password == user.Password &&
                   AvatarName == user.AvatarName &&
                   Interests.OrderBy(e => e).SequenceEqual(user.Interests.OrderBy(e => e));
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(EmailUserName, EmailDomain, EmailTopLevelDomain, Password, AvatarName, Interests);
        }
    }
}
