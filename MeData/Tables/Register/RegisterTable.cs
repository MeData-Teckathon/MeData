using System;

using Xamarin.Forms;

namespace MeData.Tables.Register
{
    public class RegisterTable
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullNameID { get; set; }
        public string AgeID { get; set; }
        public string GenderID { get; set; }
        public string SmokingID { get; set; }
        public string AlcoholID { get; set; }
        public string DiseasesID { get; set; }
        public string DoctorsID { get; set; }
    }
}

