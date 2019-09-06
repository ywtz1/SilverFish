using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_773 : SimTemplate //* 魔法飞毯
    {


        // after you play a 1-cost minion,give it +1/+0 and rush.
       public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
       {
           if (summonedMinion.playedFromHand && summonedMinion.own == m.own && summonedMinion.entitiyID != m.entitiyID
            &&(summonedMinion.handcard.card.cost==1 || summonedMinion.handcard.manacost ==1))
           {
               p.minionGetBuffed(summonedMinion,1,0);
               p.minionGetRush(summonedMinion);
           }
       }


    }
}