using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MiApp.MultiTenancy.Dto;

namespace MiApp.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
