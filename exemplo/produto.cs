namespace exemplo;
class Produto
{
    public string? Nome {get;set;}


    public double Preco {get;set;}

    public void Mostradados(){
        Console.WriteLine("nome: " + this.Nome);
        Console.WriteLine("preco: " + this.Preco);
    }
    public void AlteraNome(string Nome){
        this.Nome = Nome;
    }
    public void AlteraPreco(double preco){
        this.Preco = preco;
    }
}
