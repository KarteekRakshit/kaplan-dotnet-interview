using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiTest.Models;
using WebApiTest.Services;
using WebApiTest.Web.Controllers;

namespace WebApiTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public IOrderItemsService _orderItemsService;

        [TestMethod]
        public void GetOrders_WhenCalled_ReturnsOkResult()
        {
            //Arrange
            int OrderId = 101;
            var controller = new OrdersController(_orderItemsService);

            //Act
            var result = controller.Get(OrderId) as ActionResult<OrderItemsModel>;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetOrders_ShouldNotFindProduct()
        {
            //Arrange
            int OrderId = 1;
            var controller = new OrdersController(_orderItemsService);

            //Act
            var result = controller.Get(OrderId) as ActionResult<OrderItemsModel>;

            //Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}
