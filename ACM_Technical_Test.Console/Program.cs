using System;
using System.Diagnostics.Contracts;

namespace ACM_Technical_Test.Console
{
    class Program
    {
        static void Main(string[] args)
        {
             // Arrange
            string[] data = { "10101", "11100", "11010", "00101" };
            var manager = new TeamManager(data);

            // Act
            var result = manager.GetBestTeams();

            // Assert
            Contract.Assert(result[0] == 5);
            Contract.Assert(result[1] == 2);
        }
    }
}
