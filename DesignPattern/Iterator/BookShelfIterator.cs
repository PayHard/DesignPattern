using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class BookShelfIterator : IteratorInterface
    {
    private BookShelf bookShelf;
    private int index;
    public BookShelfIterator(BookShelf bookShelf)
    {
        this.bookShelf = bookShelf;
        this.index = 0;
    }
    public Boolean hasNext()
    {
        if (index < bookShelf.getLength())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public Object next()
    {
        Book book = bookShelf.getBookAt(index);
        index++;
        return book;
    }
}
}
