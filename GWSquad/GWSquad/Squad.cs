using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace GWSquad
{
    public class Squad
    {
        private int[] builds;
        
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
        [TextBlob("BuildsBlobbed")]
        public int[] Builds
        {
            get { return builds; }
            set
            {
                if (builds != value)
                {
                    
                    builds = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Builds"));
                    }
                }

            }
        }



        public string BuildsBlobbed;

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
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
