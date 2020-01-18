using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// EVIL Miscreant
    /// ¹ÖµÁ¶ñ°Ô
    /// </summary>
    class Sim_DAL_415 : SimTemplate
    {
        /// <summary>
        /// Combo: Add two random Lackeys to your hand.
        /// Á¬»÷£ºËæ»ú½«Á½ÕÅ¸ú°àÅÆÖÃÈëÄãµÄÊÖÅÆ¡£
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (p.cardsPlayedThisTurn >= 1)
            {
                var count = 2;
                for (var i = 1; i <= count; i++)
                {

                    p.drawACard(CardDB.cardIDEnum.DAL_615, own.own, true);
                }
            }
        }
	}
}