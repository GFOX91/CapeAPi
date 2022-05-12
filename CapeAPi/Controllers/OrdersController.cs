using CapeApi.BusinessLayer.Helpers;
using CapeApi.Shared;
using Microsoft.AspNetCore.Mvc;

namespace CapeAPi.Controllers
{
    [ApiController]
    public class OrdersController : Controller
    {

        public OrdersController(IOrderHelper orderHelper)
        {
            OrderHelper = orderHelper;
        }

        public IOrderHelper OrderHelper { get; }

        [HttpPost("latestorder")]
        public async Task<IActionResult> LatestOrder([FromBody] LatestOrderRequestModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var latestOrder = await OrderHelper.GetLatestOrder(model.User, model.CustomerId);

            if (latestOrder == null)
                return NotFound($"Unable to find customer with match email:{model.User} & Id:{model.CustomerId}");

            return Ok(latestOrder);
        }

    }
}
