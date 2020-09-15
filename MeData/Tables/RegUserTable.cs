using System;
using SQLite;

namespace MeData.Tables
{
    public class RegUserTable
    {
       [PrimaryKey]
        public int ID { get; set;}
        
        public string Name { get; set; }
        public string Age{ get; set; }
        
        
        public string gender { get; set; }

        public override string ToString()
        {
            return "Age:" + this.Age + "   Smoking:" + this.Name
                 + "   Alcohol Intake:" + this.gender;
        }
    }
}
