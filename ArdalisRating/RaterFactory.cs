namespace ArdalisRating
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, RatingEngine ratingEngine)
        {
            switch (policy.Type)
            {
                case PolicyType.Auto:
                    return new AutoPolicyRater(ratingEngine, ratingEngine.Logger);

                case PolicyType.Flood:
                    return new FloodPolicyRater(ratingEngine, ratingEngine.Logger);

                case PolicyType.Land:
                    return new LandPolicyRater(ratingEngine, ratingEngine.Logger);

                case PolicyType.Life:
                    return new LifePolicyRater(ratingEngine, ratingEngine.Logger);

                default:
                    // currently this can't be reached
                    return new UnknownPolicyRater(ratingEngine, ratingEngine.Logger);
            }
        }
    }
}
