using Peasy;
using PeasyDotNetFrameworkSample.BusinessLogic.DTO;

namespace PeasyDotNetFrameworkSample.BusinessLogic.Services
{
    public class PersonService : ServiceBase<Person, int>
    {
        public PersonService(IDataProxy<Person, int> dataProxy) : base(dataProxy)
        {
        }
    }
}
