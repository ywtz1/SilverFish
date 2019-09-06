using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_573 : SimTemplate //实验体9号</Tag>
  //<Tag enumID="184" type="String"><b>战吼：</b>从你的牌库中抽五张不同的<b>奥秘</b>牌。

	{
		CardDB.Card c = null; 
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			//int num = (own.own) ? p.ownSecretsIDList.Count : p.enemySecretCount;
			int i=0;
			if (own.own)
			{
				
				foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.prozis.turnDeck)
                {
                    c = CardDB.Instance.getCardDataFromID(cn.Key);

                    if (c.Secret == true&&p.restcard(cn.Key)>0)
                    {
                    p.drawACard(c.name, own.own);
                    i++;
                    if(i==4)break;
                    //p.ownMinions[pos].Attack = 1;
                    //p.ownMinions[pos].HealthPoints = 1;
                    //p.ownMinions[pos].maxHp = 1;
                    //pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                    }
                }
			}
		}
	}
}