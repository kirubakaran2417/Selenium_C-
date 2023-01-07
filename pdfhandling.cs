using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text;
using System.Diagnostics;

namespace TestProject1
{
    [TestClass]
    public class pdfhandling
    {
                     
        [TestMethod]
        public void TestMethod1()
        {
            string path = "C:\\Users\\k.kirubakaran\\Downloads\\Day wise Agenda.pdf";
            using (PdfReader reader = new PdfReader(path))
            {
                for(int pageno=1;pageno<=reader.NumberOfPages;pageno++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string text=PdfTextExtractor.GetTextFromPage(reader, pageno,strategy);
                    text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default,
                        Encoding.UTF8, Encoding.Default.GetBytes(text)));
                    Debug.WriteLine(text);
                }
            }

        }

    }
}