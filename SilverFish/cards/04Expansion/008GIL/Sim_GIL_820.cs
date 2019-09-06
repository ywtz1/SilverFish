using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{

    public class Sim_GIL_820 : SimTemplate //É³µÂÎÖ¿Ë
    {
        CardDB cdb = CardDB.Instance;
        CardDB.Card c = null;
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                int pen=0;
                foreach (KeyValuePair<CardDB.cardIDEnum, int> e in Probabilitymaker.Instance.ownCardsOut)
                {
                    c = cdb.getCardDataFromID(e.Key);
                    if(c.battlecry)pen+=10;
                    if(e.Value>1)pen+=5*(e.Value-1);

                }
                p.evaluatePenality-=pen;

            }
        }
    }

}