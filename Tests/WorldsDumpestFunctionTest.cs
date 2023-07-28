using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Tests
{
    public static class WorldsDumpestFunctionTest
    {
        //Naming Convention - ClassName,MethodName,Exception_Name
        public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnsString()
        {
            try
            {
                //Triple A
                //Arrange - Go get your variable, whatever you need, classes,functions
                int num = 0;
                WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

                //Act - Execute this function
                string result = worldsDumbest.ReturnPikachuIfZero(num);


                //Assert - Whatever ever is returns is it what you want.
                Console.WriteLine(result);

                if(result == "Pikachu")
                {
                    Console.WriteLine("Test Passed: WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnsString");
                }
                else
                {
                    Console.WriteLine("Test Failed: WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnsString");
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
    
}
