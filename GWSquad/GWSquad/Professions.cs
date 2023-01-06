using System;
using System.Collections.Generic;
using System.Text;

namespace GWSquad
{
    public class Professions
    {
        public static Dictionary<string, Profession> ClassList = new Dictionary<string, Profession>()
            {
                {"Warrior", new Profession("Warrior", "https://wiki.guildwars2.com/images/c/c8/Warrior_icon.png") },
                {"Thief", new Profession("Thief", "https://wiki.guildwars2.com/images/d/d8/Thief_icon.png") },
                {"Ranger", new Profession("Ranger", "https://wiki.guildwars2.com/images/9/9c/Ranger_icon.png")},
                {"Necromancer", new Profession("Necromancer", "https://wiki.guildwars2.com/images/6/62/Necromancer_icon.png") },
                {"Mesmer", new Profession("Mesmer", "https://wiki.guildwars2.com/images/3/3a/Mesmer_icon.png") },
                {"Revenant", new Profession("Revenant", "https://wiki.guildwars2.com/images/8/89/Revenant_icon.png") },
                {"Engineer", new Profession("Engineer", "https://wiki.guildwars2.com/images/4/41/Engineer_icon.png") },
                {"Elementalist", new Profession("Elementalist", "https://wiki.guildwars2.com/images/a/a2/Elementalist_icon.png") },
                {"Guardian", new Profession("Guardian", "https://wiki.guildwars2.com/images/c/cc/Guardian_icon.png") },

                {"Berserker", new Profession("Berserker", "https://wiki.guildwars2.com/images/thumb/6/60/Berserker_icon_%28highres%29.png/180px-Berserker_icon_%28highres%29.png") },
                {"Daredevil", new Profession("Daredevil", "https://wiki.guildwars2.com/images/thumb/1/13/Daredevil_icon_%28highres%29.png/180px-Daredevil_icon_%28highres%29.png") },
                {"Druid", new Profession("Druid", "https://wiki.guildwars2.com/images/thumb/9/96/Druid_icon_%28highres%29.png/180px-Druid_icon_%28highres%29.png") },
                {"Reaper", new Profession("Reaper", "https://wiki.guildwars2.com/images/thumb/0/0c/Reaper_icon_%28highres%29.png/180px-Reaper_icon_%28highres%29.png") },
                {"Chronomancer", new Profession("Chronomancer", "https://wiki.guildwars2.com/images/thumb/7/79/Chronomancer_icon_%28highres%29.png/180px-Chronomancer_icon_%28highres%29.png") },
                {"Herald", new Profession("Herald", "https://wiki.guildwars2.com/images/thumb/6/63/Herald_icon_%28highres%29.png/180px-Herald_icon_%28highres%29.png") },
                {"Scrapper", new Profession("Scrapper", "https://wiki.guildwars2.com/images/thumb/f/fd/Scrapper_icon_%28highres%29.png/180px-Scrapper_icon_%28highres%29.png") },
                {"Tempest", new Profession("Tempest", "https://wiki.guildwars2.com/images/thumb/4/4d/Tempest_icon_%28highres%29.png/180px-Tempest_icon_%28highres%29.png") },
                {"Dragonhunter", new Profession("Dragonhunter", "https://wiki.guildwars2.com/images/thumb/3/33/Dragonhunter_icon_%28highres%29.png/180px-Dragonhunter_icon_%28highres%29.png") },

                {"Spellbreaker", new Profession("Spellbreaker", "placeholder") },
                {"Deadeye", new Profession("Deadeye", "placeholder") },
                {"Soulbeast", new Profession("Soulbeast", "placeholder") },
                {"Scourge", new Profession("Scourge", "placeholder") },
                {"Mirage", new Profession("Mirage", "placeholder") },
                {"Renegade", new Profession("Renegade", "placeholder") },
                {"Holosmith", new Profession("Holosmith", "placeholder") },
                {"Weaver", new Profession("Weaver", "placeholder") },
                {"Firebrand", new Profession("Firebrand", "placeholder") },

                {"Bladesworn", new Profession("Firebrand", "placeholder") },
                {"Specter", new Profession("Specter", "placeholder") },
                {"Untamed", new Profession("Untamed", "placeholder") },
                {"Harbinger", new Profession("Harbinger", "placeholder") },
                {"Virtuoso", new Profession("Virtuoso", "placeholder") },
                {"Vindicator", new Profession("Vindicator", "placeholder") },
                {"Mechanist", new Profession("Mechanist", "placeholder") },
                {"Catalyst", new Profession("Catalyst", "placeholder") },
                {"Willbender", new Profession("Willbender", "placeholder") },



            };
        public Professions()
        {
            //ClassList = new Dictionary<string, Profession>()
            //{
            //    { "Warrior", new Profession("Warrior", "placeholder") },
            //    {"Thief", new Profession("Thief", "placeholder") },
            //    { "Ranger", new Profession("Ranger", "placeholder")},
            //    {"Necromancer", new Profession("Necromancer", "placeholder") },
            //    {"Mesmer", new Profession("Mesmer", "placeholder") },
            //    {"Revenant", new Profession("Revenant", "placeholder") },
            //    {"Engineer", new Profession("Engineer", "placeholder") },
            //    {"Elementalist", new Profession("Elementalist", "placeholder") },
            //    {"Guardian", new Profession("Guardian", "placeholder") }

            //};
        }
    }
}
