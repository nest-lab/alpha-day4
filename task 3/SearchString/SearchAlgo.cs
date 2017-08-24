using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchString
{
    public class SearchAlgo
    {
        public void Search( string _filename, string _searchWord)
        {
            string filename = _filename;
            string searchWord = _searchWord;
            List<string> foundData = new List<string>();
            List<int> foundDataIndex = new List<int>();

            string[] sdata;
            char[] delimiter = new char[] { ' ' };

            StreamReader reader = new StreamReader(filename);
            string data = reader.ReadToEnd();

            

            sdata = data.Split(delimiter, data.Length);
            foreach (string word in sdata)
            {
                string newSearchWord = searchWord.ToLower();
                string newWord = word.ToLower();
                if (newWord.Equals(newSearchWord))
                {
                    foundData.Add(word);

                }

            }

            if (foundData.Count != 0)
            {
                Console.WriteLine("found");

            }
            else
            {
                Console.WriteLine("Not found");
            }

            SeqSearch(sdata, searchWord);

            int firstIndex = foundDataIndex.FirstOrDefault();
            Console.WriteLine("The word you search is  the " + firstIndex + " in the file");

            Console.ReadLine();

            //searching the index of the word 
            void SeqSearch(string[] arr, string sValue)
            {
                for (int index = 0; index < arr.Length - 1; index++)
                    if (arr[index] == sValue)
                        foundDataIndex.Add(index);

            }


        

    }
    }
}
