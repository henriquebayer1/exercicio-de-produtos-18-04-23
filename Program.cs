// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.






static void cadastroDoProduto(){


string nomeP1 = "Banana - Unidade";
float precoP1 = 3.99f;
bool promocaoP1 = false;


string nomeP2 = "Abacaxi - Unidade";
float precoP2 = 6.99f;
bool promocaoP2 = true;


string nomeP3 = "Manga - Unidade";
float precoP3 = 3.99f;
bool promocaoP3 = false;


string nomeP4 = "Maca - Unidade";
float precoP4 = 3.99f;
bool promocaoP4 = true;


string nomeP5 = "Pera - Unidade";
float precoP5 = 5.99f;
bool promocaoP5 = false;


string nomeP6 = "Uva - Caixa";
float precoP6 = 3.99f;
bool promocaoP6 = true;


string nomeP7 = "Nectarina - Unidade";
float precoP7 = 3.99f;
bool promocaoP7 = false;


string nomeP8 = "Ameixa - Kg";
float precoP8 = 12.99f;
bool promocaoP8 = true;


string nomeP9 = "Mamao - Unidade";
float precoP9 = 3.99f;
bool promocaoP9 = false;


string nomeP10 = "Limao - Unidade";
float precoP10 = 1.99f;
bool promocaoP10 = true;




Console.WriteLine(@$"Cadastre o seu produto para ver suas informacoes:

ATENCAO!!!! Coloque o respectivo numero do pruduto requerido para ver suas informacoes.

");

Console.WriteLine($"Digite o numero do produto para prosseguir");
Console.WriteLine($"");

int numeroProduto = int.Parse(Console.ReadLine());


switch (numeroProduto)
{
    case 1:
    Console.WriteLine($"");
    Console.WriteLine($"");
    
    Console.WriteLine(@$"{nomeP1}");
    Console.WriteLine($"{precoP1}");
    if(promocaoP1 = true)
    {  Console.WriteLine($"O produto esta em promocao");}
    else {Console.WriteLine($"O produto nao esta em promocao.");
    }
    break;
    case 2:
    Console.WriteLine($"");
    Console.WriteLine($"");
    
    Console.WriteLine(@$"{nomeP2}");
    Console.WriteLine($"{precoP2}");
    if(promocaoP2 = true)
    {  Console.WriteLine($"O produto esta em promocao");}
    else {Console.WriteLine($"O produto nao esta em promocao.");
    }
    break;
    case 3:
    Console.WriteLine($"");
    Console.WriteLine($"");
    
    Console.WriteLine(@$"{nomeP3}");
    Console.WriteLine($"{precoP3}");
    if(promocaoP3 = true)
    {  Console.WriteLine($"O produto esta em promocao");}
    else {Console.WriteLine($"O produto nao esta em promocao.");
    }
    break;
    case 4:
    Console.WriteLine($"");
    Console.WriteLine($"");
    
    Console.WriteLine(@$"{nomeP4}");
    Console.WriteLine($"{precoP4}");
    if(promocaoP4 = true)
    {  Console.WriteLine($"O produto esta em promocao");}
    else {Console.WriteLine($"O produto nao esta em promocao.");
    }
    break;
    case 5:
    Console.WriteLine($"");
    Console.WriteLine($"");
    
    Console.WriteLine(@$"{nomeP5}");
    Console.WriteLine($"{precoP5}");
    if(promocaoP5 = true)
    {  Console.WriteLine($"O produto esta em promocao");}
    else {Console.WriteLine($"O produto nao esta em promocao.");
    }
    break;
    case 6:
    Console.WriteLine($"");
    Console.WriteLine($"");
    
    Console.WriteLine(@$"{nomeP6}");
    Console.WriteLine($"{precoP6}");
    if(promocaoP6 = true)
    {  Console.WriteLine($"O produto esta em promocao");}
    else {Console.WriteLine($"O produto nao esta em promocao.");
    }
    break;
    case 7:
    Console.WriteLine($"");
    Console.WriteLine($"");
    
    Console.WriteLine(@$"{nomeP7}");
    Console.WriteLine($"{precoP7}");
    if(promocaoP7 = true)
    {  Console.WriteLine($"O produto esta em promocao");}
    else {Console.WriteLine($"O produto nao esta em promocao.");
    }
    break;
    case 8:
    Console.WriteLine($"");
    Console.WriteLine($"");
    
    Console.WriteLine(@$"{nomeP8}");
    Console.WriteLine($"{precoP8}");
    if(promocaoP8 = true)
    {  Console.WriteLine($"O produto esta em promocao");}
    else {Console.WriteLine($"O produto nao esta em promocao.");
    }
    break;
    case 9:
    Console.WriteLine($"");
    Console.WriteLine($"");
    
    Console.WriteLine(@$"{nomeP9}");
    Console.WriteLine($"{precoP9}");
    if(promocaoP9 = true)
    {  Console.WriteLine($"O produto esta em promocao");}
    else {Console.WriteLine($"O produto nao esta em promocao.");
    }
    break;
    case 10:
    Console.WriteLine($"");
    Console.WriteLine($"");
    
    Console.WriteLine(@$"{nomeP10}");
    Console.WriteLine($"{precoP10}");
    if(promocaoP10 = true)
    {  Console.WriteLine($"O produto esta em promocao");}
    else {Console.WriteLine($"O produto nao esta em promocao.");
    }
    break;
    default:
        break;
}


}




static void listagemDeProdutos(){

Console.WriteLine(@$"Bem vindo ao sistema de listagem de produtos do mercado!


Confira os produtos listados a seguir:

        ------------------------------------------
        | 1 - Banana                             |
        | 2 - Abacaxi                            |
        | 3 - Manga                              |
        | 4 - Maca                               |
        | 5 - Pera                               |
        | 6 - Uva                                |
        | 7 - Nectarina                          |    
        | 8 - Ameixa                             |
        | 9 - Mamao                              |
        | 10 - Limao                             | 
        ------------------------------------------


   Voltar para o menu inicial - '0'    
   Ir para o cadastro de produtos - '1' 
");

Console.WriteLine($"Digite uma das opcoes para prosseguir");
char opcaoMenuLista = char.Parse(Console.ReadLine());

switch (opcaoMenuLista)
{
    case '1':
    cadastroDoProduto();
        break;
        case '0':
        Console.WriteLine(@$"

Selecione uma das opcoes abaixo para continuar:

        ------------------------------------------
        | 1 - Listagem de produtos               |
        | 2 - Cadastrar produtos                 |
        ------------------------------------------
");

char opcaoMenu = char.Parse(Console.ReadLine());

switch (opcaoMenu)
{
    case '1':
    listagemDeProdutos();
        break;
        case '2':
        cadastroDoProduto();
        break;
    default:
    do
    {
    Console.WriteLine($"Nenhuma opcao valida selecionada, recomece o sistema e selecione uma opcao valida para continuar.");

    Console.WriteLine(@$"
Selecione uma das opcoes abaixo para continuar:

        ------------------------------------------
        | 1 - Listagem de produtos               |
        | 2 - Cadastrar produtos                 |
        ------------------------------------------
        ");

opcaoMenu = char.Parse(Console.ReadLine());

switch (opcaoMenu)
{
    case '1':
    listagemDeProdutos();
        break;
        case '2':
        cadastroDoProduto();
        break;
        }

    } while (opcaoMenu != '1' && opcaoMenu != '2');
     break;
}
break;
    default:
    do
    {Console.WriteLine(@$"
Voltar para o menu inicial - '0'    
Ir para o cadastro de produtos - '1' ");

Console.WriteLine($"");

Console.WriteLine($"Digite uma das opcoes para prosseguir");
opcaoMenuLista = char.Parse(Console.ReadLine());

switch (opcaoMenuLista)
{
    case '0':
    Console.WriteLine(@$"Seja bem vindo ao sistema do mercado.

Por Favor veja a listagem de produtos antes de cadastrar o produto 
para ver suas informacoes!!!


");

Console.WriteLine(@$"

Selecione uma das opcoes abaixo para continuar:

        ------------------------------------------
        | 1 - Listagem de produtos               |
        | 2 - Cadastrar produtos                 |
        ------------------------------------------
");

opcaoMenu = char.Parse(Console.ReadLine());

switch (opcaoMenu)
{
    case '1':
    listagemDeProdutos();
        break;
    case '2':
        cadastroDoProduto();
        break;
    default:
    do
    {
    Console.WriteLine($"Nenhuma opcao valida selecionada, recomece o sistema e selecione uma opcao valida para continuar.");

    Console.WriteLine(@$"
Selecione uma das opcoes abaixo para continuar:

        ------------------------------------------
        | 1 - Listagem de produtos               |
        | 2 - Cadastrar produtos                 |
        ------------------------------------------
        ");

opcaoMenu = char.Parse(Console.ReadLine());

switch (opcaoMenu)
{
    case '1':
    listagemDeProdutos();
        break;
        case '2':
        cadastroDoProduto();
        break;
        }

    } while (opcaoMenu != '1' && opcaoMenu != '2');
     break;
}
        break;
        case '1':
        cadastroDoProduto();
break;
    default:
        break;
}


   } 
    
while (opcaoMenuLista != '0' &&  opcaoMenuLista != '1');
 break;
}


}


Console.WriteLine(@$"Seja bem vindo ao sistema do mercado.

Por Favor veja a listagem de produtos antes de cadastrar o produto 
para ver suas informacoes!!!


");

Console.WriteLine(@$"

Selecione uma das opcoes abaixo para continuar:

        ------------------------------------------
        | 1 - Listagem de produtos               |
        | 2 - Cadastrar produtos                 |
        ------------------------------------------
");

char opcaoMenu = char.Parse(Console.ReadLine());

switch (opcaoMenu)
{
    case '1':
    listagemDeProdutos();
        break;
    case '2':
        cadastroDoProduto();
        break;
    default:
    do
    {
    Console.WriteLine($"Nenhuma opcao valida selecionada, recomece o sistema e selecione uma opcao valida para continuar.");

    Console.WriteLine(@$"
Selecione uma das opcoes abaixo para continuar:

        ------------------------------------------
        | 1 - Listagem de produtos               |
        | 2 - Cadastrar produtos                 |
        ------------------------------------------
        ");

opcaoMenu = char.Parse(Console.ReadLine());

switch (opcaoMenu)
{
    case '1':
    listagemDeProdutos();
        break;
        case '2':
        cadastroDoProduto();
        break;
        }

    } while (opcaoMenu != '1' && opcaoMenu != '2');
     break;
}
