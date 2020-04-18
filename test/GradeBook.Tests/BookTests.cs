using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(77.1);
            book.AddGrade(11.12);
            book.AddGrade(10.10);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(99.2, result.Average, 1);
            Assert.Equal(77.1, result.High, 1);
            Assert.Equal(10.10, result.Low, 1);

        }
    }
}
