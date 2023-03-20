using System;
using System.Xml.Linq;

namespace lab_2
{
	public class HTML:parents
    {
        public HTML()
		{
            Name = "HTML";
            Autor = "Autor HTML Document";
            KeyWords = new List<string>();
            Theme = "HTML file";
            PathToFile = "C:/HTML.html";
            KeyWords.AddRange(new string[] { "html_1", "html_2", "html_3" });
        }
        public override string GetAllInfo()
        {
            string rowInfo = "";

            rowInfo = Name + "\n" + Autor + "\n" + string.Join(", ", KeyWords) + "\n" + Theme + "\n" + PathToFile;
            return rowInfo;
        }
	}
}

