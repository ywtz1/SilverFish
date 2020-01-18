using HREngine.Bots;

namespace Silverfish.cards._04Expansion._008GIL
{
    /// <summary>
    /// Fiendish Circle
    /// 恶魔法阵
    /// </summary>
    public class Sim_GIL_191 : SimTemplate
    {
        /// <summary>
        /// Summon four 1/1 Imps.
        /// 召唤四个1/1的小鬼。
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_191t);
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
            p.callKid(kid, pos, ownplay);
            p.callKid(kid, pos, ownplay);
        }
    }
}
