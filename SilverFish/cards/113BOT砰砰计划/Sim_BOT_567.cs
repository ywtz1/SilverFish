using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_567: SimTemplate //克隆展
    {

        CardDB.Card c;
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_156a); //Ooze with Taunt
        CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_298); //大螺丝

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {

            {
                


                int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                //CardDB.Card kid = CardDB.Instance.getCardDataFromID((p.OwnLastDiedMinion == CardDB.cardIDEnum.None) ? CardDB.cardIDEnum.EX1_345t : p.OwnLastDiedMinion); // Shadow of Nothing 0:1 or ownMinion
                p.callKid(kid, pos++, ownplay, false);
                
                foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.prozis.turnDeck)
                {
                    c = CardDB.Instance.getCardDataFromID(cn.Key);

                    if (c.type == CardDB.cardtype.MOB)
                    {
	                    p.callKid(c, pos++, ownplay, false);
	                    
	                    foreach( Minion m in p.ownMinions)
		                {
		                    if(m.handcard.card==c)
		                    {m.Attack = 1;m.Hp = 1;m.maxHp = 1;break;}
		                }
		                if(pos>7)break;
	                    //p.ownMinions[pos].Attack = 1;
	                    //p.ownMinions[pos].Hp = 1;
	                    //p.ownMinions[pos].maxHp = 1;
	                    //pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                    }
                }

/*
                if(p.numberofOwnDiedMinion <= 4&&p.prozis.getDeckCardsForCost(8) !== CardDB.cardIDEnum.None)
                {
                    p.callKid(kid, pos, ownplay, false);
                    p.ownMinions[pos].Attack = 1;
                    p.ownMinions[pos].Hp = 1;
                    p.ownMinions[pos++].maxHp = 1;
                }
                if(p.prozis.getDeckCardsForCost(9) !== CardDB.cardIDEnum.None)
                {
                    p.callKid(kid, pos, ownplay, false);
                    p.ownMinions[pos].Attack = 1;
                    p.ownMinions[pos].Hp = 1;
                    p.ownMinions[pos++].maxHp = 1;
                }
                if(p.prozis.getDeckCardsForCost(10) !== CardDB.cardIDEnum.None)
                {
                    p.callKid(kid, pos, ownplay, false);
                    p.ownMinions[pos].Attack = 1;
                    p.ownMinions[pos].Hp = 1;
                    p.ownMinions[pos++].maxHp = 1;
                }
*/
                
            }
        }
    }
}