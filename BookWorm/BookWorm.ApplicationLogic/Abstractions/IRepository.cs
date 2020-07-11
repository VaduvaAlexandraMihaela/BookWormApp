using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Abstractions
{
   public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T Add(T itemtoAdd);

        T Update(T itemToUpdate);

        bool Delete(T itemToDelete);
    }
}
