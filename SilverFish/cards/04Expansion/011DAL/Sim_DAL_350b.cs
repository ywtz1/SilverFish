using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_350b : SimTemplate //* ����֮��
	{
        //�ָ�5������ֵ��

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			
			
				int heal = (ownplay) ? p.getSpellHeal (5) : p.getEnemySpellHeal (5);
				p.minionGetDamageOrHeal(target, -heal);
			



           
		}
	}
}