using Microsoft.Extensions.Options;
using Skuzzle.Core.Service.Retry.Settings;

namespace Skuzzle.Core.Service.Retry
{
    public class RetryPolicyService : IRetryPolicyService
    {
        private readonly RetryPolicySettings _settings;
        
        public RetryPolicyService(IOptions<RetryPolicySettings> settings)
        {
            _settings = settings.Value;
        }

        public int CalculateDelay(int retryCount)
        {
            try
            {
                var ttl = _settings.MinDelay + (_settings.MaxDelay - _settings.MinDelay) * Math.Pow(1 + Math.Exp(-_settings.Steepness * (retryCount - _settings.Midpoint)), -_settings.Shape);
                return (int)ttl;
            }
            catch
            {
                return (int)_settings.MaxDelay;
            }
        }
    }
}
