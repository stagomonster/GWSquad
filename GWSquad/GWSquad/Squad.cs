using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace GWSquad
{
    public class Squad
    {
        private string buildid;
        
        public event PropertyChangedEventHandler PropertyChanged;


        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        //public int Id 
        //{ get 
        //    { return Id; } 
        //  set
        //    {
        //        Id = value;
        //        //PropertyChanged(this, new PropertyChangedEventArgs("Id"));
        //    }
        //}



        //[OneToMany]
        //[TextBlob("BuildsBlobbed")]
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

        //public string Names
        //{
        //    get
        //    {

        //    }
        //}



        //public string BuildsBlobbed;

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
        //public Squad(ObservableCollection<Build> build, string name)
        //{
        //    Builds = build;
        //    Name = name;
        //}

        public List<int> getBuildIDs()
        {
            List<int> output = new List<int>();
            string current = "";
            for (int i =0; i<BuildIDs.Length; i++)
            {
                if (BuildIDs[i] == ',')
                {
                    output.Add(int.Parse(current));
                    
                    current = "";
                }
                else
                {
                    current += BuildIDs[i];
                }
            }
            return output;
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
