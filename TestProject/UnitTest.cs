using CodingDojo_Diamond;

namespace TestProject
{
    public class UnitTest
    {
        [Fact]
        public void TestNotALetter()
        {
            Assert.Equal("", Diamond.Create('2'));
        }

        [Fact]
        public void TestA()
        {
            Assert.Equal("A", Diamond.Create('A'));
        }

        [Fact]
        public void TestB()
        {
            Assert.Equal(" A \nB B\n A ", Diamond.Create('B'));
        }

        [Fact]
        public void TestC()
        {
            Assert.Equal("  A  \n B B \nC   C\n  A  ", Diamond.Create('C'));
        }

        [Fact]
        public void TestF()
        {
            Assert.Equal("     A     \n    B B    \n   C   C   \n  D     D  \n E       E \nF         F\n E       E \n  D     D  \n   C   C   \n    B B    \n     A     ", Diamond.Create('C'));
        }
    }
}
