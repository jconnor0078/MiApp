using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MiApp.Users.Dto;
using System.Collections.Generic;

namespace MiApp.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);

        Task<PagedResultDto<UserListDto>> GetUsers();

        Task<newUserListDto> GetListUsers();

        List<UserListDto> GetLisU();

        Task CreateUser(CreateUserInput input);
    }
}