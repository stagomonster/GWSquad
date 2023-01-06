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
    public partial class SquadEdit : ContentPage
    {
        private string squadName;
        public string SquadName
        {
            get { return squadName; }
            set { squadName = value; } 
        }

        public ViewModelMain v;
        public SquadEdit(Squad s, ViewModelMain v)
        {
            InitializeComponent();
            SquadName = s.Name;
            this.v = v;
            BindingContext = s;
            // Details: x/10 builds, 
        }

        private void Delete(object sender, EventArgs e)
        {

        }

        private void Add(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BuildSelect(v));

        }

        private void buildList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}