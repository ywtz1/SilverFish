using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_568 : SimTemplate //莫瑞甘的灵界
	{

		

		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int sumofmana=0;
			foreach (Handmanager.Handcard hc in p.owncards)
			sumofmana+=hc.manacost;

			if(p.ownMaxMana-2<=p.mana&&p.mana >5 &&p.owncards.Count <3 && sumofmana< p.mana)
			{
			//p.evaluatePenality+=(5-p.mana+sumofmana)*3;
			p.drawACard (CardDB.cardName.unknown,ownplay,false,true);
			p.drawACard (CardDB.cardName.unknown,ownplay,false,true);
			p.drawACard (CardDB.cardName.unknown,ownplay,false,true);
			//p.evaluatePenality += (p.ownMaxMana-p.mana)*40;
			//cPos = p.owncards.Count;
			//p.lingjie=1;




			}


		}



	}
}