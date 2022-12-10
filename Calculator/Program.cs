//  do not shorten names of the variables
//  todo:set and get functions
//  todo:pushAtLast()
//  todo:pop()

namespace Calculator
{
    class Number
    {
        /*todo:
         * contain value id
         * 
         */
        public static string removeTheZeros(string x)
        {
            int size = x.Length;
            if (size == 1) return x;
            int j = 0;

            while (j <= (size - 1))
            {
                if (x.ElementAt(size - 1 - j) == '0')
                {
                    j++;
                }
                else break;

            }

            x = x.Substring(0, size - j);
            return x;
        }
    }
    class Collection
    {
        /*todo:
         * contain 
         *         isEmpty
         *         deleteFromIndex
         *         insertAtIndex
         *         getAtIndex
         *         pop
         *         push
         *         
         */
    }
    class Integer : Number
    {
        string NumWithoutPower;
        int thePositionOfDot;
        public Integer()
        {
            NumWithoutPower = "0";
            thePositionOfDot = 0;
        }

        public int val
        {
            get { return (int.Parse(NumWithoutPower)); }
            set { NumWithoutPower = value.ToString(); }
        }

    }
    class Decimal : Number
    {

    }
    class Complex : Number
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "1234";
            x = Number.removeTheZeros(x);

            Console.WriteLine(x);
        }
    }
}

/*todo: 
 * overload ++   /   -    +   
 * 
 */
