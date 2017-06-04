using Abp.Authorization;
using Abp.Domain.Repositories;
using MiApp.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using MiApp.Products.Dto;
using Abp.AutoMapper;

namespace MiApp.Products
{
    //[AbpAuthorize(PermissionNames.Pages_Products)]
    public class ProductAppService: MiAppAppServiceBase, IProductAppService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IPermissionManager _permissionManager;

        public ProductAppService(IRepository<Product> productRepository, IPermissionManager permissionManager)
        {
            _productRepository = productRepository;
            _permissionManager = permissionManager;
        }

        public async Task<ListResultDto<ProductListDto>> GetProducts()
        {
            var products = await _productRepository.GetAllListAsync();

            return new ListResultDto<ProductListDto>(
                products.MapTo<List<ProductListDto>>()
                );
        }

 
    }
}
