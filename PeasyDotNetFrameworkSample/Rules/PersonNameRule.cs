using Peasy;

namespace PeasyDotNetFrameworkSample.Rules
{
    public class PersonNameRule : RuleBase
    {
        private string _name;

        public PersonNameRule(string name)
        {
            _name = name;
        }

        protected override void OnValidate()
        {
            if (_name == "Fred Jones")
            {
                Invalidate("Name cannot be fred jones");
            }
        }
    }
}
