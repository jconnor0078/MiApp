using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace MiApp.Products.Dto
{
    [AutoMapFrom(typeof(Product))]
    public class ProductListDto : FullAuditedEntityDto
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
