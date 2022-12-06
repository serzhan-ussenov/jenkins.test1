using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using UserinyerfaceTests.Tests.UserRegistrationTest.TestData;

namespace UserinyerfaceTests.CustomUtilities
{
    public static class JsonFileUtil
    {
        public static T ConvertTo<T>(string inputFilePath)
        {
            if (File.Exists(inputFilePath))
            {
                return (T)Convert.ChangeType(JsonConvert.DeserializeObject<T>(File.ReadAllText(inputFilePath)), typeof(T));
            }
            else
            {
                throw new FileNotFoundException("Json file was not found");
            }
        }
    }
}
