using System;
namespace lab_2
{
	public class Excel:parents
	{
		public Excel()
		{
            Name = "Excel";
            Autor = "Autor Excel Document";
            KeyWords = new List<string>();
            Theme = "Excel file";
            PathToFile = "C:/Excel.xls";
            KeyWords.AddRange(new string[] { "excel_1", "excel_2", "excel_3" });
        }
        public override string GetAllInfo()
        {
            string rowInfo = "";

            rowInfo = Name + "\n" + Autor + "\n" + string.Join(", ", KeyWords) + "\n" + Theme + "\n" + PathToFile;
            return rowInfo;
        }
	}
}

