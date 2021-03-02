using System;
using System.Collections.Generic;
using System.Text;

namespace MenuGenerator
{
    public class MenuItemModel
    {
        public MenuItemModel(string itemName, string itemShortcut, Action actionMethod)
        {
            ItemName = itemName;
            ItemShortcut = itemShortcut;
            ActionMethod = actionMethod;
        }

        public string ItemName { get; set; }
        public string ItemShortcut { get; set; }
        public Action ActionMethod { get; set; }
    }
}
