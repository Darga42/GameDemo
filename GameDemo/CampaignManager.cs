using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    class CampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanya Listesinden Silindi. ");
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanya Listesi Kaydedildi. ");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanya Listesi Güncellendi. ");
        }
    }
}
