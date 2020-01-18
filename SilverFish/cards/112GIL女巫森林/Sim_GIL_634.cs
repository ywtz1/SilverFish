using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_GIL_634 : SimTemplate //* Mecharoo
{
//Deathrattle: Summon a 1/1 Jo-E Bot.


	CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_445t);
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                List<CardDB.cardIDEnum> secrets = new List<CardDB.cardIDEnum>();
                CardDB.Card c;
                foreach (KeyValuePair<CardDB.cardIDEnum, int> cid in p.prozis.turnDeck)
                {
                    c = CardDB.Instance.getCardDataFromID(cid.Key);
                    if (c.Secret&&p.restcard(cid.Key)>0) secrets.Add(cid.Key);
                }

                foreach (CardDB.cardIDEnum cId in secrets)
                {
                    if (p.ownSecretsIDList.Count < 5 && !p.ownSecretsIDList.Contains(cId)) 
                    {
                    	p.ownSecretsIDList.Add(cId);
                    	break;
                    }
                }
            }
            else
            {
                {
                    p.enemySecretCount++;
                    p.enemySecretList.Add(Probabilitymaker.Instance.getNewSecretGuessedItem(p.getNextEntity(), p.enemyHeroStartClass));
                }
            }
        }

	public override void onDeathrattle(Playfield p, Minion m)
	{
		if(m.own) 

            {
                List<CardDB.cardIDEnum> secrets = new List<CardDB.cardIDEnum>();
                CardDB.Card c;
                foreach (KeyValuePair<CardDB.cardIDEnum, int> cid in p.prozis.turnDeck)
                {
                    c = CardDB.Instance.getCardDataFromID(cid.Key);
                    if (c.Secret&&p.restcard(cid.Key)>0) secrets.Add(cid.Key);
                }

                foreach (CardDB.cardIDEnum cId in secrets)
                {
                    if (p.ownSecretsIDList.Count < 5 && !p.ownSecretsIDList.Contains(cId))
                    {
                    	p.ownSecretsIDList.Add(cId);
                    	break;
                    }
                }
            }
            else
            {
                
                {
                    p.enemySecretCount++;
                    p.enemySecretList.Add(Probabilitymaker.Instance.getNewSecretGuessedItem(p.getNextEntity(), p.enemyHeroStartClass));
                }
            }
		}
	}
}
