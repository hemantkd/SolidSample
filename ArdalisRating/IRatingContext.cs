namespace ArdalisRating
{
    public interface IRatingContext
    {
        RatingEngine Engine { get; set; }
        ConsoleLogger Logger { get; }
        Rater CreateRaterForPolicy(Policy policy, IRatingContext context);
        Policy GetPolicyFromJsonString(string policyJson);
        Policy GetPolicyFromXmlString(string policyXml);
        string LoadPolicyFromFile();
        string LoadPolicyFromURI();
        void Log(string message);
        void UpdateRating(decimal rating);
    }
}