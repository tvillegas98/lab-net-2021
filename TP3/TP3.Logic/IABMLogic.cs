using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T Object);

        void Delete(int id);

        void Update(T Object);
        T Get(int id);
    }
}
