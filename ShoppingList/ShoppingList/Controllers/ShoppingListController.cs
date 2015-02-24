using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.Ajax.Utilities;
using ShoppingList.Models;
using ShoppingList = ShoppingList.Models.ShoppingList;

namespace ShoppingList.Controllers
{
    public class ShoppingListController : ApiController
    {
        private ShoppingListDBEntities dbShoppingList = new ShoppingListDBEntities();

        private List<Models.ShoppingList> shoppingLists = new List<Models.ShoppingList>();

        public ShoppingListController()
        {
        }

        // GET api/ShoppingListController
        public IEnumerable<Models.ShoppingList> Get()
        {
            var response =
                dbShoppingList.ShoppingLists.ToArray().Select(
                    x =>
                        new Models.ShoppingList()
                        {
                            ShoppingListId = x.ShoppingListId,
                            ShoppingListName = x.ShoppingListName,
                            ShoppingListAuthor = x.ShoppingListAuthor
                        });

            return response;
        }

        // GET api/ShoppingListController/5
        //public Models.ShoppingList Get(int id)
        //{
            
        //    //return shoppingLists.SingleOrDefault(x => x.ShoppingListId == id);
        //}

        // POST api/    
        public void Post(ShoppingList shoppingList)
        {

            dbShoppingList.ShoppingLists.Add(new Models.ShoppingList(shoppingList.ShoppingListName, "Ola"));
            dbShoppingList.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            //var x = id;
            //var y = x; ;
            var shoppListDelete = dbShoppingList.ShoppingLists.SingleOrDefault(x => x.ShoppingListId == id);
            dbShoppingList.ShoppingLists.Remove(shoppListDelete);
            dbShoppingList.SaveChanges();
        }
    }

    public class ShoppingList
    {
        public string ShoppingListName;
    }
}
