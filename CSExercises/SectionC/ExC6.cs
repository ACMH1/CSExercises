using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    public class ExC6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number of TVs: ");
            string strTV = Console.ReadLine();
            int intTV = Convert.ToInt32(strTV);
            Console.WriteLine("Enter number of DVDs: ");
            string strDVD = Console.ReadLine();
            int intDVD = Convert.ToInt32(strDVD);
            Console.WriteLine("Enter number of MP3s: ");
            string strMP3 = Console.ReadLine();
            int intMP3 = Convert.ToInt32(strMP3);
            int sum = intTV + intDVD + intMP3;

            if (sum == intTV || sum == intDVD || sum == intMP3)
            {
                Console.WriteLine(CalculateTotalPrice(intTV, intDVD, intMP3));
            }
            else
            {
                Console.WriteLine("Error: more than one product selected");
            }

        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            int subTotal = 900 * tvQty + 500 * dvdQty + 700 * mp3Qty;
            if (subTotal > 5000 && subTotal <= 10000)
            {
                subTotal -= (900 * tvQty + 500 * dvdQty) * 10 / 100;
            }
            else if (subTotal > 10000)
            {
                subTotal -= (900 * tvQty + 500 * dvdQty) * 15 / 100;
            }
            return subTotal;



        }
    }
}