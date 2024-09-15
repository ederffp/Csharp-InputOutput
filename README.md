<h1> Código exemplo 02</h1>

```csharp using System;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um numero para N1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um numero para N2: ");
            int n2 = int.Parse(Console.ReadLine());

            int result = Soma(n1, n2);

            string output = $"Resultado da soma entre {n1} e {n2} é: {result}";

            Console.WriteLine(output);

        }
        public static int Soma(int a, int b) { return a + b; }

    }
}
```
<h2><b><i> Analise: </i></b></h2>

- Começamos o programa invocando a diretiva <u><b>using System</b></u>
- Criamos um <u><b>namespace Projeto02</b></u> que tem como por objetivo organizar classes de forma lógica dentro do código.</u>
- Criamos uma classe chamada <u><b>class Program</b></u>, somente possivel através da declaração da diretiva <u><b>using System.</b></u> 
- Declaramos o nosso metodo Main em <u><b>Static void Main(string[] args)</b></u> que pertence a classe.
- Chamamos a classe <u><b>Console</b></u> com seu metodo <u><b>WriteLine()</b></u> que tem como findalide fazer a saida de dados na tela.


<p> Ok, tudo isso ja sabemos, mas o que há de novo ? </p>

<p> No código acima observamos 2 exemplos de declaração de variaveis de entrada de tipos primitivos de dados em C# </p>

```csharp
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());

    int result = Soma(n1, n2);
```

<p> Acima declaramos 2 variaveis de tipo int, percebe-se que na declaração estamos atribuindo a cada variavel<u><b>(int n1, int n2)</b></u>metodo <u><b>int.Parse()</b></u> que tem como finalidade converter o valor por padrão que é de tipo String para tipo Integer atraves da classe <u><b>Console</b></u> e do metodo <u><b>ReadLine();</b></u></p> 

```csharp
    int result = Soma(n1, n2);
```

<p> Acima novamente declaramos uma variavel de tipo Integer,<u><b>int result</b></u> que é um tipo primitivo em C# mas, com um detalhe interessante. Percebe-se que não houve necessidade como anteriormente em fazer a conversão do tipo de dado, ja que, anteriormente, já convertemos na entrada de <u><b>n1</b></u> e <u><b>n2.</b></u>
<p>Outro detalhe importante acima é que invocamos a função <u><b>Soma(n1, n2)</b></u> e passamos como parametro a essa chamada de função o valor das 2 variaveis antes declaradas.

```csharp
    string output = $"Resultado da soma entre {n1} e {n2} é: {result}";
```

<p> Novamente observamos outras coisas interessantes no codigo C#. Acima vemos a declaração de uma variavel de tipo String - <u><b>String output</b></u> - que tem como finalidade armazenar o valor uma cadeia de caracteres com valores de tipo inteiros como <u>{n1}</u> e <u>{n2}</u> com recurso de interpolação, junto com o resultado processado pela função <u><b>Soma()</b></u> na qual seu valor processado será <u><b>{result}.</b></u></p> 

```csharp
    Console.WriteLine(output);
```
<p> A classe <u><b>Console</b></u> invaca o metodo <u><b>WriteLine()</b></u> que imprimi o valor que esta na variavel <u><b>output.</b></u>

```csharp
    public static int Soma(int a, int b) 
    { 
        return a + b; }
    }
```
<p>Por fim criamos uma função publica e estatic de tipo inteiro que recebe 2 valores de tipo inteiro como argumentos para ser processados pela função. <u><i><b>return a + b </b></i></u> 

<h2> Conclusão </h2>

<p> Embora seja um exemplo pequeno ele conta conta com mecanismos da linguagem C# importante.
Exemplo claro são as chamadas da função, tal como conversão do tipo de dado usando metoodo Parse() do tipo string para tipo inteiro. Outro detalhe importante é que o codigo C# é bem conciso e claro, sem muitos elementos que dificultam a leitura do código, certamente uma das caracteristicas que mais chamou-me a atenção na linguagem C# em detrimento de Java, que é por padrão uma linguagem demasiadamente verbosa.
</p>
