﻿// -------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// -------------------------------------------------------------

using JamshidLibrary.App.Models.Books;

namespace JamshidLibrary.App.Brokers.Storages
{
    public partial class StorageBroker
    {
        List<Book> Books = new List<Book>();

        public Book InsertBook(Book book)
        {
            Books.Add(book);

            return book;
        }
        
        public  List<Book> SelectAllBooks() => Books;

        public Book SelectBookById(Guid id) =>
            Books.Find(book => book.Id == id);

        public Book UpdateBook(Book book)
        {
            Books.RemoveAll(book => book.Id == book.Id);
            Books.Add(book);

            return book;
        }

        public Book DeleteBook(Book book)
        {
            Books.Remove(book);

            return book;
        }
    }
}
