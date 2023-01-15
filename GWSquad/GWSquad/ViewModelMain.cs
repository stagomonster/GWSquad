using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace GWSquad
{
    public class ViewModelMain
    {
        public SquadDatabase squadDB;
        private ObservableCollection<Squad> squads;
        public ObservableCollection<Squad> Squads
        {
            get { return squads; }  
            set
            {
                if (squads != value)
                {
                    squads = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Squads"));
                }
            }
        }

        public ObservableCollection<Build> BuildList
        {
            get;
            set;
        }

        public Professions c;
        public event PropertyChangedEventHandler PropertyChanged;
        public ViewModelMain() 
        {
            c = new Professions();
            Squads = new ObservableCollection<Squad>();
            BuildList = new ObservableCollection<Build>();
            SetSquadList();


            //AddBuild(BuildConstant.constant["string"]);
            //AddBuild(BuildConstant.constant["string"]);
            //AddBuild(BuildConstant.constant["string"]);
            //AddBuild(BuildConstant.constant["string"]);



        }

        public async Task<Build> GetBuild(int id)
        {
            List<Build> s = await squadDB.GetItemsByID(id);
            return s[0];
        }
        public async void SetSquadList()
        {
            await ConnectToDBAsync();

            //AddBuild(BuildConstant.constant["Condition Firebrand"]);
            //AddBuild(BuildConstant.constant["Quickness Firebrand"]);

            LoadFromDBAsync();
            LoadBuildFromDBAsync();

            //await squadDB.DeleteAllBuildAsync();
            //AddBuild(BuildConstant.constant["Condition Firebrand"]);
            //AddBuild(BuildConstant.constant["Quickness Firebrand"]);
            //AddBuild(BuildConstant.constant["Heal Quickness Firebrand"]);
            //AddBuild(BuildConstant.constant["Power Dragonhunter"]);
            //AddBuild(BuildConstant.constant["Condition Soulbeast"]);
            //AddBuild(BuildConstant.constant["Handkite Soulbeast"]);
            //AddBuild(BuildConstant.constant["Heal Alacrity Druid"]);
            //AddBuild(BuildConstant.constant["Heal Alacrity Mechanist"]);
            //AddBuild(BuildConstant.constant["Power Alacity Mechanist"]);
            //AddBuild(BuildConstant.constant["Condition Mechanist"]);
            //AddBuild(BuildConstant.constant["Power Mechanist"]);

            //AddBuild(BuildConstant.constant["Power Quickness Scrapper"]);

            //AddBuild(BuildConstant.constant["Power Scrapper"]);

            //AddBuild(BuildConstant.constant["Heal Scourge"]);
            //AddBuild(BuildConstant.constant["Condition Scourge"]);
            //AddBuild(BuildConstant.constant["Power Reaper"]);
            //AddBuild(BuildConstant.constant["Condition Quickness Harbinger"]);


            //ObservableCollection<Build> list = new ObservableCollection<Build>();
            //Profession suppHerald;
            //Professions.ClassList.TryGetValue("Revenant", out suppHerald);
            //list.Add(new Build(false, false, true, false, true, true, false, false, false, true, true, false, "Power", "Support","Support Herald", suppHerald));
            //Squad testSquad = new Squad();
            //testSquad.Builds = list;
            //testSquad.Name = "testSquad";
            //AddSquad(testSquad);

            //Profession condiMechanist = new Profession("", "");
            //Professions.ClassList.TryGetValue("Engineer", out condiMechanist);
            //ObservableCollection<Build> list2 = new ObservableCollection<Build>();
            //list2.Add(new Build(false, false, true, false, true, true, false, false, false, true, true, false, "Condition", "Offensive Support","Condition Mechanist", condiMechanist));
            //Squad testSquad2 = new Squad();
            //testSquad2.Builds = list2;
            //testSquad2.Name = "CondiSquad";
            //AddSquad(testSquad2);
        }
        public async void LoadFromDBAsync()
        {
            Squads.Clear();
            foreach (var squad in await squadDB.GetSquadsAsync())
            {
                Debug.WriteLine("HEREHREHREHREHREHREHRERHERH", squad.BuildIDs);
                if (squad.BuildIDs == null )
                {
                    Debug.WriteLine("is null :(");
                    squad.BuildIDs = "";
                }
                Squads.Add(squad);
                
            }

        }

        public async void LoadBuildFromDBAsync()
        {
            BuildList.Clear();
            foreach (var build in await squadDB.GetBuildsAsync())
            {
                BuildList.Add(build);
            }
        }



        public void DeleteSquad(Squad s)
        {
             //prevent deletion while searching
            Squads.Remove(s);
            squadDB.DeleteItemAsync(s);
            SaveDBAsync();
            //contactDB.DeleteItemAsync(contact);
        }
        public async void SaveDBAsync()
        {
            await squadDB.DeleteAllItemsAsync();
            for (int i = 0; i < Squads.Count; i++)
            {
                Squad temp = Squads[i];
                await squadDB.SaveItemAsync(temp);
            }
        }
        public void AddSquad(Squad s)
        {
            if (s!= null)
            {
                Squads.Add(s);
                squadDB.SaveItemAsync(s);
            }
        }
        public void AddBuild(Build b)
        {
            if (b != null)
            {
                squadDB.SaveItemAsync(b);
            }
        }
        public async Task ConnectToDBAsync()
        {
            squadDB = await SquadDatabase.Instance;

        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
