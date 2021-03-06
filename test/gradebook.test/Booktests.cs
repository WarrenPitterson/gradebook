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
            var book = new InMemoryBook("");
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
    }
}
