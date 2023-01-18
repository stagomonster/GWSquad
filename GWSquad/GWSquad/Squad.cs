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
        private string buildid; //List of Build IDS that correspond to PublicID property in Build.cs.
                                //It is in string format "2,3,4,324," to be able to be saved in database. 
  
        
        public event PropertyChangedEventHandler PropertyChanged;


        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } //Database ID




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




        private string name;
        public string Name //Squad Name
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


        public List<int> getBuildIDs() //Deserialize/parse the BuildID string property into a list of IDs
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
            if (current != "")
            {
                output.Add(int.Parse(current));
                current = "";
            }
            return output;
        }

        public void DeleteBuild(int id) //Deletes a Build ID from the buildid property.
        {
            List<int> ids = getBuildIDs();
            for(int i = ids.Count-1; i>=0; i--)
            {
                if (ids[i] == id)
                {
                    ids.RemoveAt(i);
                    
                }
            }
            string replace = "";
            for(int i = 0;i<ids.Count; i++)
            {
                replace += ids[i];
                if (i != ids.Count - 1)
                {
                    replace += ",";
                }
            }
            buildid = replace;
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
