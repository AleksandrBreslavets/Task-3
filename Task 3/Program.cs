using Task_3;

static class Constants
{
    public const decimal UsdExchangeRate = 37.01M;
    public const decimal EurExchangeRate = 39.18M;
}

class Program
{
    static void Main()
    {
        int convertionType;
        bool isDecimal = false;
        bool isInt = false;
        decimal sumToConvert;
        decimal result;
        Convertor currencyConvertor=new Convertor(Constants.EurExchangeRate, Constants.UsdExchangeRate);
        
        Console.WriteLine("Choose type of convertion:\n");
        Console.WriteLine("Type 1 to convert UAH TO EUR.");
        Console.WriteLine("Type 2 to convert UAH TO USD.");
        Console.WriteLine("Type 3 to convert USD TO UAH.");
        Console.WriteLine("Type 4 to convert EUR TO UAH.");
        Console.WriteLine("Type 5 to convert EUR TO USD.");
        Console.WriteLine("Type 6 to convert USD TO EUR.");

        do
        {
            string input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("You didn`t choose type of convertion!");
            }
            else
            {
                try
                {
                    convertionType = int.Parse(input);
                    Console.WriteLine("Enter a sum to convert:");

                    do
                    {
                        input = Console.ReadLine();
                        if (input == "")
                        {
                            Console.WriteLine("You didn`t entered sum to convert!");
                        }
                        else
                        {
                            try
                            {
                                sumToConvert = decimal.Parse(input);

                                switch (convertionType)
                                {
                                    case 1:
                                        result = currencyConvertor.UahToEur(sumToConvert);
                                        Console.WriteLine("Converted amount: {0:F2} EUR", result);
                                        break;
                                    case 2:
                                        result = currencyConvertor.UahToUsd(sumToConvert);
                                        Console.WriteLine("Converted amount: {0:F2} USD", result);
                                        break;
                                    case 3:
                                        result = currencyConvertor.UsdToUah(sumToConvert);
                                        Console.WriteLine("Converted amount: {0:F2} UAH", result); ;
                                        break;
                                    case 4:
                                        result = currencyConvertor.EurToUah(sumToConvert);
                                        Console.WriteLine("Converted amount: {0:F2} UAH", result);
                                        break;
                                    case 5:
                                        result = currencyConvertor.EurToUsd(sumToConvert);
                                        Console.WriteLine("Converted amount: {0:F2} USD", result);
                                        break;
                                    case 6:
                                        result = currencyConvertor.UsdToEur(sumToConvert);
                                        Console.WriteLine("Converted amount: {0:F2} EUR", result);
                                        break;
                                    default:
                                        Console.WriteLine("Invalid conversion type. Please select a valid option.");
                                        break;
                                }

                                isDecimal = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("You entered symbols that don`t represent sum to convert.");
                            }
                        }
                    }
                    while (!isDecimal);

                    isInt = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("You entered symbols that don`t represent type of convertation.");
                }
            }
        } 
        while (!isInt);
    }
}