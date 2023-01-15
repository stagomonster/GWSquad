using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GWSquad
{
    public struct NameToID
    {
        public string Name;
        public int ID;
    }
    public class BuildConstant
    {
        public static Dictionary<int, string> BuildConstantDictionary = new Dictionary<int, string>()
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
        public static Dictionary<string, Build> constant = new Dictionary<string, Build>()
        {
            ["Condition Firebrand"] = new Build(0, true, false, true, false, true, false, false, false, false, true, false, false, "Condition", "Damage", "Condition Firebrand", "Firebrand"),
            ["Quickness Firebrand"] = new Build(1,true, false, true, false, true, true, false, false, false, true, false, false, "Condition", "Offensive Support", "Quickness Firebrand", "Firebrand"),
            ["Heal Quickness Firebrand"] = new Build(2,true, false, true, true, true, true, true, false, false, true, true, false, "Power", "Support", "Heal Quickness Firebrand", "Firebrand"),
            ["Power Dragonhunter"] = new Build(3,true, false, false, false, false, false, false, false, false, true, false, false, "Power", "Damage", "Power Dragonhunter", "Dragonhunter"),
            
            ["Condition Soulbeast"] = new Build(4,false,false,false,false,false,false,false,false,false,true,false,false,"Condition", "Damage", "Condition Soulbeast", "Soulbeast"),
            ["Handkite Soulbeast"] = new Build(5,false,false,false,false,false,false,false,false,false,false,false,false,"Power", "Handkite", "Handkite Soulbeast", "Soulbeast"),
            ["Heal Alacrity Druid"] = new Build(6,false,true,true,true,true,false,true,false,false,false,true,false,"Power", "Support", "Heal Alacrity Druid", "Druid"),
            
            ["Heal Alacrity Mechanist"] = new Build(7,false,true,true,true,true,false,true,false,false,true,true,true,"Power", "Support", "Heal Alacrity Mechanist", "Mechanist"),
            ["Power Alacity Mechanist"] = new Build(8,false,true,true,true,false,false,false,false,false,true,false,false,"Power", "Offensive Support", "Power Alacrity Mechanist", "Mechanist"),
            ["Condition Mechanist"] = new Build(9,false,false,false,false,false,false,false,false,false,false,false,false,"Condition", "Damage", "Condition Mechanist", "Mechanist"),
            ["Power Mechanist"] = new Build(10,false,false,true,true,false,false,false,false,false,false,false,false,"Power", "Damage", "Power Mechanist", "Mechanist"),
            ["Power Quickness Scrapper"] = new Build(11,false,false,false,false,false,true,false,false,false,false,false,false,"Power", "Offensive Support", "Power Quickness Scrapper", "Scrapper"),
            ["Power Scrapper"] = new Build(12,false,false,true,false,true,false,false,false,false,false,false,false, "Power", "Damage", "Power Scrapper", "Scrapper"),

            ["Heal Scourge"] = new Build(13,false,false,false,false,false,false,true,false,false,false,false,false,"Power", "Support", "Heal Scourge", "Scourge"),
            ["Condition Scourge"] = new Build(14,false,false,false,false,false,false,false,false,false,false,false,false,"Condition", "Damage", "Condition Scourge", "Scourge"),
            ["Power Reaper"] = new Build(15,false,false,false,false,false,false,false,false,false,false,false,false,"Power", "Damage", "Power Reaper", "Reaper"),
            ["Condition Quickness Harbinger"] = new Build(16,false,false,true,true,false,true,false,false,false,false,true,false, "Condition", "Offensive Support", "Condition Quickness Harbinger", "Harbinger"),


        };   
    }
}

