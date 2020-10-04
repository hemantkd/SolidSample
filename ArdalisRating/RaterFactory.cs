using System;

namespace ArdalisRating
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, RatingEngine ratingEngine)
        {
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.{policy.Type}PolicyRater"),
                    new object[] { ratingEngine, ratingEngine.Logger });
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
