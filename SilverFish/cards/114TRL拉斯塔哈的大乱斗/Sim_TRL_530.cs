using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_530 : SimTemplate //蒙面选手
	//如果你拥有一个奥秘从牌库中将一个奥秘自如战场
	{
		CardDB.Card c = null; 
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int num = (own.own) ? p.ownSecretsIDList.Count : p.enemySecretCount;
			if (num > 0)
			{
				
				foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.prozis.turnDeck)
                {
                    c = CardDB.Instance.getCardDataFromID(cn.Key);

                    if (c.Secret == true)
                    {
                    p.evaluatePenality -=20;
                    //p.ownMinions[pos].Attack = 1;
                    //p.ownMinions[pos].Hp = 1;
                    //p.ownMinions[pos].maxHp = 1;
                    //pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                    }
                }
			}
		}
	}
}