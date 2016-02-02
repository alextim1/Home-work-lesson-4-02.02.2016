using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeGrivna
{


    


    class Program
    {
        static int numberOfWays(int currentRemain, int substractedCoin )
        {
            // condition of recursion break

           

            if (currentRemain==0)
            {
                // when we achieve a leaf (currentRemain equal to 0) rote from root to leaf means 1 variant of changing grivna
                return 1;
            }
           

            int[] coins = new int[] { 1, 2, 5, 10, 25, 50 };

            int acc = 0;
            int i = 0;
            
            for (i=0; i<6; i++)
            {
                // considered only coins which value lower than current remain of grivna and coins which value lower than value of previously substracted coin - rote from root to leaf must be monotonically decreasing.
                if ((currentRemain < coins[i])||(substractedCoin< coins[i]))
                {
                    break;
                }

                

                acc = acc + numberOfWays(currentRemain - coins[i], coins[i]);


            }


            

            return acc;


        }


        static void Main(string[] args)
        {
            

            Console.WriteLine("How many ways to change one grivna by coins?");
            int amount=int.Parse(Console.ReadLine());
            Console.WriteLine(numberOfWays(amount, amount));
            Console.ReadKey();
        }
    }
}
