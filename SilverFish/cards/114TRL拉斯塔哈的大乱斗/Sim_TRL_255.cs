using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_255 : SimTemplate //* 狂奔怒吼
	{
        

    CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_099);//狂奔的魔暴龙

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            Handmanager.Handcard hcc=null;

            if (ownplay)
            {
                List<Handmanager.Handcard> temp = new List<Handmanager.Handcard>();
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if ((TAG_RACE)hc.card.race == TAG_RACE.PET)
                    {
                        temp.Add(hc);
                    }
                }

                temp.Sort((x, y) => x.card.Attack.CompareTo(y.card.Attack));

                foreach (Handmanager.Handcard mnn in temp)
                {
                    p.callKid(mnn.card, p.ownMinions.Count, true, false);
                    hcc=mnn;
                    p.removeCard(mnn);
                    break;
                }
                foreach (Minion m in p.ownMinions)
                {
                    if(m.handcard.card ==hcc.card)
                    {
                        p.minionGetRush(m);
                        break;
                    }
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