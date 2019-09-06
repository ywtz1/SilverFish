using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_238: SimTemplate //* Bloodreaver Gul'dan
    {
        // Battlecry: Summon all friendly Demons that died this game.

        CardDB cdb = CardDB.Instance;
        CardDB.Card kid = null;

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            
            p.setNewHeroPower(CardDB.cardIDEnum.BOT_238p1, ownplay); 
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;
            if(ownplay)p.penpen=true;
            



        }
    }
}