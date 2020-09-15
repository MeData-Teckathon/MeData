using System;
using SQLite;

namespace MeData.Tables
{
    public class RegUserTable
    {
       [PrimaryKey]
        public int ID { get; set;}
        public string d { get; set; }
        public string Name { get; set; }
        public string Age{ get; set; }
        public string Smoke { get; set; }
        public string Alco { get; set; }
        public string gender { get; set; }

        public override string ToString()
        {
            return "Full Name: " + this.Name + "\n" + "Age:       " + this.Age +
                "\n" + "Gender:    " + this.gender + "\n" + "Alcohol Consumption: " + this.Alco + "\n" + "Smoking:   "+ this.Smoke;
        }
    }
}
