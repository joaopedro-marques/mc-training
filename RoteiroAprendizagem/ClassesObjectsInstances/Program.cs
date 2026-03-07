public class Carro
{   
    //Não se deve utilizar campos públicos abaixo.
    // public string modelo;
    // public int ano;
    //Sempre utilizar propriedades, que permitem validação:
    public int ano { get; set; }
    public string modelo { get; set; }

    //Sempre utilize private como padrão e depois vá subindo os acessos para as demais classes de acordo com o necessário.
    //Exemplo: private int meuAtributo; // Somente acesso a esta classe.
    // protected int meuAtributo; // Acesso a esta classe e suas subclasses.
    // public int meuAtributo; // Acesso a todas as classes.
    public Carro(string modelo, int ano)
    {
        this.modelo = modelo;
        this.ano = ano;
    }
    public Carro() {}

    public void Acelerar()
    {
        Console.WriteLine("Vruum!");
    }

    public static void Parar()
    {
        Console.WriteLine("Parou!");
    }
}

//Erro de COmpilação ocorreu por causa do modificador  de acesso que não tinha, logo estava privado.
// Ao corrigir todos os modificadores de acesso o programa rodou com sucesso.

//o COmpilador não aceitou acessar métodos privados. Por isso não rodou e não deu o rresultado esperado.

//Deu erro de compilação, o código sequer rodou para apresentar o erro.

//Inserindo public nos métodos e campos.

class Program
{
    static void Main()
    {   
        //Não é uma boa prática mais inicializar sem construtor como abaixo. Caso raro deve-se utilizar o
        //Construtor padrão como abaixo.
        Carro meuCarro = new Carro();
        meuCarro.modelo = "Fusca";
        meuCarro.ano = 1970;
        meuCarro.Acelerar();
        Console.WriteLine($"Modelo: {meuCarro.modelo}, Ano: {meuCarro.ano}");

        //Sempre instancialize com new
        Carro queridoCarro = new Carro("Duster", 2015);

        //Sempre instancialize o objeto e nunca a classe
        Console.WriteLine("Meu carro: " + meuCarro.modelo);
        Console.WriteLine("Querido carro: " + queridoCarro.modelo);

        //Modo errado:
        // Console.WriteLine("Meu carro: " + Carro.modelo ;

        //Métodos estaticos só podem ser acessador por métodos estáticos.
        //O objeto não tem acesso ao método estático abaixo
        Carro.Parar();
        // queridoCarro.Parar();

        //Criando contas
        Conta conta1 = new Conta("joão", 15000m);
        Conta conta2 = new Conta("Alice", 40000m);

        conta1.Depositar(200);
        conta2.Depositar(1500);

        conta1.ExibirDados();
        conta2.ExibirDados();

        conta1.Sacar(1500);
        conta2.Sacar(25000);

        conta1.ExibirDados();
        conta2.ExibirDados();

        conta1.Transferir(conta2, 2000);

        conta1.ExibirDados();
        conta2.ExibirDados();

        //Revisando pré e pós incremento
        int a = 2, b = 3, c = 5;

        // int x = a++ + ++b * c--; //22
        // Console.WriteLine(x);
        // int y = --c + b++ - a--; //5
        // Console.WriteLine(y);
        // int z = a++ + ++a + a++ + a; //9
        // Console.WriteLine(z);







    }
}