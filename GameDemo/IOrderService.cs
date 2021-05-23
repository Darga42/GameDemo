using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    interface IOrderService
    {
        void Order(Game game , Gamer gamer , Campaign campaign);
    }
}
