using Peasy;
using PeasyDotNetFrameworkSample.BusinessLogic.DTO;
using PeasyDotNetFrameworkSample.Rules;
using System.Collections.Generic;

namespace PeasyDotNetFrameworkSample.BusinessLogic.Services
{
    public class PersonService : ServiceBase<Person, int>
    {
        public PersonService(IDataProxy<Person, int> dataProxy) : base(dataProxy)
        {
        }

        protected override IEnumerable<IRule> GetBusinessRulesForInsert(Person entity, ExecutionContext<Person> context)
        {
            yield return new PersonNameRule(entity.Name);
            yield return new ValidCityRule(entity.City);
        }
    }
}
