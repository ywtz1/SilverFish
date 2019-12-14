using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_217  : SimTemplate
	{
				        CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_099t2t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
        	if(p.nqiqiu>1)
            {
            	kid1.Health+=3;
            	kid1.Attack+=3;
            }
            else p.evaluatePenality+=10;
        	int posi = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
            p.CallKid(kid1, posi, ownplay, false);
            p.CallKid(kid1, posi, ownplay, false);

        }
	}
}