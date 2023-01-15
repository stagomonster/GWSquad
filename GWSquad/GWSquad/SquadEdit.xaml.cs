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

        public List<Build> sqBuilds
        {
            get { return sqBuilds; }
            set { sqBuilds = value; }
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        //public List<string> BuildNames
        //{
        //    get
        //    {
        //        return BuildNames;
        //    }
        //    set
        //    {
                
        //        BuildNames = value;
        //    }
        //}


        public ViewModelMain v;
        Squad s;

        public bool hasAegis = false;
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

            SquadName = s.Name;

            this.v = v;
            this.s = s;
            
            //List<int> ids = s.getBuildIDs();
            //foreach(var id in ids)
            //{
            //    await sqBuilds.Add(v.GetBuild(id));
            //}
            BuildSetup();
            //BuildNames = getBuildNames(s);
            getBoons();
            BindingContext = this;


            InitializeComponent();
            details.Text = "";









            // Details: x/10 builds, 

            //Get Build for Name Role Profession and Bons

        }

        private List<string> getBuildNames(Squad sq)
        {
            List<string> output = new List<string>();
            //List<int> ids = sq.getBuildIDs();
            foreach (Build b in sqBuilds)
            {
                
                output.Add(b.BName);
                
            }
            return output;
        }

        public async void BuildSetup()
        {
            List<int> ids = s.getBuildIDs();
            foreach (var id in ids)
            {
                Build b = await v.GetBuild(id);
                sqBuilds.Add(b);
            }
        }

        public void getBoons()
        {
            foreach (Build b in sqBuilds)
            {
                if (!hasAegis && b.Aegis)
                {
                    hasAegis = true;
                }
                if (!hasAlacrity && b.Alacrity)
                {
                    hasAlacrity = true;
                }
                if (!hasFury && b.Fury)
                {
                    hasFury = true;
                }
                if (!hasMight && b.Might)
                {
                    hasMight = true;
                }
                if (!hasProtection && b.Protection)
                {
                    hasProtection = true;
                }
                if (!hasQuickness && b.Quickness)
                {
                    hasQuickness = true;
                }
                if (!hasRegeneration && b.Regeneration)
                {
                    hasRegeneration = true;
                }
                if (!hasResistance && b.Resistance)
                {
                    hasResistance = true;
                }
                if (!hasResolution && b.Resolution)
                {
                    hasResolution = true;
                }
                if (!hasStability && b.Stability)
                {
                    hasStability = true;
                }
                if (!hasSwiftness && b.Swiftness)
                {
                    
                    hasSwiftness = true;
                }
                if (!hasVigor && b.Vigor)
                {
                    hasVigor = true;
                }
            }
        }
        
        public void setDetails()
        {
            details.FontSize = 16;
            details.Text = String.Format("{0}",hasVigor);
        }
        private void Delete(object sender, EventArgs e)
        {

        }

        private void Add(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BuildSelect(v, s));
        }

        private void buildList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}