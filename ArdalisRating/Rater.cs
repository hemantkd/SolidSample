namespace ArdalisRating
{
    public abstract class Rater
    {
        protected readonly RatingEngine RatingEngine;
        protected readonly ConsoleLogger Logger;

        protected Rater(RatingEngine ratingEngine, ConsoleLogger logger)
        {
            RatingEngine = ratingEngine;
            Logger = logger;
        }

        public abstract void Rate(Policy policy);
    }
}