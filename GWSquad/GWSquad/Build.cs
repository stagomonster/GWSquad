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
        public event PropertyChangedEventHandler PropertyChanged; //property changed event

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } //ID for Database

        public int PublicID { get; set; } //PUBLIC ID for Squad BUILDID Property and used to Reference specific Builds within that BUILDID property.


        //[ForeignKey(typeof(Squad))]
        //public int SquadId { get; set; }


        //boonlist
        //Aegis, Alacrity, Fury, Might, Protection, Quickness, Regeneration, Resistance, Resolution, Stability, Swiftness, Vigor
        //bool[] hasBoon;
        public int Aegis { get; set; } //Bunch of booleans reflecting whether or not the build provides that buff.
        public int Alacrity { get; set; }
        public int Fury { get; set; }
        public int Might { get; set; }
        public int Protection { get; set; }
        public int Quickness { get; set; }

        public int Regeneration { get; set; }
        public int Resistance { get; set; }
        public int Resolution { get; set; }
        public int Stability { get; set; }

        public int Swiftness { get; set; }
        public int Vigor { get; set; }
        public string type { get; set; } //power condi. | Damage type of Build. Useful for bosses that favor condi/power classes.
        private string role; //Damage, Offensive Support, Support. | What role the Build plays.
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
        public string BName //Build Name
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

        private string c;
        public string C //Build Profession/Class, eg. Firebrand.
        {
            get { return c; }
            set 
            { if (c != value)
                {
                    c = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("C"));
                    }
                } 
            }
        }

        public Build()
        {
            
        }
        
        public Build(int pid, int Aegis, int Alacrity,
            int Fury, int Might, int Protection, int Quickness,
            int Regeneration, int Resistance, int Resolution, int Stability, int Swiftness, int Vigor,
            string type,  string role, string name, string c) //Constructor. Don't worry, this is only used in the Dictionary BuildConstant.cs which is static, not anywhere else. 
        {
            this.PublicID = pid;
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

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    //public enum BuildType 
    //{
    //    Power,
    //    Condition,
    //    Support
    //}
}
