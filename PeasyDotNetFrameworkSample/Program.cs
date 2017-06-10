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
            var getResult = service.GetAllCommand().Execute();
            if (getResult.Success)
            {
                foreach (var person in getResult.Value)
                    Debug.WriteLine(person.Name);  // prints each person's name retrieved from PersonMockDataProxy.GetAll
            }

            var newPerson = new Person() { Name = "Freed Jones", City = "Madison" };
            var insertResult = service.InsertCommand(newPerson).Execute();
            if (insertResult.Success)
            {
                Debug.WriteLine(insertResult.Value.ID.ToString()); // prints the id value assigned via PersonMockDataProxy.Insert
            }
        }
    }
}
