using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class ShoppingList
    {
        public int ShoppingListId { get; private set; }
        public string ShoppingListName { get; private set; }
        public string ShoppingListAuthor { get; private set; }

        public ShoppingList(int shoppingListId, string shoppingListName, string ShoppingListAuthor)
        {
            ShoppingListId = shoppingListId;
            ShoppingListName = shoppingListName;
            this.ShoppingListAuthor = ShoppingListAuthor;
        }
    }
}