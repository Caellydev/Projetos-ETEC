using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===Bem-vindo ao sistema de consulta de carros===");
        
        bool continuar = true;
        while (continuar)
        {
            MostrarCategorias();
            int categoria = LerOpcao(0, 3);
            
            if (categoria == 0)
            {
                continuar = false;
                continue;
            }
            
            switch (categoria)
            {
                case 1:
                    ConsultarHatch();
                    break;
                case 2:
                    ConsultarSedan();
                    break;
                case 3:
                    ConsultarSUV();
                    break;
            }
            
            if (continuar)
            {
                Console.Write("\nDeseja consultar outro modelo? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();
                continuar = resposta == "S";
            }
        }
        
        Console.WriteLine("\nObrigado por utilizar nosso sistema. Volte sempre!");
    }
    
    static void MostrarCategorias()
    {
        Console.WriteLine("\nCategorias de Carros Disponíveis:");
        Console.WriteLine("1 - Hatch");
        Console.WriteLine("2 - Sedan");
        Console.WriteLine("3 - SUV");
        Console.WriteLine("0 - Sair do programa");
        Console.Write("Escolha uma categoria: ");
    }
    
    static void ConsultarHatch()
    {
        Console.WriteLine("\nModelos Hatch Disponíveis:");
        Console.WriteLine("1 - Volkswagen Gol 1.0 - R$ 65.990");
        Console.WriteLine("2 - Fiat Argo 1.3 - R$ 72.500");
        Console.WriteLine("3 - Chevrolet Onix 1.0 Turbo - R$ 85.300");
        Console.Write("Escolha um modelo: ");
        
        int modelo = LerOpcao(1, 3);
        
        switch (modelo)
        {
            case 1:
                Console.WriteLine("\nVolkswagen Gol 1.0");
                Console.WriteLine("Preço: R$ 65.990");
                Console.WriteLine("Motor: 1.0 Flex");
                Console.WriteLine("Consumo: 14,5 km/l (gasolina) / 10,3 km/l (álcool)");
                break;
            case 2:
                Console.WriteLine("\nFiat Argo 1.3");
                Console.WriteLine("Preço: R$ 72.500");
                Console.WriteLine("Motor: 1.3 Flex");
                Console.WriteLine("Consumo: 13,8 km/l (gasolina) / 9,7 km/l (álcool)");
                break;
            case 3:
                Console.WriteLine("\nChevrolet Onix 1.0 Turbo");
                Console.WriteLine("Preço: R$ 85.300");
                Console.WriteLine("Motor: 1.0 Turbo Flex");
                Console.WriteLine("Consumo: 15,2 km/l (gasolina) / 10,8 km/l (álcool)");
                break;
        }
    }
    
    static void ConsultarSedan()
    {
        Console.WriteLine("\nModelos Sedan Disponíveis:");
        Console.WriteLine("1 - Volkswagen Virtus 1.6 - R$ 98.200");
        Console.WriteLine("2 - Honda City 1.5 - R$ 112.900");
        Console.WriteLine("3 - Toyota Corolla 2.0 - R$ 145.000");
        Console.Write("Escolha um modelo: ");
        
        int modelo = LerOpcao(1, 3);
        
        switch (modelo)
        {
            case 1:
                Console.WriteLine("\nVolkswagen Virtus 1.6");
                Console.WriteLine("Preço: R$ 98.200");
                Console.WriteLine("Motor: 1.6 Flex");
                Console.WriteLine("Consumo: 13,2 km/l (gasolina) / 9,4 km/l (álcool)");
                break;
            case 2:
                Console.WriteLine("\nHonda City 1.5");
                Console.WriteLine("Preço: R$ 112.900");
                Console.WriteLine("Motor: 1.5 Flex");
                Console.WriteLine("Consumo: 14,6 km/l (gasolina) / 10,5 km/l (álcool)");
                break;
            case 3:
                Console.WriteLine("\nToyota Corolla 2.0");
                Console.WriteLine("Preço: R$ 145.000");
                Console.WriteLine("Motor: 2.0 Flex");
                Console.WriteLine("Consumo: 12,8 km/l (gasolina) / 9,1 km/l (álcool)");
                break;
        }
    }
    
    static void ConsultarSUV()
    {
        Console.WriteLine("\nModelos SUV Disponíveis:");
        Console.WriteLine("1 - Jeep Renegade 1.8 - R$ 125.500");
        Console.WriteLine("2 - Hyundai Creta 1.6 - R$ 132.800");
        Console.WriteLine("3 - Volkswagen T-Cross 1.4 - R$ 142.300");
        Console.Write("Escolha um modelo: ");
        
        int modelo = LerOpcao(1, 3);
        
        switch (modelo)
        {
            case 1:
                Console.WriteLine("\nJeep Renegade 1.8");
                Console.WriteLine("Preço: R$ 125.500");
                Console.WriteLine("Motor: 1.8 Flex");
                Console.WriteLine("Consumo: 11,5 km/l (gasolina) / 8,3 km/l (álcool)");
                break;
            case 2:
                Console.WriteLine("\nHyundai Creta 1.6");
                Console.WriteLine("Preço: R$ 132.800");
                Console.WriteLine("Motor: 1.6 Flex");
                Console.WriteLine("Consumo: 12,2 km/l (gasolina) / 8,7 km/l (álcool)");
                break;
            case 3:
                Console.WriteLine("\nVolkswagen T-Cross 1.4");
                Console.WriteLine("Preço: R$ 142.300");
                Console.WriteLine("Motor: 1.4 Turbo Flex");
                Console.WriteLine("Consumo: 13,8 km/l (gasolina) / 9,9 km/l (álcool)");
                break;
        }
    }
    
    static int LerOpcao(int min, int max)
    {
        int opcao;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out opcao) && opcao >= min && opcao <= max)
            {
                return opcao;
            }
            Console.Write($"Opção inválida. Digite um número entre {min} e {max}: ");
        }
    }
}