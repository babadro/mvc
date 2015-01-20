using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;


namespace Parser2
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            string k = "<html><head><title>Пример 1</title></head> <body> <div class=\"bla1\">Это простейший пример HTML-документа.</div></body> </html>";
            doc.LoadHtml(k);
            HtmlNode bodyNode = doc.DocumentNode.SelectSingleNode("//div[@class='bla1']");
            Console.WriteLine(bodyNode.InnerText);
            Console.ReadLine();
        }
    }
}
