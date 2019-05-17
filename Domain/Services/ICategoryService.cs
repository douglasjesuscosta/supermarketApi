using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupermarketAPI.Domain.Models;

namespace SupermarketAPI.Domain.Services {
    public interface ICategoryService {
        Task<IEnumerable<Category>> ListAsync();
    }
}
