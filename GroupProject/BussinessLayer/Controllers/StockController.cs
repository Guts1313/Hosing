using DataAccessLayer.IdataInterfaces;
using DataBlocks.LogicItems;

namespace BussinessLayer.Controllers
{
    public class StockController : IStockController
    {
        private IStockController _stockDAL;
        public StockController(IStockController stockController)
        {
            _stockDAL = stockController;
        }
        public bool Create(Stock stock)
        {
            return _stockDAL.Create(stock);
        }

        public bool Delete(Stock stock)
        {
            return _stockDAL.Delete(stock);
        }

        public Stock[] GetAll()
        {
            return _stockDAL.GetAll();
        }

        public Stock GetById(int id)
        {
            return _stockDAL.GetById(id);
        }

        public bool Update(Stock stock)
        {
            return _stockDAL.Update(stock);
        }

        public bool UpdateStockAmount(Stock stock)
        {
            return _stockDAL.UpdateStockAmount(stock);
        }
    }
}
