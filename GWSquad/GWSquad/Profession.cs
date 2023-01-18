using System;
using System.Collections.Generic;
using System.Text;

namespace GWSquad
{
    public class Profession //NOT USED. Was intended for use with Professions.cs as Icon.
    {
        public string name;
        public string imageurl;
        public Profession(string n, string url)
        {
            name = n;
            imageurl = url;
        }
    }
}
