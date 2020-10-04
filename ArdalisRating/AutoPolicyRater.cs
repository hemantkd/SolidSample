namespace ArdalisRating
{
    public class AutoPolicyRater
    {
        private readonly RatingEngine _rateEngine;
        private readonly ConsoleLogger _logger;

        public AutoPolicyRater(RatingEngine ratingEngine, ConsoleLogger logger)
        {
            _rateEngine = ratingEngine;
            _logger = logger;
        }

        public void Rate(Policy policy)
        {
            _logger.Log("Rating AUTO policy...");
            _logger.Log("Validating policy.");

            if (string.IsNullOrEmpty(policy.Make))
            {
                _logger.Log("Auto policy must specify Make");
                return;
            }

            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    _rateEngine.Rating = 1000m;
                }

                _rateEngine.Rating = 900m;
            }
        }
    }
}
