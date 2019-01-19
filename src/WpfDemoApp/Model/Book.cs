using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace WpfDemoApp.Model
{
    public class Book : BindableBase
    {
        public string ISBN
        {
            get { return GetProperty(() => ISBN); }
            set { SetProperty(() => ISBN, value); }
        }

        public string Publisher
        {
            get { return GetProperty(() => Publisher); }
            set { SetProperty(() => Publisher, value); }
        }

        public string Author
        {
            get { return GetProperty(() => Author); }
            set { SetProperty(() => Author, value); }
        }

        public string Name
        {
            get { return GetProperty(() => Name); }
            set { SetProperty(() => Name, value); }
        }

        public string Description
        {
            get { return GetProperty(() => Description); }
            set { SetProperty(() => Description, value); }
        }

        public Book(string isbn, string publisher, string name, string author, string description)
        {
            ISBN = isbn;
            Publisher = publisher;
            Name = name;
            Author = author;
            Description = description;
        }
    }
}
