using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MiApp.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiApp.Products
{
    public interface IProductAppService: IApplicationService
    {
        Task<ListResultDto<ProductListDto>> GetProducts();
    }
}
