// -------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// -------------------------------------------------------------

using JamshidLibrary.App.Brokers.Storages;
using JamshidLibrary.App.Models.Books;
using JamshidLibrary.App.Services.Foundations.Books;
using Moq;
using Tynamix.ObjectFiller;

namespace JamshidLibrary.App.Tests.Unit.Services.Foundations.Books
{
    public partial class BookServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly IBookService bookService;

        public BookServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();

            this.bookService =
                new BookService(storageBroker: this.storageBrokerMock.Object);
        }

        public static Book CreateRandomBook() =>
            CreateBookFiller().Create();

        public static DateTimeOffset GetRandomDateTimeOffset() =>
            new DateTimeRange(earliestDate: new DateTime()).GetValue();

        private static Filler<Book> CreateBookFiller()
        {
            var filler = new Filler<Book>();

            filler.Setup()
                .OnType<DateTimeOffset>().Use(GetRandomDateTimeOffset())
                .OnType<bool>().Use(true);

            return filler;
        }
    }
}
