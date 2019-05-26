using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWishLists
{
    //Представление абстрактного списка
    class MyObject
    {
        private readonly int id;
        private string category, status, name, genre, comment;
        private readonly DateTime dateEdit;

        public int ID { get { return id; } }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public DateTime DateEdit { get { return dateEdit; } }

        public MyObject()
        {

        }
    }
}
