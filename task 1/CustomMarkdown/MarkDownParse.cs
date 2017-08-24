using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMarkdown
{
    public class MarkDownParse
    {
        public string texToHtml(string inputText)
        {
            string outputText;
            string atIndex1;
            string testingText;
            

            //search for header h1
            if (inputText.Contains("#"))
            {
                if ((inputText.IndexOf("#") == 0))
                {
                    outputText = inputText.Replace("#", "<h1>");
                    outputText = outputText + "</h1>";
                }
                else
                {
                    outputText = "<p>" + inputText + "</p>";
                }

            }
            else
            {
                outputText = "<p>" + inputText + "</p>";
            }

            //search for header h2
            if (inputText.Contains("##"))
            {
                if ((inputText.IndexOf("#") == 0))
                {
                    outputText = inputText.Replace("##", "<h2>");
                    outputText = outputText + "</h2>";
                }
                else
                {
                    outputText = "<p>" + inputText + "</p>";
                }

            }


            //search for horizontal line
            if (inputText.Contains("--"))
            {
                if (inputText.IndexOf("-") == 0)
                {
                    outputText = "<hr/>";
                }
                else
                {
                    outputText = "<p>" + inputText + "</p>";
                }

            }

            //strong 
            if (inputText.Contains("**"))
            {
                int firstPlace = inputText.IndexOf("*");

                var testText = inputText;
                var testTextBuilder = new StringBuilder(testText);
                testTextBuilder.Remove(firstPlace, 2);
                testTextBuilder.Insert(firstPlace, "<strong>");
                testText = testTextBuilder.ToString();
                outputText = testText;

                outputText = outputText.Replace("**", "</strong>");
                outputText = "<p>" + outputText + "</p>";


            }

            //search for code
            if (inputText.Contains("'"))
            {
                int firstPlace = inputText.IndexOf("'");

                var testText = inputText;
                var testTextBuilder = new StringBuilder(testText);
                testTextBuilder.Remove(firstPlace, 2);
                testTextBuilder.Insert(firstPlace, "<code>");
                testText = testTextBuilder.ToString();
                outputText = testText;

                outputText = outputText.Replace("'", "</code>");
                outputText = "<p>" + outputText + "</p>";
            }

            //unordered list 
            if (inputText.Contains("*"))
            {
                atIndex1 = inputText.Substring(1, 2);
                if (atIndex1.Contains(" "))
                {
                    testingText = "yes";
                }
                else
                {
                    testingText = "no";
                }
                if ((inputText.IndexOf("*") == 0) && testingText.Contains("yes"))
                {
                    int firstPlace = inputText.IndexOf("*");

                    var testText = inputText;
                    var testTextBuilder = new StringBuilder(testText);
                    testTextBuilder.Remove(firstPlace, 2);
                    testTextBuilder.Insert(firstPlace, "<li>");
                    testText = testTextBuilder.ToString();
                    outputText = testText;

                    outputText = outputText + "</li>";
                    outputText = "<ul>" + "\n" + outputText + "\n" + "</ul>";

                }
            }

          
            //italic 
            if (inputText.Contains("_"))
            {
                int firstPlace = inputText.IndexOf("_");

                var testText = inputText;
                var testTextBuilder = new StringBuilder(testText);
                testTextBuilder.Remove(firstPlace, 1);
                testTextBuilder.Insert(firstPlace, "<em>");
                testText = testTextBuilder.ToString();
                outputText = testText;

                outputText = outputText.Replace("_", "</em>");
                outputText = "<p>" + outputText + "</p>";


            }
            return outputText;
        }
    }
}
