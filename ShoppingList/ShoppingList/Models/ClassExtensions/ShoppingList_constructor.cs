namespace ShoppingList.Models
{
    public partial class ShoppingList
    {
        public ShoppingList()
        {
            
        }

        public ShoppingList(int shoppingListId, string shoppingListName, string shoppingListAuthor)
        {
            this.ShoppingListId = shoppingListId;
            this.ShoppingListName = shoppingListName;
            this.ShoppingListAuthor = shoppingListAuthor;
        }
    }
}