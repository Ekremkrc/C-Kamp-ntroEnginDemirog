using HomeWork_5_GamerProject.Interfaces;
using HomeWork_5_GamerProject.Props;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_GamerProject.Managers
{
    internal class CampaignManager
    {
        public double MakeCampaign(Game game, ICampaignService campaign)
        {
            return campaign.Discount(game.Price);
        }
    }
}
