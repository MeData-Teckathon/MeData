using System;
using SQLite;

namespace MeData.Tables
{
    public class DDoctor
    {
        [PrimaryKey]
        public int III { get; set; }

        public string Doc { get; set; }
        public string Num { get; set; }


        public string gender { get; set; }

        public override string ToString()
        {
            return this.Doc + "   " + this.Num;

        }
    }
}
