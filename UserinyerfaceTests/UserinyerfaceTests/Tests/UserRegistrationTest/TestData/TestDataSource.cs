using System.Collections.Generic;
using System.Collections;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UserinyerfaceTests.CustomUtilities;

namespace UserinyerfaceTests.Tests.UserRegistrationTest.TestData
{
    public class TestDataSource<User> : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            TestDataManager.Load();
            JObject usersJObject = JsonFileUtil.ConvertTo<JObject>(TestDataManager.GetFullPathToFile("UsersFileName"));
            IEnumerable<User> users = usersJObject[$"{typeof(User).Name}"].ToObject<IEnumerable<User>>();

            foreach (var item in users)
            {
                yield return new object[] { item };
            }
        }
    }
}
