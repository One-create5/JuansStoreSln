using System.Collections.Generic;
using FightGearProducts.Models;

namespace FightGearProducts.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }
    }
}
