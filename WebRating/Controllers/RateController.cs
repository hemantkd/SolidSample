using System.Text.Json;
using ArdalisRating;
using ArdalisRating.Infrastructure.PolicySources;
using Microsoft.AspNetCore.Mvc;

namespace WebRating.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {
        private readonly RatingEngine _ratingEngine;
        private readonly StringPolicySource _policySource;

        public RateController(RatingEngine ratingEngine,
            StringPolicySource policySource)
        {
            _ratingEngine = ratingEngine;
            _policySource = policySource;
        }

        [HttpPost]
        public ActionResult<decimal> Rate([FromBody] JsonElement body)
        {
            _policySource.PolicyString = JsonSerializer.Serialize(body);
            _ratingEngine.Rate();

            return _ratingEngine.Rating;
        }
    }
}