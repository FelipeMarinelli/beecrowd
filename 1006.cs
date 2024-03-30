using System; 

class URI {

    static void Main(string[] args) { 

        double a = Convert.ToDouble(Console.ReadLine());
        
        double b = Convert.ToDouble(Console.ReadLine());
        
        double c = Convert.ToDouble(Console.ReadLine());
        
        a = a * 2;
        
        b = b * 3;
        
        c = c * 5;
        
        double d = a + b + c;
        
        double media = d / 10;
        
        Console.WriteLine($"MEDIA = {media:f1}");

    }

}