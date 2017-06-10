using PeasyDotNetFrameworkSample.BusinessLogic.DataProxies;
using PeasyDotNetFrameworkSample.BusinessLogic.DTO;
using PeasyDotNetFrameworkSample.BusinessLogic.Services;
using System.Diagnostics;
using System.Linq;

namespace PeasyDotNetFrameworkSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new PersonService(new PersonMockDataProxy());
            var newPerson = new Person() { Name = "Fred Jones", City = "Nowhere" };
            var insertResult = service.InsertCommand(newPerson).Execute();
            if (insertResult.Success)
            {
                Debug.WriteLine(insertResult.Value.ID.ToString());
            }
            else
            {
                // This line will execute and print 'Name cannot be fred jones' and 'Nowhere is not a city'
                // Note that insertResult.Value will be NULL as PersonMockDataProxy.Insert did not execute due to failed rule
                foreach (var error in insertResult.Errors)
                    Debug.WriteLine(error);
            }
        }
    }
}
