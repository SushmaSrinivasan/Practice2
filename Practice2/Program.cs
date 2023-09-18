using System;
using System.Diagnostics;

bool isActive = true;
while (isActive)
{
    Console.WriteLine("Main menu:");
    Console.WriteLine("1.Youth or retired");
    Console.WriteLine("2.Price for the party");
    Console.WriteLine("3.Repeat ten times");
    Console.WriteLine("4.The third word");
    Console.WriteLine("0. Exit menu");

    Console.WriteLine("Enter any one option from the main menu: ");
    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            checkAge();
            break;
        case "2":
            calculatePrice();
            break;
        case "3":
            RepeatTenTimes();
            break;
        case "4":
            ThirdWord();
            break;
        case "0":
            isActive = false;
            break;

        default:
            Console.WriteLine("Enter the valid option from main menu:");
            break;

    }
    static void checkAge()
    {
        Console.WriteLine("Enter the age of a person:");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            int price = 0;
            if (age < 5 || age > 100)
            {
                price = 0;
                Console.WriteLine("Free for babies and seniors");
            }
            else if (age < 20)
            {
                price = 80;
                Console.WriteLine($"Youth price:{price}kr.");
            }
            else if (age > 64)
            {
                price = 90;
                Console.WriteLine($"Pensioner's price:{price}kr.");
            }
            else
            {
                price = 120;
                Console.WriteLine($"Standard price:{price}kr.");
            }
        }
        else
        {
            Console.WriteLine("Invalid age, try again.");
        }
    }


    static void calculatePrice()
    {
        Console.WriteLine("Enter the no of persons going for the party:");
        if (int.TryParse(Console.ReadLine(), out int noOfPeople) && noOfPeople > 0)
        {
            int totalCost = 0;
            int price = 0;
            for (int i = 0; i < noOfPeople; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.WriteLine("Enter the age of a person:");

                    if (age < 5 || age > 100)
                    {
                        price = 0;
                    }
                    else if (age < 20)
                    {
                        price = 80;
                    }
                    else if (age < 64)
                    {
                        price = 90;
                    }
                    else
                    {
                        price = 120;
                    }
                    totalCost += price;
                }
                else
                {
                    Console.WriteLine("Invalid age, enter correct age.");
                    i--;
                }

                Console.WriteLine("Total number of people attended the party:", noOfPeople);
                Console.WriteLine("The total cost for the party is:", totalCost);

            }
        }
    }




    static void RepeatTenTimes()
    {
        Console.WriteLine("Enter any text:");
        string input = Console.ReadLine();
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{i}.{input},");
        }
    }

    static void ThirdWord()
    {
        Console.WriteLine("Enter a sentence with minimum 3 words:");
        string input = Console.ReadLine();

        string[] words = input.Split(" ");
        if (words.Length >= 3)
        {
            string thirdWord = words[2];
            Console.WriteLine($"The third word in the sentence is:{thirdWord}");
        }
        else
        {
            Console.WriteLine("The sentence should have minimum 3 words");
        }

    }

}
