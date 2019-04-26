using System;
using Xunit;

namespace Gradebook.Tests
{
    public class TypeTests
    {

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Warren";
            var upper = MakeUpperCase(name);

            Assert.Equal("WARREN", upper);
        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void GetBookNames()
        {
            //Arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.name);
            Assert.Equal("Book 2", book2.name);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

   
    }
}
