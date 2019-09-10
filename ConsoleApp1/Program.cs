using FunctionToTest;
using System;


namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            var ff = new ForecastingFunction();
            //Test 1;
            try {
                // Multiplier is zero
                var result = ff.Forecast(-11, 11);  //expect: Exception!
                Console.WriteLine("Test failed!");
            }
            catch (Exception ex) {
                Console.WriteLine("Test passed!");

            }
            //Test 2;
            // Multiplier is 2, x is 25, y is 5, result
            try {
                ff.Multiplier = 2;
                var result = ff.Forecast(25, 5);
                Console.WriteLine("Test failed!");
            }
            catch (Exception ex) {
                Console.WriteLine("Test passed!");
            }
            {
                ff.Multiplier = 2;
                var result = ff.Forecast(2, 2);
                if (result == 24) {
                    Console.WriteLine("Test passed!");
                }
                else {
                    Console.WriteLine("Test failed!");
                }
            }

        }
    }
}

        
    

