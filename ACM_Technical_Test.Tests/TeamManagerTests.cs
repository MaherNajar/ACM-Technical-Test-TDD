using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ACM_Technical_Test.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test, TestCaseSource(typeof(DataProvider), "TestNumbers")]
        public void GetBestTeams_Tests(int testNumber)
        {
            // Arrange
            string[] data = DataProvider.GetData(testNumber);
            var manager = new TeamManager(data);

            // Act
            var result = manager.GetBestTeams();

            // Assert
            int expectedScore = DataProvider.ExpectedResults[testNumber].maxScore;
            int expectedTeamsCount = DataProvider.ExpectedResults[testNumber].teamsWithMaxScore;

            Assert.IsTrue(result[0] == expectedScore);
            Assert.IsTrue(result[1] == expectedTeamsCount);
        }
    }


    public class DataProvider
    {
        public static IEnumerable<int> TestNumbers
        {
            get
            {
                for (int i = 0; i < 9; i++)
                {
                    yield return i;
                }
            }
        }

        public static readonly List<(int maxScore, int teamsWithMaxScore)> ExpectedResults
            = new List<(int maxScore, int teamsWithMaxScore)>
                {
                    (5,2),
                    (97,5),
                    (286,1),
                    (467,1),
                    (467,1),
                    (416,2),
                    (415,1),
                    (416,1),
                    (5,6)
                };

        public static string[] GetData(int testNumber)
        {

            string rootPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            string filePath = $"{rootPath}/test{testNumber}.txt";
            return File.ReadAllLines(filePath).Skip(1).ToArray();
        }
    }
}