namespace calculator.TwoArgument
{
    public class Substraction : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Substruction
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
