// -------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// -------------------------------------------------------------

using FluentAssertions;
using Force.DeepCloner;
using JamshidLibrary.App.Models.Books;
using Moq;
using Xunit;

namespace JamshidLibrary.App.Tests.Unit.Services.Foundations.Books
{
    public partial class BookServiceTests
    {
        [Fact]
        public void ShouldAddBook()
        {
            // given
            var randomBook = new Book();
            Book inputBook = randomBook;
            Book storageBook = inputBook;
            Book expectedBook = storageBook.DeepClone();

            this.storageBrokerMock.Setup(broker =>
                broker.InsertBook(inputBook))
                    .Returns(storageBook);

            // when
            Book actualBook =
                this.bookService.AddBook(inputBook);

            // then
            actualBook.Should().BeEquivalentTo(expectedBook);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertBook(inputBook),
                    Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
