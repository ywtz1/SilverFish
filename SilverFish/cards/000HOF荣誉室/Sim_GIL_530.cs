using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{

    public class Sim_GIL_530 : SimTemplate //��ȼ����
    {
        //<b>ս��</b>�������ƿ���ֻ�з���ֵ����Ϊż�����ƣ����2���˺���
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target == null)
            {
                Triton.Common.LogUtilities.Logger.GetLoggerInstanceForType()
                    .ErrorFormat("[target is null in Sim_GIL_530 getBattlecryEffect]");
            }

            int dmg = 2;
            p.minionGetDamageOrHeal(target, dmg);
        }
    }

}