using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace GWSquad
{
    public partial class MainPage : ContentPage
    {
        public ViewModelMain viewmodel;
        private Squad selected;
        
        public MainPage()
        {
            InitializeComponent();

            viewmodel = new ViewModelMain();
            BindingContext = viewmodel;
        }

        private void squadlist_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            selected = e.Item as Squad;

        }

        private void Delete(object sender, EventArgs e)
        {
            if(squadlist.SelectedItem != null)
            {
                squadlist.SelectedItem = null;
                viewmodel.DeleteSquad(selected);

            }
        }

        private void Rename(object sender, EventArgs e)
        {
            
        }

        private void Edit(object sender, EventArgs e)
        {
            if(squadlist.SelectedItem != null)
            {
                Navigation.PushAsync(new SquadEdit(selected, viewmodel));

            }
        }

        private void Entry_Completed(object sender, EventArgs e)
        {

        }
        private void Add(object sender, EventArgs e)
        {
            //Squad squad = new Squad();
            //squad.Name = "New Squad";
            //ObservableCollection<Build> basic = new ObservableCollection<Build>();
            //basic.Add(new Build(false, false, false, false, false, false, false, false, false, false, false, false, "Power", "Damage", "Generic DPS", "Deadeye"));
            //squad.Builds = basic;

            Squad squad = new Squad
            {
                Name = "New Squad",
                BuildIDs = ""
            };



            //Build b = new Build(false, false, false, false , false, false , false, false ,false, false , false , false, BuildType.Power,s.ClassList.)


            viewmodel.AddSquad(squad);
            Navigation.PushAsync(new SquadEdit(squad, viewmodel));
            //???? 

        }

    }
}
