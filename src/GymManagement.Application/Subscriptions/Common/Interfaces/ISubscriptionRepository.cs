using GymManagement.Domain.Subscriptions;

namespace GymManagement.Application.Subscriptions.Common.Interfaces
{
    public interface ISubscriptionRepository
    {
        Task AddSubscriptionAsync(Subscription subscription);
    }
}