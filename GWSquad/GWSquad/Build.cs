using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace GWSquad
{

    //[Table("Build")]
    public class Build
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }


        //[ForeignKey(typeof(Squad))]
        //public int SquadId { get; set; }


        //boonlist
        //Aegis, Alacrity, Fury, Might, Protection, Quickness, Regeneration, Resistance, Resolution, Stability, Swiftness, Vigor
        //bool[] hasBoon;
        public bool Aegis;
        public bool Alacrity;
        public bool Fury;
        public bool Might;
        public bool Protection;
        public bool Quickness;

        public bool Regeneration;
        public bool Resistance;
        public bool Resolution;
        public bool Stability;

        public bool Swiftness;
        public bool Vigor;
        public string type; //power condi 
        private string role; //Damage, Offensive Support, Support
        public string Role
        {
            get { return role; }
            set
            {
                if (role != value)
                {
                    role = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Role"));
                    }
                }
            }
        }
        private string bname;
        public string BName
        {
            get { return bname; }
            set
            {
                if (bname != value)
                {
                    bname = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("BName"));
                    }
                }
            }
        }

        public string c;

        public Build()
        {
            
        }
        
        public Build(bool Aegis, bool Alacrity,
            bool Fury, bool Might, bool Protection, bool Quickness,
            bool Regeneration, bool Resistance, bool Resolution, bool Stability, bool Swiftness, bool Vigor,
            string type,  string role, string name, string c)
        {
            //hasBoon = new bool[] { Aegis, Alacrity, Fury, Might, Protection, Quickness, Regeneration, Resistance, Resolution, Stability, Swiftness, Vigor };
            this.Aegis = Aegis;
            this.Alacrity = Alacrity;
            this.Fury = Fury;
            this.Might = Might;
            this.Protection = Protection;
            this.Quickness = Quickness;
            this.Regeneration = Regeneration;   
            this.Resistance = Resistance;   
            this.Resolution = Resolution;
            this.Stability = Stability;
            this.Swiftness = Swiftness;
            this.Vigor = Vigor;

            this.type = type;
            this.role = role;
            this.bname = name;
            this.c = c;
        }

        //public Build(bool[] hasBoon, BuildType type, Class c)
        //{
        //    this.hasBoon = hasBoon;
        //    this.type = type;
        //    this.c = c;
        //}
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public enum BuildType
    {
        Power,
        Condition,
        Support
    }
}
