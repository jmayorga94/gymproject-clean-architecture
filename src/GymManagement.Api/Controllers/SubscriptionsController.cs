using GymManagement.Contracts.Subscriptions;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers
{
    [ApiController]
    [Route("api/subscriptions")]
    public class SubscriptionsController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateSubscription(CreateSubscriptionRequest request)
        {
            // Implementation goes here
            return Ok(request);
        }
    }
}