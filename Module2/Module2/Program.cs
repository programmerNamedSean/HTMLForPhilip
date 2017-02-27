using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //String storing an odd row of the chess board represented in Xs and Os 
            string oddRow = "XOXOXOXO";
            //String storing an even row of the chess board represented in Xs and Os 
            string evenRow = "OXOXOXOX";
            //A for loop which constructs the board
            for (int i = 0; i < 7; i++)
            {
                //Checks to see if this is the first row.
                if(i ==0)
                {
                    //Prints out the odd row String representation.
                    Console.WriteLine(oddRow);
                }
                //Checks to see if this is an even row.               
                if(i %2==0)
                {
                    //Prints out the even row String representation.
                    Console.WriteLine(evenRow);
                }else//Assumes the rest are odd rows.
                {
                    //Prints out the odd row String representation.
                    Console.WriteLine(oddRow);
                }
                //end of decision tree
            }//end of for loop
        }//end of main
    }//end of class
}//end of namespace
