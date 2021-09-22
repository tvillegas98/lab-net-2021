using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;

namespace TP4.Logic
{
    public class TerritoriesLogic : BaseLogic, IABMLogic<Territories>
    {
        public void Add(Territories territory)
        {
            context.Territories.Add(territory);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Territories territory = context.Territories.Find(id);
            context.Territories.Remove(territory);
            context.SaveChanges();
        }

        public Territories Get(int id)
        {
            Territories territory = context.Territories.Find(id);
            return territory;
        }

        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }

        public void Update(Territories territory)
        {
            Territories territoryUpdate = context.Territories.Find(territory.TerritoryID);
        }
    }
}
