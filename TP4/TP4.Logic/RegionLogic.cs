using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;

namespace TP4.Logic
{
    public class RegionLogic : BaseLogic, IABMLogic<Region>
    {
        public void Add(Region Object)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Region Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<Region> GetAll()
        {
            return context.Region.ToList();
        }

        public void Update(Region Object)
        {
            throw new NotImplementedException();
        }
    }
}
