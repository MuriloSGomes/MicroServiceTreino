using Basket.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        public Task DeleteBasket(string username)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCart> GetBasket(string username)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCart> UpdateBasket(ShoppingCart basket)
        {
            throw new NotImplementedException();
        }
    }
}
