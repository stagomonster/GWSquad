using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GWSquad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SquadEdit : ContentPage
    {

        private string squadName;
        public string SquadName
        {
            get { return squadName; }
            set { squadName = value; } 
        }

        public List<Build> SQBUILDS; //List of Builds in the Squad that this class edits. 
                                     //This is NOT Binded, BindingContext is binded to svm -> which allows us to use PropertyChanged Event. svm however is initialized with this value.
        public SquadEditViewModel svm; //ViewModel for the purpose of saving SqBuilds and Binding with Property Changed

        private Build selected;

        public ViewModelMain v; //ViewModel as normal, used to be passed to next Page (and helps with debugging as well).
        Squad s; //Squad that this class is editing. Will also be saved in the ViewModel.Squads List.

        public bool hasAegis = false; //Booleans of the Properties of the Builds in the Squad. This is used to write the Details portion of the Page.
        public bool hasAlacrity = false;
        public bool hasFury = false;
        public bool hasMight = false;
        public bool hasProtection = false;
        public bool hasQuickness = false;

        public bool hasRegeneration = false;
        public bool hasResistance = false;
        public bool hasResolution = false;
        public bool hasStability = false;

        public bool hasSwiftness = false;
        public bool hasVigor = false;
        public SquadEdit(Squad s, ViewModelMain v)
        {


            SQBUILDS = new List<Build>(); //Initialize

            SquadName = s.Name;

            this.v = v;
            this.s = s;

            //List<int> ids = s.getBuildIDs();
            //foreach (var id in ids)
            //{
            //    await sqBuilds.Add(v.GetBuild(id));
            //}
            //Task task = BuildSetup();
            var _ = BuildSetup(); //Main Setup Function. Used instead of the commented out code to prevent weird Async/Sync performances

            //BuildNames = getBuildNames(s);
            //getBoons();
            //svm = new SquadEditViewModel(SQBUILDS);



        }

        

        private List<string> getBuildNames(Squad sq)
        {
            List<string> output = new List<string>();
            
            //List<int> ids = sq.getBuildIDs();
            foreach (Build b in SQBUILDS)
            {
                
                output.Add(b.BName);
                
            }
            return output;
        }

        public async Task BuildSetup()
        {
            List<int> ids = s.getBuildIDs(); //Gets and Saves the Builds to the List.
            for(int i = 0; i<ids.Count; i++)
            {
                Build b = await v.GetBuild(ids[i]);
                SQBUILDS.Add(b);
            }

            getBoons(); //Gets and Saves the Build Properties to the local variables

            svm = new SquadEditViewModel(SQBUILDS); //Instantiates svm to be used for Binding
            BindingContext = svm; //Binding set to svm
            InitializeComponent(); //Initialize 
            setDetails();


        }
        public async Task BuildSetupNoInit() // same function, no Initialize. Used for Deleting and Updating after Deletion.
        {
            SQBUILDS = new List<Build>();
            List<int> ids = s.getBuildIDs(); //Gets and Saves the Builds to the List.
            for (int i = 0; i < ids.Count; i++)
            {
                Build b = await v.GetBuild(ids[i]);
                SQBUILDS.Add(b);
            }

            getBoons(); //Gets and Saves the Build Properties to the local variables

            svm = new SquadEditViewModel(SQBUILDS); //Instantiates svm to be used for Binding
            BindingContext = svm; //Binding set to svm
            setDetails();


        }

        public void setDetails() //sets the Text Field "Details", that shows what your Build has and doesn't have. 
        {
            string count = "Builds: " + SQBUILDS.Count + "/10. ";
            string has = "You have builds that provide: ";
            string missing = "You are missing providers for: ";
            string recommend = "Recommend having at least Alacrity, Quickness, Might, Fury, and Swiftness for most bosses.";

            if (hasAegis)
            {
                has += "Aegis, ";
            }
            else
            {
                missing += "Aegis, ";
            }

            if (hasAlacrity)
            {
                has += "Alacrity, ";
            }
            else
            {
                missing += "Alacrity, ";
            }

            if (hasFury)

            {
                has += "Fury, ";
            }
            else
            {
                missing+= "Fury, ";
            }

            if (hasMight)
            {
                has += "Might, ";
            }
            else
            {
                missing += "Might, ";
            }

            if (hasProtection)

            {
                has += "Protection, ";
            }
            else
            {
                missing += "Protection, ";
            }

            if (hasQuickness)
            {
                has += "Quickness, ";
            }
            else
            {
                missing += "Quickness, ";
            }

            if (hasRegeneration)
            {
                has += "Regeneration, ";
            }
            else
            {
                missing+= "Regeneration, ";
            }

            if (hasResistance)
            {
                has += "Resistance, ";
            }
            else
            {
                missing += "Resistance, ";
            }

            if (hasResolution)

            {
                has += "Resolution, ";
            }
            else
            {
                missing += "Resolution, ";
            }

            if (hasStability)
            {
                has += "Stability, ";
            }
            else
            {
                missing += "Stability, ";
            }

            if (hasSwiftness)
            {

                has += "Swiftness, ";
            }
            else
            {
                missing += "Swiftness, ";
            }
            
            if (hasVigor)
            {
                has += "Vigor, ";
            }
            else
            {
                missing += "Vigor, ";
            }
            if(has!= "You have builds that provide: ")
            {
                has = has.Substring(0, has.Length - 2);
            }
            if(missing!= "You are missing providers for: ")
            {
                missing = missing.Substring(0, missing.Length - 2);
            }
            details.Text = count +Environment.NewLine+ Environment.NewLine+has +Environment.NewLine+ Environment.NewLine + missing +Environment.NewLine+ Environment.NewLine + recommend;
            
        }
        public void getBoons() //Updates the local variables has[buff] to check if the Squad has ANY build that provides that buff
                               //(buffs tend to be given to 10 players at once so one provider is generally enough. 
        {
            foreach (Build b in SQBUILDS) //Checks if buff is provided, then checks it off if it is.
            {
                if (!hasAegis && b.Aegis == 1)
                {
                    hasAegis = true;
                }
                if (!hasAlacrity && b.Alacrity==1)
                {
                    hasAlacrity = true;
                }
                if (!hasFury && b.Fury == 1)
                {
                    hasFury = true;
                }
                if (!hasMight && b.Might == 1)
                {
                    hasMight = true;
                }
                if (!hasProtection && b.Protection == 1)
                {
                    hasProtection = true;
                }
                if (!hasQuickness && b.Quickness == 1)
                {
                    hasQuickness = true;
                }
                if (!hasRegeneration && b.Regeneration == 1)
                {
                    hasRegeneration = true;
                }
                if (!hasResistance && b.Resistance == 1)
                {
                    hasResistance = true;
                }
                if (!hasResolution && b.Resolution == 1)
                {
                    hasResolution = true;
                }
                if (!hasStability && b.Stability == 1)
                {
                    hasStability = true;
                }
                if (!hasSwiftness && b.Swiftness == 1)
                {
                    
                    hasSwiftness = true;
                }
                if (!hasVigor && b.Vigor == 1)
                {
                    hasVigor = true;
                }
            }
        }
        

        private void Delete(object sender, EventArgs e) // Deletes a Build, similar functionality to MainPage.xaml.cs Delete function.
        {

            if (buildList.SelectedItem != null)
            {
                s.DeleteBuild(selected.PublicID); // uses custom function to delete. (due to custom serialization).
                buildList.SelectedItem = null;
                hasAlacrity = false;
                hasResistance = false;
                hasAegis = false;
                hasFury=false;
                hasVigor = false;
                hasRegeneration=false;
                hasResolution=false;
                hasQuickness=false;
                hasMight=false;
                hasProtection=false;
                hasStability=false;
                hasSwiftness=false;
                BuildSetupNoInit();
           }
        }

        private void Add(object sender, EventArgs e) //Prompts to next Page, to see what Build selection they want to add.
        {
            Navigation.PushAsync(new BuildSelect(v, s));
        }

        private void buildList_ItemTapped(object sender, ItemTappedEventArgs e) //Used for Deletion function, similar to MainPage.xaml.cs
        {
            selected = e.Item as Build;

        }
        protected override bool OnBackButtonPressed() //Override Back Button.
        {
            return true;
        }

        private void Button_Clicked(object sender, EventArgs e) //Back Button sends you back to MainPage.xaml
        {
            Navigation.PushAsync(new MainPage(v) { BackgroundColor = Color.Black });
        }
    }
}