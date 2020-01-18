using HREngine.Bots;


namespace Silverfish.cards._04Expansion._012ULD
{
    /// <summary>
    /// Serpent Egg
    /// 海蛇蛋
    /// </summary>
    public class Sim_ULD_174 : SimTemplate
    {
        /// <summary>
        /// Deathrattle: Summon a 3/4 Sea Serpent.
        /// 亡语：召唤一条3/4的海蛇。
        /// </summary>
        /// <param name="p"></param>
        /// <param name="m"></param>
        public override void onDeathrattle(Playfield p, Minion m)
        {
            CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_174t);
            p.callKid(c, m.zonepos - 1, m.own);
        }
    }
}