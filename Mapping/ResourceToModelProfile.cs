﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Resources;

namespace SupermarketAPI.Mapping {
    public class ResourceToModelProfile : Profile {

        public ResourceToModelProfile() {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
