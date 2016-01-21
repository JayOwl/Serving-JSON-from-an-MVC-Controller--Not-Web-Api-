using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using System.Threading.Tasks;

using WebApplication19.Models;

namespace WebApplication19.Repository
{
    public class ManufacturerRepository
    {
        public async Task<List<ManufacturerVM>> GetAll()
        {
            JB_FoodStoreEntities db = new JB_FoodStoreEntities();
            List<ManufacturerVM> response = new List<ManufacturerVM>();
            response = await db.Manufacturers.Select(m => new ManufacturerVM { mfg = m.mfg, mfgDiscount = (decimal)m.mfgDiscount }).ToListAsync();
            return response;
        }
    }
}