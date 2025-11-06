using BusinessDataLogic;
using Common;
using DataLogicc;
using kiosky_common;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService orderService;
        private readonly IEmailService emailService;

       
        public OrderController(OrderService orderService, IEmailService emailService)
        {
            this.orderService = orderService;
            this.emailService = emailService;
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

       
        [HttpPost("save")]
        public async Task<IActionResult> SaveOrderDetails([FromBody] SaveOrderRequest request)
        {
            orderService.SaveOrderDetails(request.Filename, request.ServiceType);

            
            var subject = $"Order saved: {request.Filename}";
            var body = $"An order was saved with filename: {request.Filename} and service type: {request.ServiceType}.";

           
            var testRecipient = "recipient@example.com";

            try
            {
                await emailService.SendEmailAsync(testRecipient, subject, body, isHtml: false);
            }
            catch (Exception ex)
            {
              
                return StatusCode(500, $"Order saved but failed to send email: {ex.Message}");
            }

            return Ok("Order saved successfully and email sent.");
        }
    }

    public class SaveOrderRequest
    {
        public string Filename { get; set; }
        public string ServiceType { get; set; }
    }
}
