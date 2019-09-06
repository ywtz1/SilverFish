using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
    class Sim_GIL_190 : SimTemplate //* Nightscale Matriarch
    {
        //Whenever a friendly minion is healed, summon a 3/3 Whelp.
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_190t);

        public override void onAMinionGotHealedTrigger(Playfield p, Minion triggerEffectMinion, int minionsGotHealed)
        {
            for (int i = 0; i < minionsGotHealed; i++)
            {
                p.CallKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);
            }
        }
    }
}