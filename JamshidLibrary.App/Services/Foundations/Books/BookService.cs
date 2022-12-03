// -------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// -------------------------------------------------------------

using JamshidLibrary.App.Brokers.Storages;
using JamshidLibrary.App.Models.Books;

namespace JamshidLibrary.App.Services.Foundations.Books
{
    public class BookService : IBookService
    {
        private readonly IStorageBroker storageBroker;

        public BookService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public Book AddBook(Book book)
        {
            Book storageBook =
                this.storageBroker.InsertBook(book);

            return storageBook;
        }
    }
}