using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_TRL_542 : SimTemplate //  <Tag enumID="185" type="String">乌达斯塔</Tag>
  //<Tag enumID="184" type="String"><b>突袭</b><b>超杀：</b>从你的手牌中召唤一个野兽。</Tag>
{



	CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_099);//狂奔的魔暴龙
        public override void chaosha(Playfield p, Minion attacker, Minion target)
        {
            if (attacker.own)
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
