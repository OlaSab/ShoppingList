namespace ShoppingList.Models
{
    public partial class ShoppingList
    {
        public ShoppingList()
        {
            
        }

        public ShoppingList(string shoppingListName, string shoppingListAuthor)
        {
            this.ShoppingListName = shoppingListName;
            this.ShoppingListAuthor = shoppingListAuthor;
        }
    }
}