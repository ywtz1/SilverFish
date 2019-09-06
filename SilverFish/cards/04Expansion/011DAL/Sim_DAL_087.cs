using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_087: SimTemplate //* ����������
    {
        // ս���ٻ�����1/1���ںϹ֡�

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_087t); //1/1 �ںϹ�

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.CallKid(kid, own.zonepos - 1, own.own); //1st left
            p.CallKid(kid, own.zonepos, own.own);
        }
    }
}