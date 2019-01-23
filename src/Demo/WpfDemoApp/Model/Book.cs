using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using WpfDemoApp.Annotations;

namespace WpfDemoApp.Model
{
    public class Book : BindableBase
    {
        public string ISBN { get; set; }

        public string Publisher { get; set; }

        public string Author { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

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
