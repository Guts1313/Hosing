using BussinessLayer.Controllers;
using DataAccessLayer.DAL;
using DataBlocks.LogicItems;
using DataItems.LogicItems;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Headers;

namespace GroupProject.Pages
{
    public class StockModel : PageModel
    {
        private Employee _loggedInEmployee;
        private readonly EmployeeController _employeeController;
        private readonly StockController _stockController;
        public Stock[] stocks;
        public StockModel()
        {
            _employeeController = new(new DALEmployeeController());
            _stockController = new(new DALStockController());
        }
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                _loggedInEmployee = _employeeController.Get(HttpContext.Session.GetString("username"));
            }
            stocks = _stockController.GetAll();

            return Page();
        }
        public IActionResult UpdateStock()
        {
            if (int.TryParse(Request.Form["id"], out int id) && int.TryParse(Request.Form["amount"], out int newAmount))
            {
                Stock stockToUpdate = _stockController.GetById(id);
                stockToUpdate.UpdateAmount(newAmount);
                _stockController.UpdateStockAmount(stockToUpdate);
            }
            stocks = _stockController.GetAll();

            return Page();
        }
    }
}
