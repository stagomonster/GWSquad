using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GWSquad
{
    //public struct NameToID //Not used.
    //{
    //    public string Name;
    //    public int ID;
    //}
    public class BuildConstant
    {
        public static Dictionary<int, string> BuildConstantDictionary = new Dictionary<int, string>() //This is currently NOT USED.
                                                                                                      //It was intended for use in conjunction with Professions.cs and the below Dictionary
        {
            [0] = "Condition Firebrand",
            [1] = "Quickness Firebrand",
            [2] = "Heal Quickness Firebrand",
            [3] = "Power Dragonhunter",
            [4] = "Condition Soulbeast",
            [5] = "Handkite Soulbeast",
            [6] = "Heal Alacrity Druid",
            [7] = "Heal Alacrity Mechanist",
            [8] = "Power Alacity Mechanist",
            [9] = "Condition Mechanist",
            [10] = "Power Mechanist",
            [11] = "Power Quickness Scrapper",
            [12] = "Power Scrapper",

            [13] = "Heal Scourge",

            [14] = "Condition Scourge",
            [15] = "Power Reaper",
            [16] = "Condition Quickness Harbinger",
            [17] = "",

            [18] = "",
            [19] = "",
            [20] = "",
            [21] = "",
            [22] = "",
            [23] = "",
            [24] = "",
        };
        public static Dictionary<string, Build> constant = new Dictionary<string, Build>() //This is USED (in MainPage.xaml.cs) . Stores all the Preset Builds. More can be added in future. 
        {
            ["Condition Firebrand"] = new Build(0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, "Condition", "Damage", "Condition Firebrand", "Firebrand"),
            ["Quickness Firebrand"] = new Build(1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0, 0, "Condition", "Offensive Support", "Quickness Firebrand", "Firebrand"),
            ["Heal Quickness Firebrand"] = new Build(2, 1, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, "Power", "Support", "Heal Quickness Firebrand", "Firebrand"),
            ["Power Dragonhunter"] = new Build(3, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, "Power", "Damage", "Power Dragonhunter", "Dragonhunter"),

            ["Condition Soulbeast"] = new Build(4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, "Condition", "Damage", "Condition Soulbeast", "Soulbeast"),
            ["Handkite Soulbeast"] = new Build(5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Power", "Handkite", "Handkite Soulbeast", "Soulbeast"),
            ["Heal Alacrity Druid"] = new Build(6, 0, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, "Power", "Support", "Heal Alacrity Druid", "Druid"),

            ["Heal Alacrity Mechanist"] = new Build(7, 0, 1, 1, 1, 1, 0, 1, 0, 0, 1, 1, 1, "Power", "Support", "Heal Alacrity Mechanist", "Mechanist"),
            ["Power Alacity Mechanist"] = new Build(8, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, "Power", "Offensive Support", "Power Alacrity Mechanist", "Mechanist"),
            ["Condition Mechanist"] = new Build(9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Condition", "Damage", "Condition Mechanist", "Mechanist"),
            ["Power Mechanist"] = new Build(10, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, "Power", "Damage", "Power Mechanist", "Mechanist"),
            ["Power Quickness Scrapper"] = new Build(11, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, "Power", "Offensive Support", "Power Quickness Scrapper", "Scrapper"),
            ["Power Scrapper"] = new Build(12, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, "Power", "Damage", "Power Scrapper", "Scrapper"),

            ["Heal Scourge"] = new Build(13, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, "Power", "Support", "Heal Scourge", "Scourge"),
            ["Condition Scourge"] = new Build(14, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Condition", "Damage", "Condition Scourge", "Scourge"),
            ["Power Reaper"] = new Build(15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Power", "Damage", "Power Reaper", "Reaper"),
            ["Condition Quickness Harbinger"] = new Build(16, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, "Condition", "Offensive Support", "Condition Quickness Harbinger", "Harbinger"),


        };   
    }
}

