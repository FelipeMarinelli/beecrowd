using System; 

class URI {

    static void Main(string[] args) { 
        
    Console.WriteLine("Insira seu Numero da Empresa:");
    
    int numero = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Insira Horas trabalhadas e salario por hora");
    
    int a = Int32.Parse(Console.ReadLine());
    
    double b = Convert.ToDouble(Console.ReadLine());
    
    double salario = a * b;
    
    Console.WriteLine($"NUMBER = {numero}");
    
    Console.WriteLine($"SALARY = U$ {salario:f2}");

    }

}