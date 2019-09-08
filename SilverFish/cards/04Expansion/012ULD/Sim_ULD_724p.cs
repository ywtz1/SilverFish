using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_724p : SimTemplate
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int heal = 3;
            if (ownplay)
            {
                if (p.anzOwnAuchenaiSoulpriest > 0 || p.embracetheshadow > 0) heal = -heal;
                if (p.doublepriest >= 1) heal *= (2 * p.doublepriest);
            }
            else
            {
                if (p.anzEnemyAuchenaiSoulpriest >= 1) heal = -heal;
                if (p.enemydoublepriest >= 1) heal *= (2 * p.enemydoublepriest);
            }
            p.minionGetDamageOrHeal(target, -heal);
            if(target.handcard.card.type == CardDB.cardtype.MOB)
            p.minionGetBuffed(target, 3, 3);
            if(!target.own&&target.handcard.card.type == CardDB.cardtype.MOB)p.evaluatePenality += 20;
        }
    }
}
