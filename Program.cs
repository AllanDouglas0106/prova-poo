
/*
//QUESTÃO 1

int variavel = 5;
float variavel2 = 5.8f;
string texto = "BOLO";
bool verdadefalsa = true;

Console.WriteLine(variavel2);
Console.WriteLine(variavel);
Console.WriteLine(texto);
Console.WriteLine(verdadefalsa);

QUESTÃO 2

Console.WriteLine("digite um numero");
 int v = int.Parse(Console.ReadLine());

Console.WriteLine("digite outro numero");
 int v2 = int.Parse(Console.ReadLine());

 int soma = v + v2;
 int subtração = v - v2;
 int mult = v * v2;
 int divi = v / v2;

 Console.WriteLine($" soma = {soma}");
 Console.WriteLine($" subtração = {subtração}");
 Console.WriteLine($" mult  = {mult}");
 Console.WriteLine($" divi = {divi}");


 QUESTÃO 3

Console.WriteLine("ola, qual seu nome?");
 string nome = (Console.ReadLine());

 Console.WriteLine(" Qual sua idade?");
  int idade = int.Parse(Console.ReadLine()); 

  Console.WriteLine($"Ola, {nome}, você tem {idade} anos");

QUESTÃO 4

Console.WriteLine("digite um numero");
int n = int.Parse(Console.ReadLine());

if (n > 0) {
  Console.WriteLine($"O numero {n} é positivo");
}

else if (n < 0){
  Console.WriteLine($"o numero {n} é negativo");
}

else {
  Console.WriteLine($"O numero {n} é zero");
}


QUESTÃO 5
for (int i = 1; i <= 10; i++)
{
  Console.WriteLine(i);
}


6
for(int i = 1; i < 11; i++) {
    Console.WriteLine(i);
    }

 Console.WriteLine("Digite sua idade");
 int idade = int.Parse(Console.ReadLine());

 if(idade >= 18){
    Console.WriteLine("Você é maior de idade e está apto(a) a dirigir e votar");
 } 
 else{
    Console.WriteLine("você não é maior de idade, não está apto para dirigir ou votar");
 }

 
QUESTÃO 7.
class Program
{ 
 static void Main(string[] args)
 {

  Console.WriteLine("digite a primeira nota");
  float nota1 = float.Parse(Console.ReadLine());

  Console.WriteLine("digite a segunda nota");
  float nota2 = float.Parse(Console.ReadLine());

  Console.WriteLine("digite a terceira nota");
  float nota3 = float.Parse(Console.ReadLine());

 float media = CalcularMedia( nota1,  nota2,  nota3);
//calcular media das 3 notas

 //exibe o resultado
 Console.WriteLine($"a media das notas é {media:F2}");


static float CalcularMedia(float nota1, float nota2, float nota3)
    {
        return (nota1 + nota2 + nota3) / 3;
    }

 }
}





QUESTÃO 8
 Console.WriteLine("Digite 3 numeros:");
 int num1 = int.Parse(Console.ReadLine());
 int num2 = int.Parse(Console.ReadLine());
 int num3 = int.Parse(Console.ReadLine());

  if(num1 > num2){
    if(num1 > num3){
    Console.Write($"{num1} é o maior numero\n");
  }
  }

 if(num2 > num3){
    if(num2 > num1){
    Console.Write($"{num2} é o maior numero\n");
  }
  }

 if(num3 > num1){
    if(num3 > num2){
    Console.Write($"{num3} é o maior numero\n");
  }
  }
///////////////////////////////////////////////////////////
 if(num1 < num2){
    if(num1 < num3){
    Console.Write($"{num1} é o menor numero\n");
  }
  }

  if(num2 < num3){
    if(num2 < num1){
    Console.Write($"{num2} é o menor numero\n");
  }
  }

  if(num3 < num1){
    if(num3 < num2){
    Console.Write($"{num3} é o menor numero\n");
  }
  }

 //QUESTÃO *9.

 Console.WriteLine("digite o numero secreto");
 int soma = 0;

 while(true)
 {
  int num = int.Parse(Console.ReadLine());

  if(num == 0){
    Console.WriteLine("Você descobriu o numero secreto.");
    break;
  }
  else
  {
    Console.WriteLine("escreva outro numero");
    soma += num;
  }
    
    
 }   
  
  Console.WriteLine($"soma dos numeros: {soma}");
    


//QUESTÃO10

Console.WriteLine("digite o valor em reais");
double reais = double.Parse(Console.ReadLine());

Console.WriteLine("digite ataxa de cambio");
double taxa= double.Parse(Console.ReadLine());


double convertido = reais / taxa;

Console.WriteLine($"o valor convertido é {convertido}");

 

 //QUESTÃO11

 class Program
{ 
 static void Main(string[] args)
 {

 Console.WriteLine("digite um numero para calcular o fatorial");
 int n = int.Parse(Console.ReadLine());
 
 if ( n< 0)
 {
  Console.WriteLine("Não é possivel calcular o fatorial de um numero negativo");
 }
 else{
  int resultado = CalcularFatorial(n);
  Console.WriteLine($"o fatorial de {n} é {resultado}");
 }
 static int CalcularFatorial(int n)
{
  if (n == 0 || n == 1)
  {
    return 1;
  }
  else
  {
    return n * CalcularFatorial(n = 1);
  }
}
 }
}


//QUESTÃO12

 Console.WriteLine("Digite um numero.");
 int n = int.Parse(Console.ReadLine());

 while(n <= 0 )
  {
    Console.WriteLine("Digite um numero positivo");
     n = int.Parse(Console.ReadLine());
  }

 int a = 0;
 int b = 1;
 Console.WriteLine($"Sequencia de fibonacci ate {n}:");

 while(a <= n)
 {
     Console.WriteLine(a);
     int aux = a;
     a = b;
     b = aux + b; 
 }


 //QUESTÃO13

 Console.WriteLine("escreva os nomes");

 string nomes =Console.ReadLine();
 string[] nomesArray = nomes.Split(' ');
 Array.Sort(nomesArray);
 foreach (string nome in nomesArray)
 {
     Console.WriteLine(nome);

 }
*/