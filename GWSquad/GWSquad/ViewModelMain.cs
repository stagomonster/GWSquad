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
    public class ViewModelMain //viewmodel that stores Database
    {
        public SquadDatabase squadDB; //Database
        private ObservableCollection<Squad> squads;
        public ObservableCollection<Squad> Squads //List of Squads for use in Squad Table in the Database
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

        public ObservableCollection<Build> BuildList //List of Builds for use in the Build Table in the Database.
                                                     //The Build Table is static and should not change besides intial input, as it stores a fixed number and type of preset build options
        {
            get;
            set;
        }

        public Professions c;
        public event PropertyChangedEventHandler PropertyChanged; //Event Handler for changes
        public ViewModelMain() 
        {
            //Initialization
            c = new Professions();
            Squads = new ObservableCollection<Squad>();
            BuildList = new ObservableCollection<Build>();
            SetSquadList(); //Initialization Function (Async)


        }

        public async Task<Build> GetBuild(int id)
        {
            List<Build> s = await squadDB.GetItemsByID(id);
            return s[s.Count-1];
        }
        public async void SetSquadList()
        {
            await ConnectToDBAsync(); //Connect to Database

            await LoadFromDBAsync(); // Load Squads from Database
            await LoadBuildFromDBAsync(); //Load Builds from Database

            //The below commented out section of code is to be run once on the first run of the app, to save the preset Builds into the database. Afterwards, it should not be used.

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

            //await squadDB.DeleteAllItemsAsync();
            //Squad s = new Squad();
            //s.Name = "Test Squad";
            //s.BuildIDs = "3,6";
            //AddSquad(s);

            //End of Commented out code


        }
        public async Task LoadFromDBAsync() //Loads from the Database (Squad)
        {
            Squads.Clear();
            List<Squad> s = await squadDB.GetSquadsAsync(); 
            for(int i = 0; i<s.Count; i++)
            {
                if (s[i].BuildIDs == null )
                {
                    s[i].BuildIDs = "";
                }
                Squads.Add(s[i]);
                
            }

        }

        public async Task LoadBuildFromDBAsync() //Loads from the Database (Build)
        {
            BuildList.Clear();
            List<Build> b = await squadDB.GetBuildsAsync();
            for(int i = 0; i<b.Count; i++)
            {
                BuildList.Add(b[i]);
            }
            //foreach (var build in await squadDB.GetBuildsAsync())
            //{
            //    BuildList.Add(build);
            //}
        }



        public void DeleteSquad(Squad s) // Deletes a Squad
        {
             //prevent deletion while searching
            Squads.Remove(s);
            squadDB.DeleteItemAsync(s);
            SaveDBAsync();
        }
        public async void SaveDBAsync() //Saves the Squads in the Database
        {
            await squadDB.DeleteAllItemsAsync();    
            for (int i = 0; i < Squads.Count; i++)
            {
                Squad temp = Squads[i];
                await squadDB.SaveItemAsync(temp);
            }
        }
        public void AddSquad(Squad s) //Adds a Squad to Database
        {
            if (s!= null)
            {
                Squads.Add(s);
                squadDB.SaveItemAsync(s);
            }
        }
        public void AddBuild(Build b) // Adds a Build to Database
        {
            if (b != null)
            {
                BuildList.Add(b);
                squadDB.SaveItemAsync(b);
            }
        }
        public async Task ConnectToDBAsync() // Connection to Database
        {
            squadDB = await SquadDatabase.Instance;

        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
