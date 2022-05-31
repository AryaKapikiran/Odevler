using DataAccess.Context;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Test_UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CategoryService categoryService = new CategoryService();

            foreach(var category in categoryService.GetList())
            {
                Console.WriteLine(category.CategoryName);
            }

            Console.ReadLine();

           
        }
    }
}
