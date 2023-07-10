using ChainResponsibilityPattern.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChainResponsibilityPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateDiscountController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] Customer customer, decimal orderTotal)
        {
            var vipHandler = new VIPDiscountHandler();

            vipHandler.SetNextHandler(new RegularDiscountHandler())
                      .SetNextHandler(new NewCustomerDiscountHandler())
                      .SetNextHandler(new NoDiscountDiscountHandler());

            decimal discountAmount = vipHandler.CalculateDiscount(customer, orderTotal);

            return Ok(discountAmount);
        }
    }
}