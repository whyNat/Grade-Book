using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {   
            var book = new Book("My Grade Book");
            book.AddGrade(33.33);
            book.ShowStatistics();  
        }
    }
}
