using MtslErp.Common.Domain.CoreProviders;
using MtslErp.Common.Domain.DataTransferObjects.Request;
using MtslErp.Common.Domain.DataTransferObjects.Response;
using MtslErp.Common.Domain.Repositories;
using SecurityManagement.Domain.DataTransferObjects.Response;
using SecurityManagement.Domain.Entities;

namespace SecurityManagement.Domain.Repositories;

public interface IUserRepository : IRepositoryBase<User>
{
    Task<PagedData<UserResponse>> GetPagedDataForDynamicQueryAsync(DynamicQueryDto dto,
        IReflectionCacheProvider reflectionCacheProvider, CancellationToken cancellationToken = default);
}
