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
    public partial class BuildSelect : ContentPage
    {
        ViewModelMain v;
        private Build selected;
        Squad s;
        public BuildSelect(ViewModelMain v, Squad s)
        {
            InitializeComponent();
            
            this.v = v;
            this.s = s;
            BindingContext = v;

        }

        private void buildList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            selected = e.Item as Build;
        }

        private void Add(object sender, EventArgs e)
        {
            if (staticbuilds.SelectedItem != null )
            {
                if (!String.IsNullOrEmpty(s.BuildIDs))
                {
                    s.BuildIDs = s.BuildIDs + "," + selected.Id.ToString();
                }
                else
                {
                    s.BuildIDs = selected.Id.ToString();
                }
                Navigation.PushAsync(new SquadEdit(s, v));


            }

        }
    }
}