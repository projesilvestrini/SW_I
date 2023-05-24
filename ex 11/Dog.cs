namespace exercicio1;
class Dog:Animal
{
    public override string Fala()
    {
        return base.Fala() + "au au";
    }
}