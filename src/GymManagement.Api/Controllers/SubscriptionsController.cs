using GymManagement.Application.Services;
using GymManagement.Contracts.Subscriptions;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers
{
    [ApiController]
    [Route("api/subscriptions")]
    public class SubscriptionsController : ControllerBase
    {
        private readonly ISubscriptionService _subscriptionService;
        public SubscriptionsController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        [HttpPost]
        public IActionResult CreateSubscription(CreateSubscriptionRequest request)
        {
            var subscriptionId = _subscriptionService.CreateSubscription(request.subscriptionType.ToString(), request.AdminId);

            var response = new CreateSubscriptionResponse(subscriptionId,request.subscriptionType);

            return Ok(response);
        }
    }
}