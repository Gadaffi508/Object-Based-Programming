namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Mathematic.Calculate_R(ref a);
            Console.WriteLine(a);

            //<--------------------------->

            int b;
            Mathematic.Calculate_O(out b);
            Console.WriteLine(b);
        }

        /// <summary>
        /// Mathematic class
        /// Calculate Random
        /// Out and Ref
        /// </summary>

        class Mathematic
        {
            static public void Calculate_R(ref int r)
            {
                r = r * r;
            }

            //<-------------------------------------->

            static public void Calculate_O(out int r)
            {
                r = 10;
            }
        }
    }
}