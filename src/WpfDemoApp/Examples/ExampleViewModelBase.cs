using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using WpfDemoApp.DataBase;

namespace WpfDemoApp.Examples
{
    public class ExampleViewModelBase : ViewModelBase
    {
        public IEnumerable<Book> Books
        {
            get { return GetProperty(() => Books); }
            private set { SetProperty(() => Books, value); }
        }

        protected override void OnInitializeInDesignMode()
        {
            base.OnInitializeInDesignMode();
            Books = new List<Book>() {
                new Book() { Name = "Book 1" },
                new Book() { Name = "Book 2"}
            };
        }

        protected override void OnInitializeInRuntime()
        {
            base.OnInitializeInRuntime();
            Books = BookDatabase.GetExampleBooks();
        }

        [Command]
        public void Save()
        {
            
        }
        public bool CanSave()
        {
            return true;
        }
    }
}
