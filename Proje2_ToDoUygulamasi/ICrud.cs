using System;

namespace Proje2_ToDoUygulamasi
{
    public interface ICrud
    {
        public void Add();
        public void Update();
        public void Delete();
        public void GetLists();
    }
}