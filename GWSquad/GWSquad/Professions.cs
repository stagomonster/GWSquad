using System;
using System.Collections.Generic;
using System.Text;

namespace GWSquad
{
    public class Professions //NOT USED. Intended for usage in for displaying Icons, potentially in future.
    {
        public static Dictionary<string, Profession> ClassList = new Dictionary<string, Profession>()
            {
                //{"Warrior", new Profession("Warrior", "https://wiki.guildwars2.com/images/c/c8/Warrior_icon.png") },
                //{"Thief", new Profession("Thief", "https://wiki.guildwars2.com/images/d/d8/Thief_icon.png") },
                //{"Ranger", new Profession("Ranger", "https://wiki.guildwars2.com/images/9/9c/Ranger_icon.png")},
                //{"Necromancer", new Profession("Necromancer", "https://wiki.guildwars2.com/images/6/62/Necromancer_icon.png") },
                //{"Mesmer", new Profession("Mesmer", "https://wiki.guildwars2.com/images/3/3a/Mesmer_icon.png") },
                //{"Revenant", new Profession("Revenant", "https://wiki.guildwars2.com/images/8/89/Revenant_icon.png") },
                //{"Engineer", new Profession("Engineer", "https://wiki.guildwars2.com/images/4/41/Engineer_icon.png") },
                //{"Elementalist", new Profession("Elementalist", "https://wiki.guildwars2.com/images/a/a2/Elementalist_icon.png") },
                //{"Guardian", new Profession("Guardian", "https://wiki.guildwars2.com/images/c/cc/Guardian_icon.png") },

                //{"Berserker", new Profession("Berserker", "https://wiki.guildwars2.com/images/thumb/6/60/Berserker_icon_%28highres%29.png/180px-Berserker_icon_%28highres%29.png") },
                //{"Daredevil", new Profession("Daredevil", "https://wiki.guildwars2.com/images/thumb/1/13/Daredevil_icon_%28highres%29.png/180px-Daredevil_icon_%28highres%29.png") },
                //{"Druid", new Profession("Druid", "https://wiki.guildwars2.com/images/thumb/9/96/Druid_icon_%28highres%29.png/180px-Druid_icon_%28highres%29.png") },
                //{"Reaper", new Profession("Reaper", "https://wiki.guildwars2.com/images/thumb/0/0c/Reaper_icon_%28highres%29.png/180px-Reaper_icon_%28highres%29.png") },
                //{"Chronomancer", new Profession("Chronomancer", "https://wiki.guildwars2.com/images/thumb/7/79/Chronomancer_icon_%28highres%29.png/180px-Chronomancer_icon_%28highres%29.png") },
                //{"Herald", new Profession("Herald", "https://wiki.guildwars2.com/images/thumb/6/63/Herald_icon_%28highres%29.png/180px-Herald_icon_%28highres%29.png") },
                //{"Scrapper", new Profession("Scrapper", "https://wiki.guildwars2.com/images/thumb/f/fd/Scrapper_icon_%28highres%29.png/180px-Scrapper_icon_%28highres%29.png") },
                //{"Tempest", new Profession("Tempest", "https://wiki.guildwars2.com/images/thumb/4/4d/Tempest_icon_%28highres%29.png/180px-Tempest_icon_%28highres%29.png") },
                //{"Dragonhunter", new Profession("Dragonhunter", "https://wiki.guildwars2.com/images/thumb/3/33/Dragonhunter_icon_%28highres%29.png/180px-Dragonhunter_icon_%28highres%29.png") },

                {"Warrior", new Profession("Warrior", "https://wiki.guildwars2.com/images/0/02/Warrior_%28overhead_icon%29.png") },
                {"Thief", new Profession("Thief", "https://wiki.guildwars2.com/images/6/6d/Thief_%28overhead_icon%29.png") },
                {"Ranger", new Profession("Ranger", "https://wiki.guildwars2.com/images/4/47/Ranger_%28overhead_icon%29.png")},
                {"Necromancer", new Profession("Necromancer", "https://wiki.guildwars2.com/images/a/a9/Necromancer_%28overhead_icon%29.png") },
                {"Mesmer", new Profession("Mesmer", "https://wiki.guildwars2.com/images/6/6c/Mesmer_%28overhead_icon%29.png") },
                {"Revenant", new Profession("Revenant", "https://wiki.guildwars2.com/images/f/f0/Revenant_%28overhead_icon%29.png") },
                {"Engineer", new Profession("Engineer", "https://wiki.guildwars2.com/images/e/e3/Engineer_%28overhead_icon%29.png") },
                {"Elementalist", new Profession("Elementalist", "https://wiki.guildwars2.com/images/2/2f/Elementalist_%28overhead_icon%29.png") },
                {"Guardian", new Profession("Guardian", "https://wiki.guildwars2.com/images/d/de/Guardian_%28overhead_icon%29.png") },

                {"Berserker", new Profession("Berserker", "https://wiki.guildwars2.com/images/5/5a/Berserker_%28overhead_icon%29.png") },
                {"Daredevil", new Profession("Daredevil", "https://wiki.guildwars2.com/images/d/df/Daredevil_%28overhead_icon%29.png") },
                {"Druid", new Profession("Druid", "https://wiki.guildwars2.com/images/2/2e/Druid_%28overhead_icon%29.png") },
                {"Reaper", new Profession("Reaper", "https://wiki.guildwars2.com/images/3/39/Reaper_%28overhead_icon%29.png") },
                {"Chronomancer", new Profession("Chronomancer", "https://wiki.guildwars2.com/images/2/2d/Chronomancer_%28overhead_icon%29.png") },
                {"Herald", new Profession("Herald", "https://wiki.guildwars2.com/images/9/9e/Harbinger_%28overhead_icon%29.png") },
                {"Scrapper", new Profession("Scrapper", "https://wiki.guildwars2.com/images/a/a1/Scrapper_%28overhead_icon%29.png") },
                {"Tempest", new Profession("Tempest", "https://wiki.guildwars2.com/images/0/0b/Tempest_%28overhead_icon%29.png") },
                {"Dragonhunter", new Profession("Dragonhunter", "https://wiki.guildwars2.com/images/9/91/Dragonhunter_%28overhead_icon%29.png") },

                {"Spellbreaker", new Profession("Spellbreaker", "https://wiki.guildwars2.com/images/f/fc/Spellbreaker_%28overhead_icon%29.png") },
                {"Deadeye", new Profession("Deadeye", "https://wiki.guildwars2.com/images/d/d6/Deadeye_%28overhead_icon%29.png") },
                {"Soulbeast", new Profession("Soulbeast", "https://wiki.guildwars2.com/images/3/3a/Soulbeast_%28overhead_icon%29.png") },
                {"Scourge", new Profession("Scourge", "https://wiki.guildwars2.com/images/a/aa/Scourge_%28overhead_icon%29.png") },
                {"Mirage", new Profession("Mirage", "https://wiki.guildwars2.com/images/9/98/Mirage_%28overhead_icon%29.png") },
                {"Renegade", new Profession("Renegade", "https://wiki.guildwars2.com/images/a/ad/Renegade_%28overhead_icon%29.png") },
                {"Holosmith", new Profession("Holosmith", "https://wiki.guildwars2.com/images/f/f3/Holosmith_%28overhead_icon%29.png") },
                {"Weaver", new Profession("Weaver", "https://wiki.guildwars2.com/images/7/7f/Weaver_%28overhead_icon%29.png") },
                {"Firebrand", new Profession("Firebrand", "https://wiki.guildwars2.com/images/9/94/Firebrand_%28overhead_icon%29.png") },

                {"Bladesworn", new Profession("Firebrand", "https://wiki.guildwars2.com/images/6/6e/Bladesworn_%28overhead_icon%29.png") },
                {"Specter", new Profession("Specter", "https://wiki.guildwars2.com/images/9/9c/Specter_%28overhead_icon%29.png") },
                {"Untamed", new Profession("Untamed", "https://wiki.guildwars2.com/images/6/6d/Untamed_%28overhead_icon%29.png") },
                {"Harbinger", new Profession("Harbinger", "https://wiki.guildwars2.com/images/9/9e/Harbinger_%28overhead_icon%29.png") },
                {"Virtuoso", new Profession("Virtuoso", "https://wiki.guildwars2.com/images/0/04/Virtuoso_%28overhead_icon%29.png") },
                {"Vindicator", new Profession("Vindicator", "https://wiki.guildwars2.com/images/d/d6/Vindicator_%28overhead_icon%29.png") },
                {"Mechanist", new Profession("Mechanist", "https://wiki.guildwars2.com/images/c/cb/Mechanist_%28overhead_icon%29.png") },
                {"Catalyst", new Profession("Catalyst", "https://wiki.guildwars2.com/images/3/36/Catalyst_%28overhead_icon%29.png") },
                {"Willbender", new Profession("Willbender", "https://wiki.guildwars2.com/images/1/1e/Willbender_%28overhead_icon%29.png") },



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
