using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    class OrderManager : IOrderService
    {
        public void Order(Game game, Gamer gamer, Campaign campaign)
        {
            int campaignPrice = game.GamePrice - (game.GamePrice * campaign.DiscountRate / 100);
            Console.WriteLine
                (game.GameName + gamer.FirstName + "tarafından " + campaign.CampaignName + "kampanyasında" + campaignPrice + "satın alındı.");
        }
    }
}
