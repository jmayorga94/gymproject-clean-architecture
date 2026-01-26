using ErrorOr;
using GymManagement.Application.Subscriptions.Commands.CreateSubscription;
using MediatR;

namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription
{
    public class CreateSubscriptionCommandHandler: IRequestHandler<CreateSubscriptionCommand, ErrorOr<Guid>>
    {
        public async Task<ErrorOr<Guid>> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
        {
            //return Error.Failure("Subscription.CreateFailed", "Failed to create subscription.");

            return Guid.NewGuid();
        }
    }
}