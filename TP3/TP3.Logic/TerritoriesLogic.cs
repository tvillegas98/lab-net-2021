using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Entities;

namespace TP3.Logic
{
    public class TerritoriesLogic : BaseLogic
    {
        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }
    }
}
