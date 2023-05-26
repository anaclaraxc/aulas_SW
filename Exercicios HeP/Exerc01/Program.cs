namespace EXERC1;
class Program
{
   static void Main(string[] args)
   {
    Animal a = new Animal();
    Cao b = new Cao();
    Gato c = new Gato();
    Homem d = new Homem();

    Console.WriteLine("Cao: " + b.Fala());
    Console.WriteLine("Gato: " + c.Fala());
    Console.WriteLine("Homem: " + d.Fala());
   }
} 
