namespace calculator.TwoArgument
{
    public class Multiply : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Multiply
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
