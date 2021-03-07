using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTest.Models;

namespace WebApiTest.Services
{

    public interface IOrdersController
    {
        ActionResult<OrderItemsModel> Get(int orderID);
        Task<short> Post(int orderID, OrderItemModel item);
        public bool DeleteResource(int orderID, OrderItemModel item);
    }
}
