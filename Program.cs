// See https://aka.ms/new-console-template for more information

using Projeto_.Net_C_.Models;
/*
    PessoaFisica p = new PessoaFisica();

    p.Nome = "KARMA";
    p.Idade = 22;
    //p.Apresentar(); 

    para declarar uma cvarialvel primeiro o tipo depois o nome deposi o valor
    string codNome = "Karma";

    int inteiro = 15;

    double numeroReal = 25.5001;

    decimal valor = 1.500001M;

    bool condição = true;

    Console.WriteLine($"Valor de codNome: "+codNome);
    Console.WriteLine($"Valor de inteiro: "+inteiro);
    Console.WriteLine($"Valor de numeroRela: "+numeroReal);
    Console.WriteLine($"Valor de valor: "+valor);
    Console.WriteLine($"Valor de condição: "+condição);

    DateTime agora = DateTime.Now;

    Console.WriteLine($"Valor de agora é :"+agora);
    Console.WriteLine($"Valor de data de hoje: "+agora.ToString("dd/MM/yyyy"));
    Console.WriteLine($"Valor de data de hoje: "+agora.ToString("HH:mm"));

    //conversão de tipo /cast - casting/ evitar que o dado esteja forar do padrão 
        // tipo string para tipo inteiro:
        //a classe Convert trata valores Null como zero
        int a = Convert.ToInt32("152");
        //o metodo parse da classe int trata valores null com erro
        int b = int.Parse("321");

        // tipo inteiro para string
        // toda classe tem o metodo ToString() pois o mesmo é herança da class object que é "mãe" de todos as class
        string sA = a.ToString();

        // existem tambem converções implicitas para tipos que suportam outros tipo como double ou long suporta uma valor int
        double dA= a;
        // mas o contrario não é valido pós um int não suparta um double ou um long
        // nesses casos é necessário a conversão manual como com as string tomando o mesmo cuidado para a variavel int suportar o valor do double
        int c = Convert.ToInt32(dA);

        // como contornar erro de conversão e o cod não parar
            // o metodo tryParce tenta converter mas caso de valor invalido ele não convert
            //Console.WriteLine(int.TryParse(codNome, out a ));
        // assim como na matematica o codigo prioriza a ordem das operações
*/
// operadores condionais 
/*
int quantidadeEmEstoque = 10;

int quantidadeCompra = 0;

bool validarVenda =quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine("Estoque: " + quantidadeEmEstoque);
Console.WriteLine("Compra: " + quantidadeCompra);
Console.WriteLine("Venda Aprovada: "+validarVenda);
if(quantidadeCompra == 0)
{
    Console.WriteLine("Venda Invalida");
}
else if (validarVenda)
{
    Console.WriteLine("Compra realizada com sucesso");
    quantidadeEmEstoque -= quantidadeCompra;
    Console.WriteLine("Estoque: " + quantidadeEmEstoque);
}
else
{
    Console.WriteLine("Desculpe, quantidade do produto em estoque não atende a necessidade:");
    Console.WriteLine("Estoque: " + quantidadeEmEstoque);
}
*/

/*
//Condicionais if else elseif e switch case
Console.WriteLine("Digite uma letra");
String letra = Console.ReadLine();

if(
    letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u"
)
{
    Console.WriteLine(letra+" é Vogal");
}
else
{
    Console.WriteLine(letra+" não é Vogal");
}

switch(letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
         Console.WriteLine(letra+" é Vogal");
         break;
    
    default:
        Console.WriteLine(letra+" não é Vogal");
        break;

}


*/
/*
//Operadores matematicos
Calculadora calculadora = new Calculadora();

Console.WriteLine("Soma");
calculadora.Somar(25.8, 39.85);
Console.WriteLine("Subitração");
calculadora.Subtrair(98.68, 89.35);
Console.WriteLine("Multiplicação");
calculadora.Multiplicar(8.6595, 3.98568);
Console.WriteLine("Divisão");
calculadora.Dividir(9.356, 3.356);
Console.WriteLine("Potência");
calculadora.Potencia(9, 3);
Console.WriteLine("Seno");
calculadora.Seno(30);
Console.WriteLine("Coseno");
calculadora.Coseno(45);
Console.WriteLine("Tangete");
calculadora.Tangente(60);
Console.WriteLine("Raiz Quadrada");
calculadora.RaizQuadrada(60);
*/

// Tabuada lações de repetição
/*
double numero = 10;
int cont = 0;
*/
/*
//    Console.WriteLine($"{numero} x 1 = {numero*1}");
//for recebe 3 parametros o instacia de uma valor a condição de permanencia e a incrementação ou decre
for(int cont = 0; cont <= 5; cont++)
{
    Console.WriteLine($"{numero} x {cont} = {numero*cont}");
}
*/
/*
//o while tem como parametro apenas a condição de permaneencia apesar de ser mais simples que o for
// tem que tomar cuidado para que essa condição seja existente 
while (cont <= 5)
{
    Console.WriteLine($"{numero} x {cont} = {numero * cont}");

    if (numero * cont == 30)
    {
        break;
    }
    cont++;
}
*/
/*
//O DO WHILE diferente do whille e do for ele garante pelo menos uma execução do bloco de codigo
int soma = 0, numeroA = 0;
do
{
    Console.WriteLine("Digite uma numero :");
    numeroA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("0 para sair");
    soma += numeroA;
} while (numeroA != 0);

Console.WriteLine($"Soma de todos os numeros : {soma}");
*/

// menu estrutural 

string op = null;
bool menu = true;

while (menu)
{
    Console.Clear();
    Console.WriteLine("Digite uma das opções: ");
    Console.WriteLine("1 - cadastro");
    Console.WriteLine("2 - excluir" );
    Console.WriteLine("3 - Buscar");
    Console.WriteLine("4 - sair");
    
    op = Console.ReadLine();

    switch(op)
    {
        case "1":
            Console.WriteLine("1 - cadastro");
            break;
        case "2":
            Console.WriteLine("2 - excluir" );
            break;
        case "3":
            Console.WriteLine("3 - Buscar");
            break;
        case "4":
            Console.WriteLine("4 - sair");
            menu = false;
            //Environment.Exit();
            break;
        default:
            Console.WriteLine("OP invalido");
            break;
    }
}