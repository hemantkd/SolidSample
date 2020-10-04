namespace ArdalisRating
{
    public class AutoPolicyRater : Rater
    {
        public AutoPolicyRater(RatingEngine ratingEngine, ConsoleLogger logger)
            : base(ratingEngine, logger)
        { }

        public override void Rate(Policy policy)
        {
            Logger.Log("Rating AUTO policy...");
            Logger.Log("Validating policy.");

            if (string.IsNullOrEmpty(policy.Make))
            {
                Logger.Log("Auto policy must specify Make");
                return;
            }

            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    RatingEngine.Rating = 1000m;
                }

                RatingEngine.Rating = 900m;
            }
        }
    }
}
