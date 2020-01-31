using NUnit.Framework;

namespace ACM_Technical_Test.Tests
{
    public class Tests
    {
        [Test]
        public void GetBestTeamsReturn_MaxScore_5_TeamsWithMaxScore_2()
        {
            // Arrange
            string[] data = { "10101", "11100", "11010", "00101" };
            var manager = new TeamManager(data);

            // Act
            var result = manager.GetBestTeams();

            // Assert
            Assert.That(result[0] == 5);
            Assert.That(result[1] == 2);
        }
    }
}