using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SearchString
{
    class Program
    {
        static void Main(string[] args)
        {
            //remember the corpus.txt if located int the SearchString\SearchString\bin\Debug folder
            string testText = "corpus.txt";
            Console.WriteLine("Enter search Input");
            string searchWord = Console.ReadLine();
            
            SearchAlgo algo = new SearchAlgo();
            algo.Search(testText, searchWord);
            Console.ReadLine();

          


        }



    }
}
