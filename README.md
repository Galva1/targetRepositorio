# Etapa Técnica
Repositório para teste de estágio na empresa TARGET

Todas as questões foram respondidas na linguagem de conforto que foi o **C#**.

# Questão 01
Utilizei um do while para fazer a verificação do **input** (não era obrigatório, mas acabei realizando), em seguida entramos em um **for** com a contagem do número que foi digitado, utilizando a lógica de Fibonacci, assim que é verificado que o número digitado faz parte do Fibonacci,é retornado a verificação e a aplicação é encerrada.

# Questão 02
Utilizei um boleano para indicar que há letra A na aplicação, ele faz um laço verificando toda a string e usando o index do laço para separar cada letra da string na váriavel letra, assim que uma delas é a letra 'a' ou 'A' (poderia ter usado um upperCase), ele valida o boleano e aumenta o contador, ao fim se o boleano for verdadeiro ele indica quantos 'a' apareceu, caso não, informando que não existe.

# Questão 03
Fiz o cálculo:
```
    int indice = 12;
    int soma = 0;
    int k = 1;
    while(k<indice)
    {
        k = k + 1;
        soma = soma + k;
    }
    System.Console.WriteLine(soma);
```

Retornando: **77**

# Questão 04
Por ser uma questão sem retorno, irei realizar comentada.

a- 1, 3, 5, 7, 9 -> Variável anterior somado +2.

b- 2, 4, 8, 16, 32, 64, 128 -> Variável anterior multiplicada * 2.

c- 0, 1, 4, 9, 16, 25, 36, 49 -> Quadrado dos números inteiros.

d- 4, 16, 36, 64, 100 -> Números pares elevado ao quadrado.

e- 1, 1, 2, 3, 5, 8, 13 -> Fibonacci.

# Questão 05
Se puder utilizar de elementos reais como: calor da lampada, é simples:
Você mantém um dos interruptores ligados, gerando calor na lâmpada por bastante tempo, depois desse periodo você o desliga e liga um segundo interruptor:

Caso a lâmpada esteja acesa, o interruptor que você ligou é o que controla ela (1/3)
Caso esteja apagada e quente é o interruptor ligado anteriormente (1/3)
Caso esteja fria e apagada é o que você não manuseou (1/3)

É só ligar o outro que sobrou e ir novamente a outra sala: 
Se estiver apagada e quente é o que você ligou na primeira vez. (2/3)
Se estiver ligada é o que você ligou agora. (2/3)

E por fim o último interruptor é o da sala que você não visitou.

**Metodo 2:** 

Caso não possa utilizar de elementos como o calor da lâmpada a tentativa pode não ser certeira.
Ligando dois interruptores e entrando na 1 sala:
Se estiver apagado é o interruptor restante, é só repetir essa ação mais uma vez e encontrar (3/3)
Caso esteja aceso, você sai da sala apaga os dois e acende o terceiro e entra na outra sala:
Se estiver aceso é o que você acendeu (1/3) e terá que chutar os outros dois 50%
Caso esteja apagado é um dos dois interruptores que você acendeu anteriormente, sobrando esse interruptor que foi acendido agora para a sala que você não acendeu (1/3), sobrando 50% de chance de chutar o outro.
