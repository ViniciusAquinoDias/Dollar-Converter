double dolarToReal = 4.73;

Console.Write("conversion Dólar to Real\n\n");

Console.Write("How many dólar banknotes do you have? ");
double banknotes = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"So you have R$:{dolarToReal * banknotes} in conversion");