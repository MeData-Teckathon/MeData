using System;
using SQLite;

namespace MeData.Tables
{
    public class DDrug
    {
        [PrimaryKey]
        public int II { get; set; }

        public string Drug { get; set; }
        public string Pre { get; set; }


        public string gender { get; set; }

        public override string ToString()
        {
            return this.Drug + "   " + this.Pre;

        }
    }
}
