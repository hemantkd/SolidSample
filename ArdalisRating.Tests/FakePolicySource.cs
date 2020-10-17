namespace ArdalisRating.Tests
{
    public class FakePolicySource : IPolicySource
    {
        public string GetPolicyFromSource()
        {
            return PolicyString;
        }

        public string PolicyString { get; set; } = "";
    }
}