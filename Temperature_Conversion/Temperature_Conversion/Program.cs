/*
 Temperature converter:

Create a C# console application that converts temperatures between Celsius and Fahrenheit. Your program should provide the following functionality:Prompt the user to choose the temperature scale they want to convert from (Celsius or Fahrenheit).Prompt the user to enter the temperature value.Convert the temperature to the other scale.Display the converted temperature to the user.
Use the following formulas for conversion:
Celsius to Fahrenheit: F=59​C+32
Fahrenheit to Celsius: C=95​(F−32)
Your program should handle invalid inputs gracefully and allow the user to continue converting temperatures until they choose to exit.


Output:

Choose the temperature scale to convert from:
1. Celsius
2. Fahrenheit
Enter your choice: 1

Enter the temperature in Celsius: 25

25°C is equal to 77°F.

Do you want to convert another temperature? (Y/N): Y

Choose the temperature scale to convert from:
1. Celsius
2. Fahrenheit
Enter your choice: 2

Enter the temperature in Fahrenheit: 98.6

98.6°F is equal to 37°C.

Do you want to convert another temperature? (Y/N): N

Thank you for using the temperature converter!

 */

// Temperature Conversion Using If else if statements:

Console.WriteLine("Choose the temperature scale to convert from:\r\n1. Celsius\r\n2. Fahrenheit\r\nEnter your choice:");

var Scale_Choise = Convert.ToInt32(Console.ReadLine());

if (Scale_Choise == 1)
{
    Console.WriteLine("Enter a Temperature in Celcius Scale");
    var Temp_Celcius = Convert.ToInt32(Console.ReadLine());
    var Celcius_Conversion = (Temp_Celcius * 9/5 + 32);
    Console.WriteLine($"{Temp_Celcius}°C is equal to {Celcius_Conversion}°F.");
}else if (Scale_Choise == 2)
{
    Console.WriteLine("Enter a Temperature in Fahrenheit Scale");
    var Temp_Fahrenheit = Convert.ToDouble(Console.ReadLine());
    var Fahrenheit_Conversion = (Temp_Fahrenheit - 32) * 5/9;
    Console.WriteLine($"{Temp_Fahrenheit}°F is equal to {Fahrenheit_Conversion}°C.");
}
else
{
    Console.WriteLine("Please enter a valid scale value");
}


// Temperature Conversion Using Switch Case:

//Console.WriteLine("Choose the temperature scale to convert from:\r\n1. Celsius\r\n2. Fahrenheit\r\nEnter your choice:");

//var choise = Console.ReadLine();
//int convert = Convert.ToInt32(choise);

//switch (convert)
//{
//    case 1:
//    Console.WriteLine("Enter the temperature in Celsius");
//        var temp_celcius = Convert.ToDouble(Console.ReadLine());
//        var result = ((temp_celcius * 1.8) + 32);
//        Console.WriteLine($"{temp_celcius}°C is equal to {result}°F.");
//    break;

//    case 2:
//        Console.WriteLine("Enter the temperature in Fahrenheit");
//        var temp_Fahrenheit = Convert.ToDouble(Console.ReadLine());
//        var result1 = (temp_Fahrenheit - 32) * 5/9;
//        Console.WriteLine($"{temp_Fahrenheit}°F is equal to {result1}°C.");
//        break;

//        default: 
//        Console.WriteLine("Please enter a valid scale value");
//        break;
//}