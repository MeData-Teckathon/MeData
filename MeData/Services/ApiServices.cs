using System;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using MeData.Tables.Register;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MeData.Services
{
    public class ApiServices
    {
        private JsonSerializer _serializer = new JsonSerializer();
        private static ApiServices _ServiceClientInstance;


        public static ApiServices ServiceClientInstance
        {
            get
            {
                if (_ServiceClientInstance == null)
                    _ServiceClientInstance = new ApiServices();
                return _ServiceClientInstance;
            }
        }
        FirebaseClient firebase;
        public ApiServices()
        {
          
            firebase = new FirebaseClient("https://medata-278cc.firebaseio.com/");
        }




        //Register User
        public async Task<bool> RegisterUser(string username, string password)
        {
            var result = await firebase
                .Child("RegisterEmployeeTable")
                .PostAsync(new RegisterTable() { UserId = Guid.NewGuid(), UserName = username, Password = password, FullNameID = "Please insert" });
            if (result.Object != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //LoginUser
        public async Task<RegisterTable> LoginUser(string username, string password)
        {
            var GetPerson = (await firebase
              .Child("RegisterEmployeeTable")
              .OnceAsync<RegisterTable>()).Where(a => a.Object.UserName == username).Where(b => b.Object.Password == password).FirstOrDefault();
            if (GetPerson != null)
            {
                var content = GetPerson.Object as RegisterTable;
                return content;
            }
            else
            {
                return null;
            }
        }

    }
}

