namespace exercicio1;
class Program
{
    static void Main(string[] args)
    {
    Humano jonyy = new Humano();
    Dog Daniel = new Dog();
    Kat corno = new Gato();

    Console.WriteLine(jonyy.Fala());
    Console.WriteLine(Daniel.Fala());
    Console.WriteLine(corno.Fala());
    }   
        
}