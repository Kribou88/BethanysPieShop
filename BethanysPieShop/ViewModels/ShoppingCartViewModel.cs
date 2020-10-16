using System;
using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public Decimal shoppingCartTotal { get; set; }
    }
}
