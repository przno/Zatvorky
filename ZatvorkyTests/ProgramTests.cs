using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zatvorky.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void FindPositionTest()
        {
            Assert.AreEqual(0, Program.FindPosition(""));

            Assert.AreEqual(1, Program.FindPosition("()"));
            Assert.AreEqual(2, Program.FindPosition("(())"));
            Assert.AreEqual(3, Program.FindPosition("((()))"));
            Assert.AreEqual(4, Program.FindPosition("(((())))"));
            Assert.AreEqual(5, Program.FindPosition("((((()))))"));

            Assert.AreEqual(1, Program.FindPosition("()"));
            Assert.AreEqual(2, Program.FindPosition("()()"));
            Assert.AreEqual(3, Program.FindPosition("()()()"));
            Assert.AreEqual(4, Program.FindPosition("()()()()"));
            Assert.AreEqual(5, Program.FindPosition("()()()()()"));

            Assert.AreEqual(0, Program.FindPosition("("));
            Assert.AreEqual(0, Program.FindPosition("(("));
            Assert.AreEqual(0, Program.FindPosition("((("));
            Assert.AreEqual(0, Program.FindPosition("(((("));
            Assert.AreEqual(0, Program.FindPosition("((((("));

            Assert.AreEqual(1, Program.FindPosition(")"));
            Assert.AreEqual(2, Program.FindPosition("))"));
            Assert.AreEqual(3, Program.FindPosition(")))"));
            Assert.AreEqual(4, Program.FindPosition("))))"));
            Assert.AreEqual(5, Program.FindPosition(")))))"));

            Assert.AreEqual(1, Program.FindPosition(")("));
            Assert.AreEqual(2, Program.FindPosition(")()("));
            Assert.AreEqual(3, Program.FindPosition(")()()("));
            Assert.AreEqual(4, Program.FindPosition(")()()()("));
            Assert.AreEqual(5, Program.FindPosition(")()()()()("));


            Assert.AreEqual(1, Program.FindPosition(")"));
            Assert.AreEqual(1, Program.FindPosition(")("));
            Assert.AreEqual(1, Program.FindPosition(")(("));
            Assert.AreEqual(1, Program.FindPosition(")((("));
            Assert.AreEqual(1, Program.FindPosition(")(((("));
            Assert.AreEqual(1, Program.FindPosition(")((((("));

            Assert.AreEqual(2, Program.FindPosition("))"));
            Assert.AreEqual(2, Program.FindPosition("))("));
            Assert.AreEqual(2, Program.FindPosition("))(("));
            Assert.AreEqual(2, Program.FindPosition("))((("));
            Assert.AreEqual(2, Program.FindPosition("))(((("));
            Assert.AreEqual(2, Program.FindPosition("))((((("));

            Assert.AreEqual(3, Program.FindPosition(")))"));
            Assert.AreEqual(3, Program.FindPosition(")))("));
            Assert.AreEqual(3, Program.FindPosition(")))(("));
            Assert.AreEqual(3, Program.FindPosition(")))((("));
            Assert.AreEqual(3, Program.FindPosition(")))(((("));
            Assert.AreEqual(3, Program.FindPosition(")))((((("));

            Assert.AreEqual(5, Program.FindPosition(")())()((()(("));
            Assert.AreEqual(6, Program.FindPosition(")())()((()()("));
            Assert.AreEqual(7, Program.FindPosition(")())()((()()()"));

        }
    }
}