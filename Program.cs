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

            string[,] itemsNames = new string[4,1];
            itemsNames[0,0] = SKI_JACKET;
            itemsNames[1,0] = SKI_PANT;
            itemsNames[2,0] = CARGO_SHORT;
            itemsNames[3,0] = PRINTED_TSHIRT;

            double[,] itemsNprices = new double [4,3];
            itemsNprices[0,0] = SKI_JACKET_PRICE;
            itemsNprices[1,0] = SKI_PANT_PRICE;
            itemsNprices[2,0] = CARGO_SHORT_PRICE;
            itemsNprices[3,0] = PRINTED_TSHIRT_PRICE;

            // in begin for output 
            Console.WriteLine("Land Beginning Order System \n");
            Console.WriteLine("Enter the purchase quantity for each item displayed.\nYour receipt will display the totals for your purchase.\n");
            
            Console.Write("How many "+ itemsNames[0,0]+ " would you like at "+itemsNprices[0,0].ToString("c")+" each: ");
            double answerSkiJacket = double.Parse(Console.ReadLine());

            Console.Write("How many "+itemsNames[1,0]+" would you like at "+itemsNprices[1,0].ToString("c")+" each: ");
            double answerSkiPants = double.Parse(Console.ReadLine());
            
            Console.Write("How many "+itemsNames[2,0]+" would you like at "+itemsNprices[2,0].ToString("c")+" each: ");
            double answerCargoShorts = double.Parse(Console.ReadLine());

            Console.Write("How many "+itemsNames[3,0]+" would you like at "+itemsNprices[3,0].ToString("c")+" each: ");
            double answerPrintedTshirt = double.Parse(Console.ReadLine());

             // users answer how much items
            itemsNprices[0,1] = answerSkiJacket;
            itemsNprices[1,1] = answerSkiPants;
            itemsNprices[2,1] = answerCargoShorts;
            itemsNprices[3,1] = answerPrintedTshirt;
            // total price Ski Jacket to Printed T Shirted
            itemsNprices[0,2] = itemsNprices[0,0] * itemsNprices[0,1];
            itemsNprices[1,2] = itemsNprices[1,0] * itemsNprices[1,1];
            itemsNprices[2,2] = itemsNprices[2,0] * itemsNprices[2,1];
            itemsNprices[3,2] = itemsNprices[3,0] * itemsNprices[3,1];

            //subotal for each items
            double subTotal = itemsNprices[0,2] + itemsNprices[1,2] + itemsNprices[2,2] + itemsNprices[3,2];
            double tax = subTotal * .08;
            double finalTotal = tax + subTotal;

            //show receipt output
            Console.WriteLine("");
            Console.WriteLine("***Lands Beginning***");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("");
            Console.WriteLine("\tITEM\t\tPRICE\t\t TOTAL");
            Console.WriteLine(itemsNprices[0,1]+"   "+itemsNames[0,0]+"\t\tat "+itemsNprices[0,0].ToString("c")+"\t "+itemsNprices[0,2].ToString("c"));
            Console.WriteLine(itemsNprices[1,1]+"   "+itemsNames[1,0]+"\t\tat "+itemsNprices[1,0].ToString("c")+"\t "+itemsNprices[1,2].ToString("c"));
            Console.WriteLine(itemsNprices[2,1]+"   "+itemsNames[2,0]+"\tat "+itemsNprices[2,0].ToString("c")+"\t "+itemsNprices[2,2].ToString("c"));
            Console.WriteLine(itemsNprices[3,1]+"   "+itemsNames[3,0]+"\tat "+itemsNprices[3,0].ToString("c")+"\t "+itemsNprices[3,2].ToString("c"));
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
