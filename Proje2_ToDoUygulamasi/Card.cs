using System;

namespace Proje2_ToDoUygulamasi
{

    class Card
    {
        private string _title;
        private string _content;
        private Employee _employee;
        private Size _size;

        public string Title { get => _title; set => _title = value; }
        public string Content { get => _content; set => _content = value; }
        public Employee Employee { get => _employee; set => _employee = value; }
        public Size Sizee { get => _size; set => _size = value; }

        public Card(string title,
                    string content,
                    Employee employee,
                    Size size)
        {
            _title = title;
            _content = content;
            _employee = employee;
            _size = size;
        }

        public Card()
        {

        }

        public enum Size
        {
            XS = 1,
            S,

            M,
            L,
            XL
        }
    }


}