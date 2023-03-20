using System;
using System.Xml.Linq;

namespace lab_2
{
	public class PDF:parents
    {
        public PDF()
		{
            Name = "PDF";
            Autor = "Autor PDF Document";
            KeyWords = new List<string>();
            Theme = "PDF file";
            PathToFile = "C:/PDF.pdf";
            KeyWords.AddRange(new string[] { "pdf_1", "pdf_2", "pdf_3" });
        }
        public override string GetAllInfo()
        {
            string rowInfo = "";

            rowInfo = Name + "\n" + Autor + "\n" + string.Join(", ", KeyWords) + "\n" + Theme + "\n" + PathToFile;
            return rowInfo;
        }
	}
}

