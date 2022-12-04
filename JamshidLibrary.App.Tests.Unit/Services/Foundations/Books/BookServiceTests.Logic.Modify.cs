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
        public void ShouldModifyBook()
        {
            // given
            Book randomBook = CreateRandomBook();
            Book inputBook = randomBook;
            Book storageBook = inputBook;
            Book expectedBook = storageBook;

            this.storageBrokerMock.Setup(broker =>
                broker.UpdateBook(inputBook))
                    .Returns(storageBook);

            // when
            Book actualBook =
                this.bookService.ModifyBook(inputBook);

            // then
            actualBook.Should().BeEquivalentTo(expectedBook);

            this.storageBrokerMock.Verify(broker =>
                broker.UpdateBook(inputBook),
                    Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
