namespace calculator.TwoArgument
{
    public class Addition : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Addition
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
