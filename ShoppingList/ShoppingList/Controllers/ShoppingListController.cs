using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.Ajax.Utilities;
using ShoppingList = ShoppingList.Models.ShoppingList;

namespace ShoppingList.Controllers
{
    public class ShoppingListController : ApiController
    {
        private List<Models.ShoppingList> shoppingLists = new List<Models.ShoppingList>();
            //{
            //    new Models.ShoppingList(1, "Mat", "Ola");
            //    new Models.ShoppingList(2, "Clas Ohlson", "Ola"),
            //    new Models.ShoppingList(3, "Apotek", "Ola"),
            //};

        public ShoppingListController()
        {
            shoppingLists.Add(new Models.ShoppingList(1, "Mat", "Ola"));
            shoppingLists.Add(new Models.ShoppingList(2, "Clas Ohlson", "Ola"));
            shoppingLists.Add(new Models.ShoppingList(3, "Apotek", "Ola"));
        }
        // GET api/ShoppingListController
        public IEnumerable<Models.ShoppingList> Get()
        {
            return shoppingLists;
        }

        // GET api/ShoppingListController/5
        public Models.ShoppingList Get(int id)
        {
            return shoppingLists.SingleOrDefault(x => x.ShoppingListId == id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            shoppingLists.Add(new Models.ShoppingList(3, "Apotek", value));
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
