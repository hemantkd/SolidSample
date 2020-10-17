﻿namespace ArdalisRating
{
    public class DefaultRatingContext : IRatingContext
    {
        private readonly IPolicySource _policySource;
        private readonly IPolicySerializer _policySerializer;

        public DefaultRatingContext(IPolicySource policySource, IPolicySerializer policySerializer)
        {
            _policySource = policySource;
            _policySerializer = policySerializer;
        }

        public RatingEngine Engine { get; set; }

        public Rater CreateRaterForPolicy(Policy policy, IRatingContext context)
        {
            return new RaterFactory().Create(policy, context);
        }

        public Policy GetPolicyFromJsonString(string policyJson)
        {
            return _policySerializer.GetPolicyFromJsonString(policyJson);
        }

        public Policy GetPolicyFromXmlString(string policyXml)
        {
            throw new System.NotImplementedException();
        }

        public string LoadPolicyFromFile()
        {
            return _policySource.GetPolicyFromSource();
        }

        public string LoadPolicyFromURI(string uri)
        {
            throw new System.NotImplementedException();
        }

        public void Log(string message)
        {
            new ConsoleLogger().Log(message);
        }
    }
}