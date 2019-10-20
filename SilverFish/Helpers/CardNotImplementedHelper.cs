﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HREngine.Bots;

namespace SilverFish.Helpers
{
    public class NotImplementedInfo
    {
		private CardDB.Card _Card;
		private int _Counter;
        public CardDB.Card Card 
		{
            get { return _Card; }
			set {_Card=value;}
        }

        public int Counter
		{
            get { return _Counter; }
			set {_Counter=value;}
        }
    }

    public class CardNotImplementedHelper
    {
        private static readonly ConcurrentDictionary<CardDB.cardIDEnum, NotImplementedInfo> NotImplementedCards =
            new ConcurrentDictionary<CardDB.cardIDEnum, NotImplementedInfo>();

        private static readonly Dictionary<CardDB.cardIDEnum, CardDB.Card> SingleGameCards =
            new Dictionary<CardDB.cardIDEnum, CardDB.Card>();

        public static void Add(CardDB.Card card)
        {
            var key = card.cardIDenum;
            if (!SingleGameCards.ContainsKey(key))
            {
                SingleGameCards.Add(key, card);
            }
        }

        public static void GameOver(object state)
        {
            var list = SingleGameCards.ToList();
            SingleGameCards.Clear();
            foreach (var item in list)
            {
                AddToSummary(item.Value);
            }
        }

        private static void AddToSummary(CardDB.Card card)
        {
            var key = card.cardIDenum;
            NotImplementedInfo info;

            if (NotImplementedCards.ContainsKey(key))
            {
                info = NotImplementedCards[key];
            }
            else
            {
                info = new NotImplementedInfo { Card = card };
            }
            info.Counter++;

            NotImplementedCards.AddOrUpdate(key, info, (k, v) => v);
        }

        public static void Save()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (NotImplementedCards.Count == 0)
            {
                if (SingleGameCards.Count == 0)
                {
                    Helpfunctions.Instance.ErrorLog("Didn't find cards that not implemented when stop bot.");
                }
                else
                {
                    stringBuilder.AppendLine("CardId,CardName");
                    var array1 = SingleGameCards.Values.Select(x => "{x.cardIDenum},{x.name}");
                    var result1 = string.Join(Environment.NewLine, array1);
                    stringBuilder.AppendLine(result1);
                    LogHelper.WriteNotImplementedCardSimulationLog(stringBuilder.ToString());
                }

                return;
            }

            stringBuilder.AppendLine("CardId,CardName,Count");
            var list = NotImplementedCards.Values.OrderByDescending(x => x.Counter);
            var array = list.Select(x => "{x.Card.cardIDenum},{x.Card.name},{x.Counter}");
            var result = string.Join(Environment.NewLine, array);
            stringBuilder.AppendLine(result);
            LogHelper.WriteNotImplementedCardSimulationLog(stringBuilder.ToString());
        }

    }
}
