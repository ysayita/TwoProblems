namespace SumOfMultiple
{
    static class Utilities
    {
        public static bool IsMultiple(this int Number, int Multiple) =>
          Number != 0 && Number % Multiple == 0;
    }
}
