using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Mirage Blade
    /// ����֮��
    /// </summary>
    public class Sim_ULD_326t : SimTemplate
    {
        /// <summary>
        /// Your hero is Immune while attacking.
        /// ���Ӣ���ڹ���ʱ�������ߡ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_326t);
            p.equipWeapon(weapon, ownplay);
        }
    }
}