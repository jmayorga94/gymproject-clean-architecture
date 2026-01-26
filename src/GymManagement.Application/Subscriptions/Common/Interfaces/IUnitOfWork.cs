
namespace GymManagement.Application.Subscriptions.Common.Interfaces
{
    public interface IUnitOfWork
    {
        Task CommitChangesAsync();
    }
}