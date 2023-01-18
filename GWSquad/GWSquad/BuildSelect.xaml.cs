using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GWSquad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildSelect : ContentPage //Page for selecting a Build to Add to the Squad.
    {
        ViewModelMain v; //vm
        private Build selected; //Currently selected build on ListView. Works similar to SquadEdit.xaml.vs and MainPage.xaml.cs
        Squad s; //Squad that will have the Build added.
        public BuildSelect(ViewModelMain v, Squad s) //Constructor
        {
            InitializeComponent();
            
            this.v = v;
            this.s = s;
            BindingContext = v; //binding context to vm

            

        }

        private void buildList_ItemTapped(object sender, ItemTappedEventArgs e) //Similar to SquadEdit.xaml.cs and MainPage.xaml.cs
        {
            selected = e.Item as Build;
        }

        private void Add(object sender, EventArgs e) //Adds the selected Build to the Squad. Saves the Database after, and then pushes the SquadEdit Page (the previous page with the new Build added to squad).
        {
            if (staticbuilds.SelectedItem != null )
            {
                if (!String.IsNullOrEmpty(s.BuildIDs)) //Here is where custom serialization comes into play. Converting a List of int into "2,34,5" format as string.
                {
                    s.BuildIDs = s.BuildIDs + "," + selected.PublicID.ToString(); //if containing some data, "3,4,5,12".
                }
                else
                {
                    s.BuildIDs = selected.PublicID.ToString();  //if empty, "12".
                }
                v.SaveDBAsync();
                Navigation.PushAsync(new SquadEdit(s, v));


            }

        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}