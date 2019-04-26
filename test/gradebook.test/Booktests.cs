using System;
using Xunit;

namespace Gradebook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCaculatesGrades()
        {
            //Arrange
            var book = new Book("");
            book.AddGrade(90);
            book.AddGrade(70);
            book.AddGrade(80);

            //Act

            var result = book.GetStatistics();

            //Assert
            Assert.Equal(80, result.Average, 1);
            Assert.Equal(90, result.High, 1);
            Assert.Equal(70, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }

        [Fact]
        public void TestingRangeOfScoreBetween1And100()
        {
            var book = new Book("");
            book.AddGrade(105);
            book.AddGrade(60);

            var result = book.GetStatistics();

            Assert.Equal(60, result.High, 1);
        }
    }
}
