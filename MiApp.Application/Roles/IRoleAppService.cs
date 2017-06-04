using System.Threading.Tasks;
using Abp.Application.Services;
using MiApp.Roles.Dto;

namespace MiApp.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
