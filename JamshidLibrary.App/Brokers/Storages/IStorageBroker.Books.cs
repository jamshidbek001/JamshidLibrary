// -------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// -------------------------------------------------------------

using JamshidLibrary.App.Models.Books;

namespace JamshidLibrary.App.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        Book InsertBook(Book book);
        List<Book> SelectAllBooks();
        Book SelectBookById(Guid bookId);
        Book UpdateBook(Book book);
        Book DeleteBook(Book book);
    }
}
