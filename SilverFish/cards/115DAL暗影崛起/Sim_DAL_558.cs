using System;
using System.Collections.Generic;
using System.Text;
using Silverfish.Helpers;
namespace HREngine.Bots
{
    class Sim_DAL_558 : SimTemplate //* 大法师瓦格斯
	{
        CardDB.Card spell = null; 
        int n =0;

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {

  
            if (m.own && ownplay)
            {
                //if(spell!=null)Helpfunctions.Instance.ErrorLog("大法师瓦格斯 spell onCardIsGoingToBePlayed："+spell.name);
                if(hc.card.type == CardDB.cardtype.SPELL)
                {
                    spell = hc.card;
                    n++;
                }

            }
        

        }
        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner&&turnStartOfOwner)
            {
                //if(spell!=null)Helpfunctions.Instance.ErrorLog("大法师瓦格斯spell onTurnStartTrigger："+spell.name);
                spell = null; 
                n =0;
            }
        }
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            //n=p.cardsPlayedThisTurn-p.mobsplayedThisTurn;//英雄牌无法计算
            //spell= p.SpellLastPlayed;

            if (triggerEffectMinion.own == turnEndOfOwner&&turnEndOfOwner && n>0 && spell !=null&&spell.name!=CardDB.cardName.unknown)
            {
                //if(spell!=null)Helpfunctions.Instance.ErrorLog("大法师瓦格斯spellonTurnEndsTrigger ："+spell.name);
                if(n>1)p.evaluatePenality += 20;
                spell.sim_card.onCardPlay(p,turnEndOfOwner,(p.ownMinions.Count!=0||p.ownMinions.Count!=0)?(p.ownMinions.Count>=p.ownMinions.Count? p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack):p.searchRandomMinion(p.enemyMinions, searchmode.searchHighestAttack)):p.enemyHero,0);
            }
        }

	}
}