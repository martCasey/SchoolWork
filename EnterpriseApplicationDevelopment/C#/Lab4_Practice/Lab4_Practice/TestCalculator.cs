/*X-Number: X00119025
Date: 16/10/2017*/
//using System;

//namespace Lab4_Practice
//{                                                                                                       //My attempt at TestCalculator
//    //class TestCalculator
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        double number1, number2;
//    //        Calculator calc = new Calculator();


//    //        try                                                                                     //try catch block                                                         
//    //        {
//    //            Console.Write("Please input the value of the first number:");
//    //            number1 = Double.Parse(Console.ReadLine());                                         //parsing input to match floating point format (e.g 4.3)
//    //            Console.Write("Please input the value of the first number:");
//    //            number2 = Double.Parse(Console.ReadLine());

//    //            Console.WriteLine("The result of the two numbers you entered when the first is divided by the second is: "
//    //                            + Calculator.Divide((float)number1, (float)number2));               //casting variables to float after parsing process
//    //        }
//    //        catch (FormatException fe)
//    //        {
//    //            Console.WriteLine("The following error explains the issue that has occured"
//    //                            + "\n" + fe);                                                       //what the issue is
//    //        }
//    //        Console.ReadLine();                                                                     //pause program so results can be read
//    //    }
//    //}

//    class TestCalculator
//    {                                                                                                   //My fixup using lectuerer's solution
//        static void Main(string[] args)
//        {
//            try
//            {
//                double num1= 0, num2= 0;                                                            //take in inputs.  These need to be assigned a value before they can be used in any methods
//                bool valid = true;                                                                  //Used to ensure a value is valid
//                do
//                {
//                    try
//                    {
//                        Console.WriteLine("Enter the value for number 1:");
//                        num1 = Double.Parse(Console.ReadLine());                                 //Allows for the value to be inputed and then parsed to a floating type number
//                        valid = true;                                                               //can only be true if the parsing is successful in the try block
//                    }
//                    catch (FormatException)
//                    {
//                        valid = false;                                                              //When a exception is caught, then the parsing is not successful, therefore valid is made false
//                    }
//                    catch (OverflowException)                                                       //Can have more than 1 catch block in a try catch
//                    {
//                        valid = false;
//                    }
//                } while (!valid);                                                                   //The try catch blocks will be repeated until valid is true

//                do
//                {
//                    try
//                    {
//                        Console.WriteLine("Enter the value for number 2:");
//                        num2 = Double.Parse(Console.ReadLine());
//                        valid = true;
//                    }
//                    catch (Exception)
//                    {
//                        valid = false;                                                              //Catches both format and overflow exceptions
//                    }
//                } while (!valid);

//                Console.WriteLine("When number 1 is divided by number 2 the answer is: " + Calculator.Divide(num1, num2));
//            }
//            catch(ArgumentException ae)                                                             //Catches argument exeption generated from Divide method whe you try and divide by 0
//            {
//                Console.WriteLine(ae.Message);
//            }
//            Console.ReadLine();                                                                     //pause program so results can be read
//        }
//    }
//}
