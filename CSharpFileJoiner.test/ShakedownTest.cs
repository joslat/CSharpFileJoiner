using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace CSharpFileJoiner.test
{
    [TestClass]
    public class ShakedownTest
    {
        [TestMethod]
        public void TestThatTwoFilesCanBeJoined()
        {
            // Arrange
            string codepath = System.Environment.CurrentDirectory + @"\code01\";
            string ExpectedResultFilePath = System.Environment.CurrentDirectory + @"\code01Result\Code01ExpectedOutput.cs";
            string ExpectedResult = File.ReadAllText(ExpectedResultFilePath);

            // Act
            CSharpFileJoiner csfj = new CSharpFileJoiner(codepath);
            csfj.JoinSourceCodeFiles();

            // Assert
            Assert.AreEqual(csfj.JoinedSourceCode, ExpectedResult);
        }
    }
}
