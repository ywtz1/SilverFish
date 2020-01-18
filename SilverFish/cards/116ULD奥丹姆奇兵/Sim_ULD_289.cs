using System.Linq;

namespace HREngine.Bots
{
    /// <summary>
    /// Fishflinger
    /// 鱼人投手
    /// </summary>
    public class Sim_ULD_289 : SimTemplate
    {

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard (CardDB.cardIDEnum.CFM_310t,own.own,true);
            p.drawACard (CardDB.cardIDEnum.CFM_310t,!own.own,true);



        }
    }
}

