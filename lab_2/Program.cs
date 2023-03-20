using System;
using lab_2;
Console.WriteLine("Laboratory work 2");
Console.WriteLine("Write item number for menu");
for(int index = 0; Menu.GetMenu().Count()>index; index++)
{
    Console.WriteLine(index + "-" + Menu.GetMenu().GetItem(index).GetName());
}
int Key = int.Parse(Console.ReadKey().KeyChar.ToString());
Console.WriteLine("Information about the selected item");
Console.WriteLine(Menu.GetMenu().GetItem(Key).GetAllInfo());
Console.WriteLine("Press any key to exit");
Console.ReadKey();