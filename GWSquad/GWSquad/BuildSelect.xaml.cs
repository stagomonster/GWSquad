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


        public BuildSelect(ViewModelMain v)
        {
            InitializeComponent();

        }
    }
}