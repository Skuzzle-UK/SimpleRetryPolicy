namespace Skuzzle.Core.Lib.Retry.Settings
{
    public class RetryPolicySettings
    {
        public double MinDelay { get; set; }
        public double MaxDelay { get; set; }
        public double Steepness { get; set; }
        public double Shape { get; set; }
        public double Midpoint { get; set; }
        public int MaxRetries { get; set; }
    }
}
