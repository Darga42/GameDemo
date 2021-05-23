using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int DiscountRate { get; set; }

    }
}
