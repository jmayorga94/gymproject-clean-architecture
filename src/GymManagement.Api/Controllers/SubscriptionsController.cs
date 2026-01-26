using GymManagement.Application.Subscriptions.Commands.CreateSubscription;
using GymManagement.Contracts.Subscriptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers
{
    [ApiController]
    [Route("api/subscriptions")]
    public class SubscriptionsController : ControllerBase
    {
        private readonly ISender _mediator;
        public SubscriptionsController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubscription(CreateSubscriptionRequest request)
        {
            var command = new CreateSubscriptionCommand(
                request.SubscriptionType.ToString(),
                request.AdminId);

            var createSubscriptionResult = await _mediator.Send(command);

            return createSubscriptionResult.MatchFirst(
                subscription => Ok(new CreateSubscriptionResponse(
                    subscription.Id,
                    request.SubscriptionType)),
                error => Problem(detail: error.Description, title: error.Code)
            );
        }
    }
}