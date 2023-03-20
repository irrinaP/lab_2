using System;
using System.Xml.Linq;

namespace lab_2
{
	public class TXT:parents
    {
        public TXT()
		{
            Name = "TXT";
            Autor = "Autor TXT Document";
            KeyWords = new List<string>();
            Theme = "TXT file";
            PathToFile = "C:/TXT.txt";
            KeyWords.AddRange(new string[] { "txt_1", "txt_2", "txt_3" });
        }
        public override string GetAllInfo()
        {
            string rowInfo = "";

            rowInfo = Name + "\n" + Autor + "\n" + string.Join(", ", KeyWords) + "\n" + Theme + "\n" + PathToFile;
            return rowInfo;
        }
	}
}

