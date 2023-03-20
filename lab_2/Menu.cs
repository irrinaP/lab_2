using System;

namespace lab_2
{
	public class Menu
	{
		private parents [] MenuItems;

		private Menu()
		{
			MenuItems = new parents[]
			{
				new Word(), new PDF(), new Excel(), new TXT(), new HTML()
            };

		}
		private static readonly Menu SingletonMenu = new Menu();

		public static Menu GetMenu()
		{
			return SingletonMenu;

        }
		public parents [] GetMenuItems()
		{
			return MenuItems;
		}
		public parents GetItem(int Index)
		{
			return MenuItems[Index];
		}
		public int Count()
		{
			return MenuItems.Count();
		}
    }
}

