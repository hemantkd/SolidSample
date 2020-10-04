namespace ArdalisRating
{
    public class UnknownPolicyRater : Rater
    {
        public UnknownPolicyRater(RatingEngine ratingEngine, ConsoleLogger logger)
            : base(ratingEngine, logger)
        { }

        public override void Rate(Policy policy)
        {
            Logger.Log("Unknown policy type");
        }
    }
}