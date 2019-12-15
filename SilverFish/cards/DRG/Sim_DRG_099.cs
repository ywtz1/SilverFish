using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_099  : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            
            if(p.ownHeroAblility.card.cardIDenum == CardDB.cardIDEnum.DRG_238p5||
            	p.ownHeroAblility.card.cardIDenum == CardDB.cardIDEnum.DRG_238p4||
            	p.ownHeroAblility.card.cardIDenum == CardDB.cardIDEnum.DRG_238p3||
            	p.ownHeroAblility.card.cardIDenum == CardDB.cardIDEnum.DRG_238p2||
            	p.ownHeroAblility.card.cardIDenum == CardDB.cardIDEnum.DRG_238p)
            {
            	if (choice == 4 )
                {
                    p.allMinionsGetDamage(5,own.entitiyID);
                }
                
                if (choice == 3 )
                {
                    p.allMinionOfASideGetBuffed(own.own,2,2);
                }
                if (choice == 2)
                {
                	int posi = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
                    p.CallKid(CardDB.cardIDEnum.DRG_099t2t, posi, own.own, false);
                }
                if (choice == 1 )
                {
                    p.minionGetDamageOrHeal(p.enemyHero, 5); 
                    p.minionGetDamageOrHeal(p.ownHero, -5);

                }
            }
            else if(own.own)
            {
                switch (p.ownHeroStartClass)
                {
                    case TAG_CLASS.MAGE:
                        
                        break;
                    case TAG_CLASS.HUNTER:
                       
                        break;
                    case TAG_CLASS.PRIEST:
                        p.drawACard(CardDB.cardIDEnum.DRG_660, own.own, false);
                        break;
                    case TAG_CLASS.SHAMAN:
                        p.drawACard(CardDB.cardName.galakrondthetempest, own.own, false);//620
                        break;
                    case TAG_CLASS.PALADIN:
                        
                        break;
                    case TAG_CLASS.DRUID:
                        
                        break;
                    case TAG_CLASS.WARLOCK:
                        p.drawACard(CardDB.cardIDEnum.DRG_600, own.own, false);
                        break;
                    case TAG_CLASS.WARRIOR:
                        p.drawACard(CardDB.cardIDEnum.DRG_650, own.own, false);
                        break;
                    case TAG_CLASS.ROGUE:
                        p.drawACard(CardDB.cardIDEnum.DRG_610, own.own, false);
                        break;
                }
            }
        }
   	}
}