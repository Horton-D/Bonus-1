using System;
using Bonus_1;
using Xunit;

namespace Bonus_1test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var convert = new GradeCalc();
            var test1 = convert.LetterGrade(90);
            Assert.Equal("A", test1);

        }

        [Fact]
        public void Test2()
        {
            var convert = new GradeCalc();
            var test2 = convert.LetterGrade(87);
            Assert.Equal("B", test2);

        }

        [Fact]
        public void Test3()
        {
            var convert = new GradeCalc();
            var test3 = convert.LetterGrade(71);
            Assert.Equal("C", test3);

        }
        [Fact]
        public void Test4()
        {
            var convert = new GradeCalc();
            var test4 = convert.LetterGrade(65);
            Assert.Equal("D", test4);

        }
    }
}
