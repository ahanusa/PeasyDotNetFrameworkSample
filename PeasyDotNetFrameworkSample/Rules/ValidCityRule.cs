using Peasy;

namespace PeasyDotNetFrameworkSample.Rules
{
    public class ValidCityRule : RuleBase
    {
        private string _city;

        public ValidCityRule(string city)
        {
            _city = city;
        }

        protected override void OnValidate()
        {
            if (_city == "Nowhere")
            {
                Invalidate("Nowhere is not a city");
            }
        }
    }
}
