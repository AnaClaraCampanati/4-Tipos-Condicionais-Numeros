//# Condicionais maior número
//-Faça um programa que leia três números, verifique (usando if e else), e mostre o maior deles.

Console.WriteLine("Digite o primeiro número");
int primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
int segundoNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro número");
int terceiroNumero = Convert.ToInt32(Console.ReadLine());

int maiorNumero = 0;

if (primeiroNumero>maiorNumero) 
{
    maiorNumero = primeiroNumero;
}

if (segundoNumero>maiorNumero)
{
    maiorNumero = segundoNumero;
}

if (terceiroNumero>maiorNumero)
{
    maiorNumero = terceiroNumero;
}

Console.WriteLine("Maior número: " + maiorNumero);

