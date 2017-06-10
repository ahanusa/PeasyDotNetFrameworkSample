using PeasyDotNetFrameworkSample.BusinessLogic.DataProxies;
using PeasyDotNetFrameworkSample.BusinessLogic.DTO;
using PeasyDotNetFrameworkSample.BusinessLogic.Services;
using System.Diagnostics;

namespace PeasyDotNetFrameworkSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new PersonService(new PersonMockDataProxy());
            var newPerson = new Person() { Name = "Freida Jones", City = "Madison" };
            var insertResult = service.InsertCommand(newPerson).Execute();
            if (insertResult.Success)
            {
                Debug.WriteLine(insertResult.Value.ID.ToString()); // prints the id value assigned via PersonMockDataProxy.Insert
            }
            else
            {
                foreach (var error in insertResult.Errors)
                    Debug.WriteLine(error);
            }
        }
    }
}
