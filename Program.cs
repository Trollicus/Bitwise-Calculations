using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseCalculationTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // <-  Bitwise Shift Left ->
             Console.WriteLine(1<<4);//16 from binary to decimal
            //basically the shift left operations the most-significant bit is lost and a 0 bit is inserted on the other end
            //Basically 0001  is 1 in bits, right?
            //if you do 1<<4 you're moving the bites in one to left by 4 in this case
            //and the bits will be 00010000 which is 16

            //<- Bitwise Shift Right ->
              Console.WriteLine(11 >> 3);
            //1011 is 11 in 4-bit binary number from decimal
            //from what i understand is  it removes the number
            //so it'll be 0101
            //When shift right with a logical right shift, the least-signification bit is lost and a 0 is inserted
            //into theo ther end
            //by theory if we do 11 >> 2 we have 0101 the zero being removed and it should be 0010
            //if we do 11 >> 3 | 1011 | it should be 0001 which is 1

            //Bitwise AND
            //1 & 1 = 1 
            //1 & 0 = 0
            //0 & 1 = 0
            //0 & 0 = 0

            //5 & 6 gives 4

            // at the bit level:
            //     0101  (5)
            //   & 0110  (6)
            //   = 0100  (4)

            Console.WriteLine(5 & 6);

            //Bitwise OR

            //1 | 1  =  1
            //1 | 0  =  1
            //0 | 1  =  1
            //0 | 0  =  0

            //5 | 6  // gives 7

            // At the bit level:
            //     0101  (5)
            //   | 0110  (6)
            //   = 0111  (7)

            Console.WriteLine(5 | 7);


            //Bitwise NOT
            //The Bitwise not operation inverts bits
            //so 0 becomes 1 and 1 becomes 0
            //The NOT operation is often written as a tilde char aka "~"

            //uint because the uint can also take the zero
            //This is a great example from Microsoft:
            uint a = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
            uint b = ~a;
            Console.WriteLine(Convert.ToString(b, toBase: 2));
            // Output:
            // 11110000111100001111000011110011

            //Bitwise XOR(eXclusive OR)
            //The XOR operation takes 2 bits and returns 1 if exactly one of the bit is 1  otherwise, it returns 0
            //1 ^ 1  =  0
            //1 ^ 0   1
            //0 ^ 1  =  1
            //0 ^ 0  =  0

            // ^ 6  // gives 3

            // At the bit level:
            //     0101  (5)
            //   ^ 0110  (6)
            //   = 0011  (3)

            Console.WriteLine(5 ^ 6);

            Console.ReadLine();
        }
    }
}
