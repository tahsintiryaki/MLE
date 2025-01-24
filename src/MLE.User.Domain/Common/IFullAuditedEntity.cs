using MLE.User.Domain.Common;

namespace MLE.User.Domain.Entities;

public interface IFullAuditedEntity : IHasCreation, IHasUpdate, ISoftDeletion, IHasActive
{
}