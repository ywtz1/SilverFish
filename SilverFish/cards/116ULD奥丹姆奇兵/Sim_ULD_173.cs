namespace HREngine.Bots
{
	class Sim_ULD_173 : SimTemplate //* 维西纳 Vessina
	{
		//While you're <b>Overloaded</b>, your other minions have +2 Attack.
		//当你<b>过载</b>时，你的所有其他随从获得+2攻击力。
		public override void onAuraStarts(Playfield p, Minion m)
        {
            if (m.own)
            {
                if(p.ueberladung>0)p.allMinionOfASideGetBuffed(m.own,2,0);
            }
            else
            {
                if(p.ueberladung>0)p.allMinionOfASideGetBuffed(m.own,2,0);
            }
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own)
            {
                if(p.ueberladung>0)p.allMinionOfASideGetBuffed(m.own,-2,0);
            }
            else
            {
                if(p.ueberladung>0)p.allMinionOfASideGetBuffed(m.own,-2,0);
            }
        }


	}
}