using System.Collections;
using System.Collections.Generic;
using Collections.Interfaces;
using Collections.Classes;

namespace Collections.Classes
{
    public abstract class Library<T> : Book, ILibrary
    {
        Book[] items = new Book[5];
        int count;
        public int Count { get; }
        public override string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfPages { get; set; }
        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            NumberOfPages = numberOfPages;

        }
         public Book Borrow(string title)
        {
            Title.Remove(0);
            return null;
            
        }
    public void Return(Book Title)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2);
        }
        items[count++] = Title;
    }
    public IEnumerator<Book> GetEnumerator()
    {
        for (int i = 0; i < count; i++)
        {
            yield return items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }




}
}