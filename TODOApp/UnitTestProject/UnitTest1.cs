using NUnit.Framework;
using System.IO;
using TODOApp;

namespace UnitTestProject
{
    [TestFixture]
    public class TestFileHandler
    {
        FileHandler handler = new FileHandler();

        [Test]
        public void TestWriteNewTask()
        {
            string fileName = "writeNewTaskInput.txt";
            string line = "Programming";
            string testFileName = "writeNewTaskOutput.txt";

            handler.WriteNewTask(fileName, line);
            Assert.AreEqual(File.ReadAllText(testFileName), File.ReadAllText(fileName));
        }

        [Test]
        public void TestRemoveTask()
        {
            string fileName = "removeTaskInput.txt";
            int index = 2;
            string testFileName = "removeTaskOutput.txt";

            handler.RemoveTask(fileName, index);
            Assert.AreEqual(File.ReadAllText(testFileName), File.ReadAllText(fileName));
        }

        [Test]
        public void TestCheckTask()
        {
            string fileName = "checkTaskInput.txt";
            int index = 4;
            string testFileName = "checkTaskOutput.txt";

            handler.CheckTask(fileName, index);
            Assert.AreEqual(File.ReadAllText(testFileName), File.ReadAllText(fileName));
        }
    }
}
