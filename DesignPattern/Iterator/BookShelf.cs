using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class BookShelf : AggregateInterface
    {
    private Book[] books;
    private int last = 0;
    public BookShelf(int maxsize)
    {
        this.books = new Book[maxsize];
    }
    public Book getBookAt(int index)
    {
        return books[index];
    }
    public void appendBook(Book book)
    {
        this.books[last] = book;
        last++;
    }
    public int getLength()
    {
        return last;
    }
    public IteratorInterface iterator()
    {
        return new BookShelfIterator(this);
    }
}
}
