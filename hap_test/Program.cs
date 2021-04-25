using System;
using HtmlAgilityPack;
using System.Xml;

namespace hap_test
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveHtmlFile(); // func for create new html file
            #region example
            var path = @"test.html"; // link
            var doc = new HtmlDocument(); // create new html in memory
            doc.Load(path); // install in html
            var node = doc.DocumentNode.SelectSingleNode("//body"); // search all in body
            Console.WriteLine(node.OuterHtml);
            #endregion
        }
        private static void SaveHtmlFile()
        {
            var html =
@"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.Save("test.html");
        }
    }
}
