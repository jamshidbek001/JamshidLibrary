// -------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// -------------------------------------------------------------

using FluentAssertions;
using JamshidLibrary.App.Models.Books;
using Moq;
using Xunit;

namespace JamshidLibrary.App.Tests.Unit.Services.Foundations.Books
{
    public partial class BookServiceTests
    {
        [Fact]
        public void ShouldRetrieveBookById()
        {
            // given
            Guid randomId = Guid.NewGuid();
            Guid inputBookId = randomId;
            Book randomBook = new Book();
            Book storageBook = randomBook;
            Book expectedBook = storageBook;

            this.storageBrokerMock.Setup(broker =>
                broker.SelectBookById(inputBookId)) 
                    .Returns(storageBook);

            // when
            Book actualBook =
                this.bookService.RetrieveBookById(inputBookId);

            // then
            actualBook.Should().BeEquivalentTo(expectedBook);

            this.storageBrokerMock.Verify(broker =>
                broker.SelectBookById(inputBookId),
                    Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();       
        }
    }
}
