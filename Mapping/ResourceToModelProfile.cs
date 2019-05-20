using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Resources;
using AutoMapper;

namespace SupermarketAPI.Mapping {
    public class ResourceToModelProfile : Profile {

        public ResourceToModelProfile() {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
