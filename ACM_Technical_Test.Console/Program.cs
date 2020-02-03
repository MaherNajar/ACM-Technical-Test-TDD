using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;

namespace ACM_Technical_Test.Console
{
    static class Program
    {
        static void Main()
        {
            Test0();
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();
            Test6();
            Test7();
            Test8();
        }

        static void Test0() {
             // Arrange
            string[] data =  GetData("test0");
            var manager = new TeamManager(data);

            // Act
            var result = manager.GetBestTeams();

            // Assert
            Contract.Assert(result[0] == 5);
            Contract.Assert(result[1] == 2);
        }

        static void Test1() {
             // Arrange
            string[] data =  GetData("test1");
            var manager = new TeamManager(data);

            // Act
            var result = manager.GetBestTeams();

            // Assert
            Contract.Assert(result[0] == 97);
            Contract.Assert(result[1] == 5);
        }

        static void Test2() {
             // Arrange
            string[] data =  GetData("test2");
            var manager = new TeamManager(data);

            // Act
            var result = manager.GetBestTeams();

            // Assert
            Contract.Assert(result[0] == 286);
            Contract.Assert(result[1] == 1);
        }

        static void Test3() {
             // Arrange
            string[] data =  GetData("test3");
            var manager = new TeamManager(data);

            // Act
            var result = manager.GetBestTeams();

            // Assert
            Contract.Assert(result[0] == 467);
            Contract.Assert(result[1] == 1);
        }

        static void Test4() {
             // Arrange
            string[] data =  GetData("test4");
            var manager = new TeamManager(data);

            // Act
            var result = manager.GetBestTeams();

            // Assert
            Contract.Assert(result[0] == 467);
            Contract.Assert(result[1] == 1);
        }


        static void Test5() {
             // Arrange
            string[] data =  GetData("test5");
            var manager = new TeamManager(data);

            // Act
            var result = manager.GetBestTeams();

            // Assert
            Contract.Assert(result[0] == 416);
            Contract.Assert(result[1] == 2);
        }

        
        static void Test6() {
               // Arrange
            string[] data =  GetData("test6");
            var manager = new TeamManager(data);

            // Act
            var result = manager.GetBestTeams();

            // Assert
            Contract.Assert(result[0] == 415);
            Contract.Assert(result[1] == 1);
        }

        
        static void Test7() {
               // Arrange
            string[] data =  GetData("test7");
            var manager = new TeamManager(data);

            // Act
            var result = manager.GetBestTeams();

            // Assert
            Contract.Assert(result[0] == 416);
            Contract.Assert(result[1] == 1);            
        }

        
        static void Test8() {
               // Arrange
            string[] data =  GetData("test8");
            var manager = new TeamManager(data);

            // Act
            var result = manager.GetBestTeams();

            // Assert
            Contract.Assert(result[0] == 5);
            Contract.Assert(result[1] == 6);
        }

        static string[] GetData(string fileName) {

            string rootPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            string filePath = $"{rootPath}/{fileName}.txt";
            return File.ReadAllLines(filePath).Skip(1).ToArray();
        }
    }
}
