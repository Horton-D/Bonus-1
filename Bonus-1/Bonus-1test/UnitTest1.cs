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
            var test1 = convert.LetterGrade(87);
            Assert.Equal("B", test1);

        }

        [Fact]
        public void Test3()
        {
            var convert = new GradeCalc();
            var test1 = convert.LetterGrade(71);
            Assert.Equal("C", test1);

        }
        [Fact]
        public void Test4()
        {
            var convert = new GradeCalc();
            var test1 = convert.LetterGrade(65);
            Assert.Equal("D", test1);

        }
    }
}
