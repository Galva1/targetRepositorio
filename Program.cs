
var escolha = Console.ReadLine();
if(escolha == "1"){
    Questao01();

}else if(escolha == "2")
{
    Questao02();
}else if(escolha == "3")
{
    Questao03();
}else if(escolha == "4")
{
    Questao04();
}

static void Questao04(){
    return;
    //Por ser uma questão sem retorno, irei realizar comentada.
    // a) 1, 3, 5, 7, 9 -> Variável anterior somado +2.
    // b) 2, 4, 8, 16, 32, 64, 128 -> Variável anterior multiplicada * 2.
    // c) 0, 1, 4, 9, 16, 25, 36, 49 -> Quadrado dos números inteiros.
    // d) 4, 16, 36, 64, 100 -> Números pares elevado ao quadrado.
    // e) 1, 1, 2, 3, 5, 8, 13 -> Fibonacci.
}

static void Questao03()
{
    int indice = 12;
    int soma = 0;
    int k = 1;
    while(k<indice)
    {
        k = k + 1;
        soma = soma + k;
    }
    System.Console.WriteLine(soma);
}



static void Questao02()
{
    System.Console.WriteLine("Escreva uma palavra");
    string texto = Console.ReadLine();
    int contador = 0;
    bool existeLetraA = false;
    for (int index = 0; index < texto.Length; index++)
    {
        char letra = texto[index];
        if (letra == 'a' || letra == 'A')
        {
            existeLetraA = true;
            contador++;
            
        }
    }
    if (existeLetraA)
    {
        Console.WriteLine($"O caractere 'a' apareceu {contador} vezes.");    
    }else
    {
        Console.WriteLine($"Não existe letra 'a' na frase.");    
    }
}

static void Questao01()
{
    int n1 = 0;
    int n2 = 1;
    bool informouNumeroCorreto;
    bool numeroApareceu;
    int contador;
    do
    {
        Console.WriteLine("Informe um número inteiro maior que 0");
        string numero = System.Console.ReadLine();
        informouNumeroCorreto =  int.TryParse(numero, out contador);

        if (!informouNumeroCorreto)
        {
            Console.WriteLine("Entrada inválida, por favor, informar um número inteiro.");
        }
        else if(contador <= 0)
        {
            Console.WriteLine("O número não pode ser 0. Tente novamente!");
            informouNumeroCorreto = false;
        }
        
    } while (!informouNumeroCorreto);

    for (int index = 0; index < contador; index++)
    {
        //A questão só pede para retornar a mensagem informando se pertence ou não, por isso deixei comentado a linha que iria exibir a sequencia de Fibonacci
        //Console.Write($"{n1} {n2} ");
        int resultado = n1 + n2;
        n1 = resultado;
        n2 = n1 + n2;
        if(resultado == contador || n2 == contador)
        {
            numeroApareceu = true;
            System.Console.WriteLine("O número informado pertence a sequência de Fibonacci.");
            break;
        }
    }
}