namespace Skuzzle.Core.Lib.Retry
{
    public interface IRetryPolicyService
    {
        /// <summary>
        /// Generates the time delay before the next retry attempt.
        /// Uses an equation that generates an S shaped curve.
        /// The curve shape can be adjusted via MinDelay, MaxDelay, Steepness, Shape and Midpoint in RetryPolicySettings 
        /// Steepness affects how quickly the time intervals are ramped up towards MaxDelay by adjusting the maximum incline angle of the curve.
        /// Shape affects the radius of the curve before and after the incline.
        /// Midpoint sets at what point the curve becomes a mirror image of the first half.
        /// </summary>
        /// <param name="retryCount">How many times retry has occured</param>
        /// <returns>Returns integer value as calculated between the MinDelay and MaxDelay values</returns>
        int CalculateDelay(int retryCount);
    }
}
