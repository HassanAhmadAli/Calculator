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
            int i = size -1;
                        while (i-- > size)
            {
                if (x.ElementAt( i ) == '0')
                {
                    x.Remove(i);
                }
                else
                {
                    break;
                }
            }
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
            Integer x;
            string a = "1000";
            a;
            Console.WriteLine(Number.removeTheZeros(a));


        }
    }
}

/*todo: 
 * overload ++   /   -    +   
 * 
 */
