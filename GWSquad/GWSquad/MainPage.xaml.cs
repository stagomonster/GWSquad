using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Threading;

namespace GWSquad
{
    public partial class MainPage : ContentPage
    {
        public ViewModelMain viewmodel; // viewmodel for data
        private Squad selected; //System to delete item from ListView
        
        public MainPage() //constructor
        {
            
            InitializeComponent();

            viewmodel = new ViewModelMain();
            BindingContext = viewmodel; //bind to vm
            
        }

        public MainPage(ViewModelMain viewmodel) //Constructor IF and only IF it is from SquadEdit screen, meaning that the Viewmodel is already established during App run.
        {
            InitializeComponent();
            this.viewmodel = viewmodel;
            BindingContext = this.viewmodel; //bind to vm
        }

        private void squadlist_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            selected = e.Item as Squad;

        }

        private void Delete(object sender, EventArgs e) // Delete from listview
        {
            if(squadlist.SelectedItem != null)
            {
                squadlist.SelectedItem = null;
                viewmodel.DeleteSquad(selected);
            }
        }

        private void Edit(object sender, EventArgs e) //Pushes SquadEdit Page to edit the existing squad.
        {
            if(squadlist.SelectedItem != null)
            {
                Navigation.PushAsync(new SquadEdit(selected, viewmodel));

            }
        }

        private void Add(object sender, EventArgs e) //Pushes SquadEdit Page to edit new Squad created.
        {


            Squad squad = new Squad();
            squad.Name = "New Squad";
            squad.BuildIDs = "0"; //This corresponds to "Condition Firebrand" as seen in BuildConstant.cs


            viewmodel.AddSquad(squad);
            Navigation.PushAsync(new SquadEdit(squad, viewmodel));
            

        }
        protected override bool OnBackButtonPressed() // Override back button
        {
            return true;
        }

    }
}
