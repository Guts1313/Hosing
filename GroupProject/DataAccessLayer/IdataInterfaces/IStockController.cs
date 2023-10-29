using DataBlocks.LogicItems;
using DataItems.LogicItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IdataInterfaces
{
    public interface IStockController
    {
        public bool Create(Stock stock);

        public bool Update(Stock stock);

        public bool Delete(Stock stock);

        public bool UpdateStockAmount(Stock stock);

        public Stock[] GetAll();

        public Stock GetById(int id);
    }
}
