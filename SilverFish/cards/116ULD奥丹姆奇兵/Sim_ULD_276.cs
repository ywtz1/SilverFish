using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_276 : SimTemplate
    {

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                p.drawACard(CardDB.cardName.witchylackey, turnEndOfOwner);
            }
        }

    }
}
