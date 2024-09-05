using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Decimal para Binário");
            Console.WriteLine("2 - Binário para Decimal");
            Console.WriteLine("3 - Decimal para Hexadecimal");
            Console.WriteLine("4 - Hexadecimal para Decimal");
            Console.WriteLine("5 - Binário para Hexadecimal");
            Console.WriteLine("6 - Hexadecimal para Binário");
            Console.WriteLine("0 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    DecimalParaBinario();
                    break;
                case 2:
                    BinarioParaDecimal();
                    break;
                case 3:
                    DecimalParaHexadecimal();
                    break;
                case 4:
                    HexadecimalParaDecimal();
                    break;
                case 5:
                    BinarioParaHexadecimal();
                    break;
                case 6:
                    HexadecimalParaBinario();
                    break;
                case 0:
                    continuar = false;
                    Console.WriteLine("Encerrando o programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static void DecimalParaBinario()
        {
            Console.Write("Digite um número decimal: ");
            int numerodecimal = int.Parse(Console.ReadLine());
            string binario = Convert.ToString(numerodecimal, 2);
            Console.WriteLine($"Binário: {binario}");
        }

        static void BinarioParaDecimal()
        {
            Console.Write("Digite um número binário: ");
            string binario = Console.ReadLine();

            try
            {
                int numerodecimal = Convert.ToInt32(binario, 2);
                Console.WriteLine($"Decimal: {numerodecimal}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Número binário inválido.");
            }
        }

        static void DecimalParaHexadecimal()
        {
            Console.Write("Digite um número decimal: ");
            int numerodecimal = int.Parse(Console.ReadLine());
            string hexadecimal = Convert.ToString(numerodecimal, 16).ToUpper();
            Console.WriteLine($"Hexadecimal: {hexadecimal}");
        }

        static void HexadecimalParaDecimal()
        {
            Console.Write("Digite um número hexadecimal: ");
            string hexadecimal = Console.ReadLine();

            try
            {
                int numerodecimal = Convert.ToInt32(hexadecimal, 16);
                Console.WriteLine($"Decimal: {numerodecimal}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Número hexadecimal inválido.");
            }
        }

        static void BinarioParaHexadecimal()
        {
            Console.Write("Digite um número binário: ");
            string binario = Console.ReadLine();

            try
            {
                int numerodecimal = Convert.ToInt32(binario, 2);
                string hexadecimal = Convert.ToString(numerodecimal, 16).ToUpper();
                Console.WriteLine($"Hexadecimal: {hexadecimal}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Número binário inválido.");
            }
        }

        static void HexadecimalParaBinario()
        {
            Console.Write("Digite um número hexadecimal: ");
            string hexadecimal = Console.ReadLine();

            try
            {
                int numerodecimal = Convert.ToInt32(hexadecimal, 16);
                string binario = Convert.ToString(numerodecimal, 2);
                Console.WriteLine($"Binário: {binario}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Número hexadecimal inválido.");
            }
        }
    }

        
}
