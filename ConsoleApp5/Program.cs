using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o valor da anuidade do curso: R$ ");
        double valorAnuidade = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor da matrícula: R$ ");
        double valorMatricula = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor dos materiais: R$ ");
        double valorMateriais = Convert.ToDouble(Console.ReadLine());

        // Calcula o valor total a ser parcelado (anuidade menos matrícula menos materiais)
        double valorParcelado = valorAnuidade + valorMatricula - valorMateriais;

        Console.Write("Informe em quantas parcelas deseja pagar: ");
        int numParcelas = Convert.ToInt32(Console.ReadLine());

        // Calcula o valor de cada parcela (valor total parcelado dividido pelo número de parcelas)
        double valorParcela = valorParcelado / numParcelas;

        // Exibe o valor da primeira parcela (matrícula + materiais + primeira parcela da anuidade)
        Console.WriteLine($"Valor da primeira parcela: R$ {valorMatricula + valorMateriais + valorParcela}");

        // Exibe o valor das demais parcelas (restante da anuidade dividido pelo número de parcelas - 1)
        Console.WriteLine($"Valor das demais parcelas: R$ {valorParcela}");
    Console.ReadKey();
    }
    
}
