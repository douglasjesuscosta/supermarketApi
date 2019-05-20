using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupermarketAPI.Persistence.Contexts;
using SupermarketAPI.Domain.Repositories;

namespace SupermarketAPI.Persistence.Repositories {
    public class UnitOfWork : IUnitOfWork {
 {

        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context) {
            _context = context;
        }

        public async Task CompleteAsync() {
            await _context.SaveChangesAsync();
        }


    }
}
