﻿using System;
using System.IO;
using HREngine.Bots;

namespace Silverfish.Helpers
{
    public class LogHelper
    {
        private static string MainLogFolder = @"Logs\ChuckSilverfishAi";

        private static string CombatLogFolder = "CombatLogs";

        private static string MainLogFileName ;
		private static string _CombatLogFileName = "Combat.log";

        private static void AppendText(object obj, string fileName, string subfolder = "")
        {
            var folder = Path.Combine(Settings.Instance.BaseDirectory, MainLogFolder);
            if (!string.IsNullOrWhiteSpace(subfolder))
            {
                folder = Path.Combine(folder, subfolder);
            }

            var filePath = Path.Combine(folder, fileName);
            if (!File.Exists(filePath))
            {
                FileHelper.CreateEmptyFile(filePath);
            }

            AppendText(filePath, obj);
        }

        private static void AppendText(string filePath, object obj)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {if(obj!=null)
                sw.WriteLine(obj.ToString());
            }
        }

        private static void WriteAllText(string filePath, object obj)
        {if(obj!=null)
            File.WriteAllText(filePath, obj.ToString());
        }

        private static void WriteAllText(object obj, string fileName, string subfolder)
        {
            var folder = Path.Combine(Settings.Instance.BaseDirectory, MainLogFolder);
            if (!string.IsNullOrWhiteSpace(subfolder))
            {
                folder = Path.Combine(folder, subfolder);
            }

            var filePath = Path.Combine(folder, fileName);
            if (!File.Exists(filePath))
            {
                FileHelper.CreateEmptyFile(filePath);
            }

            WriteAllText(filePath, obj);
        }

        public static void WriteNotImplementedsim_cardLog(string content)
        {
            WriteAllText(content, "CardNotImplemented-{DateTime.Now:yyyyMMdd}.csv", string.Empty);
        }

        public static string CombatLogFileName
		   {
		   get { return _CombatLogFileName; }
		   set {  _CombatLogFileName=value; }
		   }



        public static void WriteCombatLog(object obj)
        {
            AppendText(obj, CombatLogFileName, CombatLogFolder);
        }

        public static void WriteMainLog(object obj)
        {
            MainLogFileName = "ChuckSilverfishAi-{DateTime.Now:yyyyMMdd}.log";
            AppendText(obj, MainLogFileName);
        }

        public static string GetCombatLogFilePath()
        {
            var combatLogFilePath = Path.Combine(Settings.Instance.BaseDirectory, CombatLogFolder, CombatLogFileName);
            return combatLogFilePath;
        }
    }
}
