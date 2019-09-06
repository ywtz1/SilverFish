using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_065: SimTemplate //* 祖尔金
    {
        // Battlecry: Summon all friendly Demons that died this game.

        CardDB cdb = CardDB.Instance;
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_077t);//Wolf
        CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_378t1);//双足飞龙
        CardDB.Card kid3 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_032);//misha

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            
            p.setNewHeroPower(CardDB.cardIDEnum.TRL_065h, ownplay); //
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;

            int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            if(ownplay)
            {

                foreach (KeyValuePair<CardDB.cardIDEnum, int> e in Probabilitymaker.Instance.ownCardsOut)
                {
                    kid = cdb.getCardDataFromID(e.Key);
                    
                    if (kid.type == CardDB.cardtype.SPELL&&kid.name != CardDB.cardName.zuljin)
                    {
                        
                        {

                            if (kid.Secret)
			                {
                    			if (p.ownSecretsIDList.Count < 5 && !p.ownSecretsIDList.Contains(kid.cardIDenum))
                     			p.ownSecretsIDList.Add(kid.cardIDenum);
 
			                }
                            else 
                            {
                                for(int i=0;i<e.Value;i++)
                                {
                                    kid.CardSimulation.onCardPlay(p,ownplay,(p.ownMinions.Count!=0||p.ownMinions.Count!=0)?(p.ownMinions.Count>=p.ownMinions.Count? p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack):p.searchRandomMinion(p.enemyMinions, searchmode.searchHighestAttack)):p.enemyHero,2);
                                }  
                            }

//(p.ownMinions.Count!=0||p.ownMinions.Count!=0)?(p.ownMinions.Count>=p.ownMinions.Count? p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack):p.searchRandomMinion(p.enemyMinions, searchmode.searchHighestAttack)):p.ownHero

                            /*
			                else if(kid.name == CardDB.cardName.猛兽出笼)
                            {
                                p.CallKid(kid2, pos, ownplay);
                                p.drawACard(CardDB.cardName.unknown, ownplay, true);
                                if(e.Value>1)p.CallKid(kid2, pos, ownplay);
                            }
                            else if(kid.name == CardDB.cardName.animalcompanion)
                            {
                                if(e.Value>1)p.CallKid(kid3, pos, ownplay);
                                p.CallKid(kid3, pos, ownplay);
                            }
                            else if(kid.name == CardDB.cardName.主人的召唤)
                            {
                                p.drawACard(CardDB.cardName.unknown, ownplay, true);
                                if(e.Value>1)
                                {
                                    p.drawACard(CardDB.cardName.unknown, ownplay, true);
                                }
                            }
                            else if(kid.name == CardDB.cardName.标记射击)
                            {
                                p.drawACard(CardDB.cardName.unknown, ownplay, true);
                                if(e.Value>1)
                                {
                                    p.drawACard(CardDB.cardName.unknown, ownplay, true);
                                }
                            }
                            else if(kid.name == CardDB.cardName.deadlyshot)//致命射击
                            {
                                Minion m = p.searchRandomMinion(ownplay ? p.enemyMinions : p.ownMinions, searchmode.searchLowestHP);
                                if (m != null) p.minionGetDestroyed(m);
                                if(e.Value>1)
                                {
                                    m = p.searchRandomMinion(ownplay ? p.enemyMinions : p.ownMinions, searchmode.searchLowestHP);
                                    if (m != null) p.minionGetDestroyed(m);
                                }
                            }*/
                        }

                    }
                }
            }

        }
    }
}