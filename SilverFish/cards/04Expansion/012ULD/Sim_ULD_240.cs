using System.Linq;

namespace HREngine.Bots
{
//对空奥术法师
    public class Sim_ULD_240 : SimTemplate
    {

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.Secret)
            {
                p.allMinionOfASideGetDamage(wasOwnCard, 2);
            }
        }
    }
}
