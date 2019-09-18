using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots

{
    /// <summary>
    /// Hooked Scimitar
    /// ¹³Á­Íäµ¶
    /// </summary>
    public class Sim_ULD_285 : SimTemplate
    {
        /// <summary>
        /// Combo: Gain +2 Attack.
        /// Á¬»÷£º»ñµÃ+2¹¥»÷Á¦¡£
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_285);
            p.equipWeapon(weapon, ownplay);
            if (ownplay)
            {
                if (p.cardsPlayedThisTurn >= 1)
                {
                    p.ownWeapon.Angr += 2;
                    p.minionGetBuffed(p.ownHero, 2, 0);
                }
            }
            else
            {
                if (p.cardsPlayedThisTurn >= 1)
                {
                    p.enemyWeapon.Angr += 2;
                    p.minionGetBuffed(p.enemyHero, 2, 0);
                }
            }
        }
    }
}