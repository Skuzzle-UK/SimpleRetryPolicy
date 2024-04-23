namespace RetryPolicySettingsConfiguratorConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Adjust these values and run program to see what effect each value has.
            var retryMaxCount = 30;

            double minDelay = 5;
            double maxDelay = 1800;
            double steepness = 0.7;
            double shape = 4;
            double midpoint = 3;

            for (int retryCount = 0; retryCount < retryMaxCount; retryCount++)
            {
                var calculatedTtt = minDelay + (maxDelay - minDelay) * Math.Pow(1 + Math.Exp(-steepness * (retryCount - midpoint)), -shape);
                Console.WriteLine((int)calculatedTtt);
            }
        }
    }
}
