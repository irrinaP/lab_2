using System;
namespace lab_2
{
	public abstract class parents
	{
		protected string Name { get; set; }
        protected string Autor { get; set; }
        protected List <string> KeyWords { get; set; }
        protected string Theme { get; set; }
        protected string PathToFile { get; set; }

        public parents()
		{
			Name = "";
            Autor = "";
            KeyWords = new List<string> ();
            Theme = "";
            PathToFile = "";
        }
        public abstract string GetAllInfo();

        public string GetName()
        {
            return Name;
        }
	}
}

