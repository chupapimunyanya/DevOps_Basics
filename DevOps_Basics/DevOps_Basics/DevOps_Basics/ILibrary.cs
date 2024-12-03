using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps_Basics
{
    public interface ILibrary
    {
        void AddBook(IBook book);
        IBook FindBookByTitle(string title);
        void DisplayBooks();
    }
}
