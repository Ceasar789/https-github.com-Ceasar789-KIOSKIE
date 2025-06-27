using BusinessDataLogic;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService orderService;

        public OrderController(OrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet("meals")]
        public IEnumerable<Meal> GetAllMeals()
        {
            return orderService.Meals;
        }

        [HttpGet("meals/{category}")]
        public ActionResult<IEnumerable<Meal>> GetMealsByCategory(string category)
        {
            var meals = orderService.GetMealsByCategory(category);
            if (meals == null || meals.Count == 0)
            {
                return NotFound("No meals found in that category.");
            }
            return Ok(meals);
        }

        [HttpPost("add")]
        public IActionResult AddMealToOrder([FromQuery] int mealId)
        {
            var result = orderService.AddToOrder(mealId);
            if (result.Contains("not available"))
            {
                return NotFound(result);
            }
            return Ok(result);
        }

        [HttpDelete("remove")]
        public IActionResult RemoveMealFromOrder([FromQuery] int index)
        {
            var result = orderService.RemoveFromOrder(index);
            if (result.Contains("Invalid"))
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost("receipt")]
        public IActionResult GenerateReceipt([FromQuery] string serviceType)
        {
            var receipt = orderService.GenerateReceipt(serviceType);
            return Ok(receipt);
        }

        [HttpPost("save")]
        public IActionResult SaveOrderToFile([FromQuery] string filename, [FromQuery] string serviceType)
        {
            try
            {
                orderService.SaveOrderDetails(filename, serviceType);
                return Ok("Order saved to file: " + filename);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error saving file: " + ex.Message);
            }
        }
    }
}
