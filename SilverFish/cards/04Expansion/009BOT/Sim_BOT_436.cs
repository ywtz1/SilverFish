using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_436 : SimTemplate //* Flame Lance
	{
		//Deal 8 damage to a minion.
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

            p.drawACard (CardDB.cardName.unknown,ownplay,false);
            //Dictionary<CardDB.cardIDEnum, int> deck =p.Decknow();
            int spellc=0;
            int mobc=0;
            CardDB.Card c =null;


            foreach (KeyValuePair<CardDB.cardIDEnum, int> cid in p.Decknow())
            {
            	c = CardDB.Instance.getCardDataFromID(cid.Key);
                    if(c.type == CardDB.cardtype.MOB)mobc++;
                    else if(c.type == CardDB.cardtype.SPELL)spellc++;
                if (cid.Key==CardDB.cardIDEnum.ULD_304)
                {
                	p.evaluatePenality -=50;
                	p.drawACard (CardDB.cardName.unknown,ownplay,false);
                	break;
                }
            }
            if(mobc>0&&spellc>0)p.drawACard (CardDB.cardName.unknown,ownplay,false);

            //p.drawACard (CardDB.cardName.unknown,ownplay,false);
		}
	}
}