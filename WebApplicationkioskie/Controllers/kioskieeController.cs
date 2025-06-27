using BusinessDataLogic;
using Common;
using DataLogicc;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService orderService;
        public OrderController()
        {
            IMealDataService dataService = new DBMealDataService();
            orderService = new OrderService(dataService);
        }
        [HttpGet("meals")]
        public ActionResult<List<Meal>> GetMealsByCategory(string category)
        {
            var meals = orderService.GetMealsByCategory(category);
            return Ok(meals);
        }
        [HttpPost("add/{id}")]
        public ActionResult<string> AddToOrder(int id)
        {
            var message = orderService.AddToOrder(id);
            return Ok(message);
        }
        [HttpDelete("remove/{index}")]
        public ActionResult<string> RemoveFromOrder(int index)
        {
            var message = orderService.RemoveFromOrder(index);
            return Ok(message);
        }
        [HttpGet("receipt")]
        public ActionResult<string> GetReceipt(string serviceType)
        {
            var receipt = orderService.GenerateReceipt(serviceType);
            return Ok(receipt);
        }

        // POST: api/order/save
        [HttpPost("save")]
        public IActionResult SaveOrderDetails([FromBody] SaveOrderRequest request)
        {
            orderService.SaveOrderDetails(request.Filename, request.ServiceType);
            return Ok("Order saved successfully.");
        }
    }
    public class SaveOrderRequest
    {
        public string Filename { get; set; }
        public string ServiceType { get; set; }
    }
}
