using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_024  : SimTemplate
	{
				        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_025);

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            
            {
                p.drawACard(CardDB.cardName.unknown, own.own, false);

            }
        }
	}
}