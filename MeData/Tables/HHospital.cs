using System;
using SQLite;

namespace MeData.Tables
{
    public class HHospital
    {
  
            [PrimaryKey]
            public int I { get; set; }

            public string Diagnos { get; set; }
            public string Date { get; set; }


            public string gender { get; set; }

            public override string ToString()
            {
                return this.Diagnos + "   " + this.Date;

            }
        }
    }


