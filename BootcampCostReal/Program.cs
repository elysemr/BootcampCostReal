using System;

namespace BootcampCost
{
    class Program
    {
        static void Main(string[] args)
        {
            var BootcampTuition = 15500.0;
            int BootcampLength = 65;
            var PricePerDay = BootcampTuition / BootcampLength; //calculate the number in a var then employ

            Console.WriteLine($"Maximum Boot Camp Costs ${BootcampTuition / BootcampLength} per day.");
            Console.WriteLine($"Maximum Boot Camp costs ${PricePerDay} per day."); //to employ additional var
            //easier to round a var than an expression, why create third variable instead of doing it inside writeline

        }
    }
}
