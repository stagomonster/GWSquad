using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GWSquad
{
    public class PsuedoSquad //NOT USED
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string buildid;
        public string BuildIDs
        {
            get { return buildid; }
            set
            {
                if (buildid != value)
                {

                    buildid = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Builds"));
                    }
                }

            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                    }
                }
            }
        }

        private List<string> buildnames;
        private List<string> BuildNames
        {
            get
            {
                return buildnames;
            }
            set
            {
                if (buildnames != value)
                {
                    buildnames = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("BuildNames"));
                    }
                }
            }
        }
    }
}
