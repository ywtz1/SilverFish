using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_131p : SimTemplate
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(p.ownHero, 5);
        }
    }
}
