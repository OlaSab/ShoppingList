using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
            //{
            //    new Models.ShoppingList(1, "Mat", "Ola");
            //    new Models.ShoppingList(2, "Clas Ohlson", "Ola"),
            //    new Models.ShoppingList(3, "Apotek", "Ola"),
            //};

        public ShoppingListController()
        {
            //shoppingLists.Add(new Models.ShoppingList(1, "Mat", "Ola"));
            //shoppingLists.Add(new Models.ShoppingList(2, "Clas Ohlson", "Ola"));
            //shoppingLists.Add(new Models.ShoppingList(3, "Apotek", "Ola"));
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
        public void Post([FromBody]string value)
        {

            dbShoppingList.ShoppingLists.Add(new Models.ShoppingList(3, value, "Ola"));
            dbShoppingList.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
