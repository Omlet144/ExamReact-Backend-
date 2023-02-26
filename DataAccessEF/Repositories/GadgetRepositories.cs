using DataAccessEF.Data;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.Repositories
{
    public class GadgetRepositories : GenericRepository<Gadget>, IGadgetRepository
    {
        public GadgetRepositories(asp_tablesContext dbContext) : base(dbContext)
        {
        }
        public IEnumerable<Gadget> GetAll() => _dbContext.Gadgets.ToList();

        public Gadget GetId(int id)
        {
            return _dbContext.Gadgets.Find(id);
        }
        public IEnumerable<Gadget> GetbyIdCategory(int id)
        {
            return _dbContext.Gadgets.AsEnumerable().Where(x => x.IdCategory == id);
        }
    }
}
