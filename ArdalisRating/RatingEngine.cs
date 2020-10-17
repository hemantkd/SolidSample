namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        private readonly ILogger _logger;
        private readonly IPolicySource _policySource;

        public IRatingContext Context { get; }

        public decimal Rating { get; set; }

        public RatingEngine(ILogger logger, IPolicySource policySource)
        {
            _logger = logger;
            _policySource = policySource;
            Context = new DefaultRatingContext(_policySource);
            Context.Engine = this;
        }

        public void Rate()
        {
            _logger.Log("Starting rate.");

            _logger.Log("Loading policy.");

            // load policy - open file policy.json
            string policyJson = Context.LoadPolicyFromFile();

            var policy = Context.GetPolicyFromJsonString(policyJson);

            var rater = Context.CreateRaterForPolicy(policy, Context);
            rater.Rate(policy);

            _logger.Log("Rating completed.");
        }
    }
}
