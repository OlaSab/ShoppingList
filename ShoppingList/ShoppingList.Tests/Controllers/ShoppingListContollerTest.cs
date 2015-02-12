using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ShoppingList.Controllers;

namespace ShoppingList.Tests.Controllers
{
    [TestFixture]
    public class ShoppingListContollerTest
    {
        [Test]
        public void WhenGettingShoppingLists()
        {
            // Arrange
            var shoppingListController = new ShoppingListController();

            // Act
            var response = shoppingListController.Get();

            // Assert
            var arrResponse = response.ToArray();
            Assert.That(arrResponse.Length, Is.GreaterThan(0));
        }

   }
}
