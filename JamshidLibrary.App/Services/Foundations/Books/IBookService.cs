// -------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// -------------------------------------------------------------

using JamshidLibrary.App.Models.Books;

namespace JamshidLibrary.App.Services.Foundations.Books
{
    public interface IBookService
    {
        Book AddBook(Book book);
        Book RetrieveBookById(Guid id);
        Book ModifyBook(Book book);
        Book RemoveBookById(Guid id);
    }
}