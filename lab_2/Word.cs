using System;
namespace lab_2
{
	public class Word : parents
	{
		public Word()
		{
			Name = "Word";
            Autor = "Autor Word Document";
            KeyWords = new List<string>();
            Theme = "MS Word";
			PathToFile = "C:/Word.doc";
			KeyWords.AddRange(new string[] { "word_1", "word_2", "word_3" });
        }
		public override string GetAllInfo()
		{
            string rowInfo = "";

            rowInfo = Name + "\n" + Autor + "\n" + string.Join(", ", KeyWords) + "\n" + Theme + "\n" + PathToFile;
            return rowInfo;
        }

    }
}

