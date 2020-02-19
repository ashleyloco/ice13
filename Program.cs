using System;

namespace ICE12_Locatelli
{
    class Program
    {
        static void Main(string[] args)
        {
            const string SKI_JACKET= "Ski Jackets";
            const double SKI_JACKET_PRICE= 129.50;
            const string SKI_PANT= "Ski Pants";
            const double SKI_PANT_PRICE= 85.90;
            const string CARGO_SHORT= "Cargo Shorts";
            const double CARGO_SHORT_PRICE= 57.95;
            const string PRINTED_TSHIRT= "Printed T-Shirt";
            const double PRINTED_TSHIRT_PRICE= 30.75;
            string[] listItems = new string[4];
            double[] listPrices = new double[4];
            listItems[0] = SKI_JACKET;
            listItems[1] = SKI_PANT;
            listItems[2] = CARGO_SHORT;
            listItems[3] = PRINTED_TSHIRT;
            listPrices[0] = SKI_JACKET_PRICE;
            listPrices[1] = SKI_PANT_PRICE;
            listPrices[2] = CARGO_SHORT_PRICE;
            listPrices[3] = PRINTED_TSHIRT_PRICE;

            // in begin for output 
            Console.WriteLine("Land Beginning Order System \n");
            Console.WriteLine("Enter the purchase quantity for each item displayed.\nYour receipt will display the totals for your purchase.\n");
            
            Console.Write("How many "+ listItems[0]+ " would you like at "+listPrices[0].ToString("c")+" each: ");
            int answerSkiJacket = int.Parse(Console.ReadLine());

            Console.Write("How many "+listItems[1]+" would you like at "+listPrices[1].ToString("c")+" each: ");
            int answerSkiPants = int.Parse(Console.ReadLine());
            
            Console.Write("How many "+listItems[2]+" would you like at "+listPrices[2].ToString("c")+" each: ");
            int answerCargoShorts = int.Parse(Console.ReadLine());

            Console.Write("How many "+listItems[3]+" would you like at "+listPrices[3].ToString("c")+" each: ");
            int answerPrintedTshirt = int.Parse(Console.ReadLine());

            //subotal for each items
            double totalSkiJacket = answerSkiJacket * listPrices[0];
            double totalSkiPant = answerSkiPants * listPrices[1];
            double totalCargoShort = answerCargoShorts * listPrices[2];
            double totalPrintedTshirt = answerPrintedTshirt * listPrices[3];
            double subTotal = totalSkiJacket + totalSkiPant + totalCargoShort + totalPrintedTshirt;
            double tax = subTotal * .08;
            double finalTotal = tax + subTotal;

            //show receipt output
            Console.WriteLine("***Lands Beginning***");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("");
            Console.WriteLine("\tITEM\t\tPRICE\t\t TOTAL");
            Console.WriteLine(answerSkiJacket+"   "+listItems[0]+"\t\tat "+listPrices[0].ToString("c")+"\t "+totalSkiJacket.ToString("c"));
            Console.WriteLine(answerSkiPants+"   "+listItems[1]+"\t\tat "+listPrices[1].ToString("c")+"\t "+totalSkiPant.ToString("c"));
            Console.WriteLine(answerCargoShorts+"   "+listItems[2]+"\tat "+listPrices[2].ToString("c")+"\t "+totalCargoShort.ToString("c"));
            Console.WriteLine(answerPrintedTshirt+"   "+listItems[3]+"\tat "+listPrices[3].ToString("c")+"\t "+totalPrintedTshirt.ToString("c"));
            Console.WriteLine("");
            Console.WriteLine("\t\t\t  Sub Total\t "+subTotal.ToString("c"));
            Console.WriteLine("\t\t\t\tTax\t "+tax.ToString("c"));
            Console.WriteLine("\t\t\tFinal Total\t "+finalTotal.ToString("c"));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Thank you for shopping with Lands Beginning\nHave a great day!!!");


        }
    }
}
