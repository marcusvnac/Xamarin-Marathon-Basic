using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace Cats.Services
{
    public class AzureService<T>
    {
        private IMobileServiceClient client;
        private IMobileServiceTable<T> table;

        public AzureService()
        {
            string myAppServiceURL = "http://labmarcuscoutomaratonaxamarin.azurewebsites.net/";
            client = new MobileServiceClient(myAppServiceURL);
            table = client.GetTable<T>();
        }

        public Task<IEnumerable<T>> GetTable()
        {
            return table.ToEnumerableAsync();
        }
    }
}
