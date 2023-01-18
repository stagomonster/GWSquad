using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GWSquad
{
    public class SquadEditViewModel //This class's only function is to provide a PropertyChanged Event for Binding to the existing List in SquadEdit.xaml.cs.
                                    //There is probably a more efficient way to do this.

    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<Build> sqbuilds; // List of builds in the Squad. Really useful since the Squad class cannot have List<Build> since I moved away from TextBlobbing.
        public List<Build> sqBuilds
        {
            get { return sqbuilds; }
            set
            {
                if (sqbuilds != value)
                {
                    sqbuilds = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("sqBuilds"));
                    }
                }
            }
        }

        public SquadEditViewModel(List<Build> sqbuilds) //constructor
        {
            this.sqbuilds = sqbuilds;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
