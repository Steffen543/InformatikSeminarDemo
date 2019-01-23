using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using WpfDemoApp.DataBase;
using WpfDemoApp.Model;

namespace WpfDemoApp.UI.ViewModel
{
    public class LibraryViewModel : ViewModelBase
    {
        public ObservableCollection<BookViewModel> Books
        {
            get { return GetProperty(() => Books); }
            set { SetProperty(() => Books, value); }
        }

        public BookViewModel SelectedBook
        {
            get { return GetProperty(() => SelectedBook); }
            set { SetProperty(() => SelectedBook, value); }
        }

        protected override void OnInitializeInDesignMode()
        {
            Books = new ObservableCollection<BookViewModel>()
            {
                new BookViewModel("Test", "Test1", "Hello World", "Author", "Beschreibung"),
                new BookViewModel("Test", "Test2", "Hello World 2", "Author 2", "Beschreibung"),
                new BookViewModel("Test", "Test3", "Hello World 3", "Author 3", "Beschreibung"),
                new BookViewModel("Test", "Test4", "Hello World 4", "Author 4", "Beschreibung"),
                new BookViewModel("Test", "Test5", "Hello World 5", "Author 5", "Beschreibung")
            };
            base.OnInitializeInDesignMode();
        }

        protected override void OnInitializeInRuntime()
        {
            Books = new ObservableCollection<BookViewModel>();
            var books = BookDatabase.GetBooks();
            foreach (var book in books)
            {
                BookViewModel vm = new BookViewModel(book.ISBN, book.Publisher, book.Name, book.Author, book.Description);
                Books.Add(vm);
            }
            base.OnInitializeInRuntime();
        }

        [Command]
        public void Save()
        {
            MessageBox.Show("Buch gespeichert!");
            var book = new Book(SelectedBook.ISBN, SelectedBook.Publisher, SelectedBook.Name, SelectedBook.Author, SelectedBook.Description);
            BookDatabase.SaveBook(book);
        }
        public bool CanSave()
        {
            return SelectedBook != null && SelectedBook.ISBN.Length == 17;
        }

        [Command]
        public void Delete()
        {
            MessageBox.Show("Buch gelöscht!");
            Books.Remove(SelectedBook);
            var book = new Book(SelectedBook.ISBN, SelectedBook.Publisher, SelectedBook.Name, SelectedBook.Author, SelectedBook.Description);
            BookDatabase.DeleteBook(book);
        }
        public bool CanDelete()
        {
            return SelectedBook != null;
        }

    }
}
