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
        private Models.ShoppingList[] shoppingLists = 
        {
            new Models.ShoppingList(1, "Mat", "Ola"),
            new Models.ShoppingList(2, "Clas Ohlson", "Ola"),
            new Models.ShoppingList(3, "Apotek", "Ola")
        };

        // GET api/ShoppingListController
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/ShoppingListController/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
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
