﻿using System.Security.Cryptography; Console.Clear();
Random random = new Random();
int NumeroSecreto = RandomNumberGenerator.GetInt32(1, 101);
int tentativas =0;
bool acertou = false;

Console.WriteLine ("Bem-vindo ao jogo de adivinhação");
Console.WriteLine ("Tente adivinhar o numero secreto de 1 a 100");
while (tentativas <7&& !acertou)
{
    Console.WriteLine ("Digite seu palpite:");
    string input = Console.ReadLine()!;
    int palpite = Convert.ToInt32(input);
    
   
    if (palpite == NumeroSecreto)
    
    {
Console.WriteLine("Parabens! você acertou o numero secreto!");
acertou = true;
    }

    else
{
tentativas++;
if (Math.Abs(palpite-NumeroSecreto)<=3)
{Console.WriteLine ("Está pelando!");}

else if (Math.Abs(palpite- NumeroSecreto)<=10 && (palpite- NumeroSecreto) >=4)
{Console.WriteLine("Está quente!");}

else if (Math.Abs(palpite- NumeroSecreto)<=30)
{Console.WriteLine("Está conjelando!");}

else
{
    Console.WriteLine("Está frio!");}

if (palpite < NumeroSecreto)
{Console.WriteLine("O numero secreto é maior.");}
else
{Console.WriteLine("O numero secreto é menor.");}}}

if (!acertou)
{
    Console.WriteLine("Vocã perdeu! suas tentativas acabaram.");
}
Console.WriteLine("O numero secreto era:"+NumeroSecreto);
Console.WriteLine("O jogo acabou! Obrigado por jogar.");
