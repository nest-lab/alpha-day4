using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMarkdown
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is an html markdown
            // the functions available for this are
            // paragraph <p></p>
            //header <h1></h1>
            //header <h2></h2>
            //italics <em></em>  like this _italics_
            //code <code></code> like this 'code'
            //bold <strong></strong>
            //unordered list <li></li>
            //horizontal line <hr/>


           Console.WriteLine("Enter a whole lof of text: ");
            string  inputText = Console.ReadLine();

            MarkDownParse myParser = new MarkDownParse();
            string result = myParser.texToHtml(inputText);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
