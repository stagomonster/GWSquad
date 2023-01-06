using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GWSquad
{
    public class BuildConstant
    {
        public static Dictionary<string, Build> constant = new Dictionary<string, Build>()
        {
            ["Condition Firebrand"] = new Build(true, false, true, false, true, false, false, false, false, true, false, false, "Condition", "Damage", "Condition Firebrand", "Firebrand"),
            ["Quickness Firebrand"] = new Build(true, false, true, false, true, true, false, false, false, true, false, false, "Condition", "Offensive Support", "Quickness Firebrand", "Firebrand"),
            ["Heal Quickness Firebrand"] = new Build(true, false, true, true, true, true, true, false, false, true, true, false, "Power", "Support", "Heal Quickness Firebrand", "Firebrand"),
            ["Power Dragonhunter"] = new Build(true, false, false, false, false, false, false, false, false, true, false, false, "Power", "Damage", "Power Dragonhunter", "Dragonhunter"),
            
            ["Condition Soulbeast"] = new Build(false,false,false,false,false,false,false,false,false,true,false,false,"Condition", "Damage", "Condition Soulbeast", "Soulbeast"),
            ["Handkite Soulbeast"] = new Build(false,false,false,false,false,false,false,false,false,false,false,false,"Power", "Handkite", "Handkite Soulbeast", "Soulbeast"),
            ["Heal Alacrity Druid"] = new Build(false,true,true,true,true,false,true,false,false,false,true,false,"Power", "Support", "Heal Alacrity Druid", "Druid"),
            
            ["Heal Alacrity Mechanist"] = new Build(false,true,true,true,true,false,true,false,false,true,true,true,"Power", "Support", "Heal Alacrity Mechanist", "Mechanist"),
            ["Power Alacity Mechanist"] = new Build(false,true,true,true,false,false,false,false,false,true,false,false,"Power", "Offensive Support", "Power Alacrity Mechanist", "Mechanist"),
            ["Condition Mechanist"] = new Build(false,false,false,false,false,false,false,false,false,false,false,false,"Condition", "Damage", "Condition Mechanist", "Mechanist"),
            ["Power Mechanist"] = new Build(false,false,true,true,false,false,false,false,false,false,false,false,"Power", "Damage", "Power Mechanist", "Mechanist"),
            ["Power Quickness Scrapper"] = new Build(false,false,false,false,false,true,false,false,false,false,false,false,"Power", "Offensive Support", "Power Quickness Scrapper", "Scrapper"),
            ["Power Scrapper"] = new Build(false,false,true,false,true,false,false,false,false,false,false,false, "Power", "Damage", "Power Scrapper", "Scrapper"),

            ["Heal Scourge"] = new Build(false,false,false,false,false,false,true,false,false,false,false,false,"Power", "Support", "Heal Scourge", "Scourge"),
            ["Condition Scourge"] = new Build(false,false,false,false,false,false,false,false,false,false,false,false,"Condition", "Damage", "Condition Scourge", "Scourge"),
            ["Power Reaper"] = new Build(false,false,false,false,false,false,false,false,false,false,false,false,"Power", "Damage", "Power Reaper", "Reaper"),
            ["Condition Quickness Harbinger"] = new Build(false,false,true,true,false,true,false,false,false,false,true,false, "Condition", "Offensive Support", "Condition Quickness Harbinger", "Harbinger"),


        };   
    }
}

