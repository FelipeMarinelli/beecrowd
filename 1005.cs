using System; 

class URI {

    static void Main(string[] args) { 

        double a = Convert.ToDouble(Console.ReadLine());
        
        double b = Convert.ToDouble(Console.ReadLine());
        
        a = a * 3.5;
        
        b = b * 7.5;
        
        double c = a + b;
        
        double media = c / 11;
        
        Console.WriteLine($"MEDIA = {media:f5}");

    }

}