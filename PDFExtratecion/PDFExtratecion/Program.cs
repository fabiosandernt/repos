using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace PDFExtratecion {
    class Program {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            string file = @"C:\Users\User\source\repos\PDFExtratecion\PDFExtratecion\Files\Teste2.pdf";
            using (PdfReader reader = new PdfReader(file))
            {
                for (int pageNo = 1; pageNo <= reader.NumberOfPages; pageNo++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string text = PdfTextExtractor.GetTextFromPage(reader, pageNo, strategy);
                    text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text)));
                    sb.Append(text);
                    Console.WriteLine("Quantidade de caracteres", sb.Length);
                    Console.ReadKey();

                }
                
            }
            
            //for (int i = 0; i <= 4446; i++)
            //{
            //    Console.WriteLine(sb[i].ToString());
            //          }
            //Console.ReadKey();

            //Console.WriteLine("Quantidade de caracteres", text.Length);

            //Console.WriteLine(sb.ToString());
            //Console.ReadKey();

            //Console.WriteLine(sb[558].ToString());
            //Console.WriteLine(sb[559].ToString());
            //Console.WriteLine(sb[560].ToString());
            //Console.WriteLine(sb[561].ToString());
            //Console.WriteLine(sb[562].ToString());
            //Console.WriteLine(sb[563].ToString());
            //Console.WriteLine(sb[564].ToString());
            //Console.WriteLine(sb[565].ToString());
            //Console.WriteLine(sb[566].ToString());
            //Console.WriteLine(sb[567].ToString());
            //Console.ReadKey();


        }
    }
}
