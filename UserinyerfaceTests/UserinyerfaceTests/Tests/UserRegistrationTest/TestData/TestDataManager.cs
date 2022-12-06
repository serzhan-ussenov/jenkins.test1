using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using UserinyerfaceTests.CustomUtilities;

namespace UserinyerfaceTests.Tests.UserRegistrationTest.TestData
{
    public static class TestDataManager
    {
        private static string _dataFileSubFolder1 = "Tests";
        private static string _dataFileSubFolder2 = "UserRegistrationTest";
        private static string _dataFileSubFolder3 = "TestData";
        private static string _testDatafileName = "testdata.json";
        private static Dictionary<string, string> _testData;

        public static void Load()
        {
            string testDataPath = FileUtils.GetFullPath(_dataFileSubFolder1, _dataFileSubFolder2, _dataFileSubFolder3, _testDatafileName);
            _testData = JsonFileUtil.ConvertTo<Dictionary<string, string>>(testDataPath);
        }

        public static string GetFullPathToFile(string fileName) => FileUtils.GetFullPath(_dataFileSubFolder1, _dataFileSubFolder2, _dataFileSubFolder3, _testData[fileName]);
    }
}

