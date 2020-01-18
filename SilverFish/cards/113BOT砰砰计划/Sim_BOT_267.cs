using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{


class Sim_BOT_267:SimTemplate//载人毁灭机

{
	CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_125);//疯帽客
	
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
            {
                List<Handmanager.Handcard> temp = new List<Handmanager.Handcard>();
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.manacost <=2)
                    {
                        temp.Add(hc);
                    }
                }

                temp.Sort((x, y) => x.card.Attack.CompareTo(y.card.Attack));

                foreach (Handmanager.Handcard mnn in temp)
                {
                    p.callKid(mnn.card, p.ownMinions.Count, true, false);
                    p.removeCard(mnn);
                    break;
                }
            }
            else
            {
                if (p.enemyAnzCards >= 1)
                {
                    p.callKid(c, p.enemyMinions.Count, false, false);
                }
            }
		}



    
}
}

