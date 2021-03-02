using System;
using System.Collections.Generic;
using System.Text;

namespace MenuGenerator
{
    public class GenerateMenu
    {
		public void CreatMenu(List<MenuItemModel> ItemList, string MenuTitle)
		{
			while (true)
			{
				string chooesOption = "";
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine($"--------------- {MenuTitle} ---------------");
				Console.WriteLine("");

				foreach (MenuItemModel item in ItemList)
				{
					Console.WriteLine($"{item.ItemName}	{item.ItemShortcut} \n");
				}

				Console.WriteLine("----------------------------------------");
				Console.WriteLine("");
				Console.WriteLine("Please choose option: ");
				chooesOption = Console.ReadLine();


				foreach (MenuItemModel item in ItemList)
				{
					if (item.ItemShortcut == chooesOption)
					{
						//Console.WriteLine($"Wybrano opcje: {item.ItemName}");
						//Console.ReadKey();
						item.ActionMethod();
						break;
					}
					// tu do poprway, wstawic cos jesli zostanie podana zla opcja
				}
			}
		}
	}
}
