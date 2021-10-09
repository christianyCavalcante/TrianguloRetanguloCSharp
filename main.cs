using System;
using TrianguloRetangulo;

class Program {
  public static void Main (string[] args) {

    Console.WriteLine ("");
    //Exemplo 1 : Utilizando construtor padrão e métodos modificadores
    Triangulos exemplo1 = new Triangulos();
    exemplo1.CatetoA = 8;
    exemplo1.CatetoB = 15;
    exemplo1.Hipotenusa = 17;
    
    Console.WriteLine ("Exemplo 1:");
    Console.WriteLine ("Perímetro: " + exemplo1.calculaPerimetro());
    Console.WriteLine ("Área: " + exemplo1.calculaArea());
    Console.WriteLine ("Hipotenusa calculada:" + exemplo1.calcularHipotenusa());

    Console.WriteLine ("");
    //Exemplo 2 : Utilizando construtor apenas com os catetos
    Triangulos exemplo2 = new Triangulos(5, 12); 
    Console.WriteLine ("Exemplo 2:");
    Console.WriteLine ("Perímetro:" + exemplo2.calculaPerimetro());
    Console.WriteLine ("Área: " + exemplo2.calculaArea());
    Console.WriteLine ("Hipotenusa calculada:" + exemplo2.calcularHipotenusa() );

    Console.WriteLine ("");
    //Exemplo 3 : Utilizando construtor com catetos e hipotenusa
    Triangulos exemplo3 = new Triangulos(36, 27, 45);  
    Console.WriteLine ("Exemplo 3:");
    Console.WriteLine ("Perímetro:" + exemplo3.calculaPerimetro());
    Console.WriteLine ("Área: " + exemplo3.calculaArea());
    Console.WriteLine ("Hipotenusa calculada:" + exemplo3.calcularHipotenusa());
  
    Console.WriteLine ("");
    //Exemplo 4 : Testando validação e correção da hipotenusa
    Triangulos exemplo4 = new Triangulos(7, 3, 20);
    Console.WriteLine ("Exemplo 4:");
    Console.WriteLine ("Área: " + exemplo4.calculaArea());
    Console.WriteLine ("Hipotenusa :" + exemplo4.Hipotenusa);  
    
    exemplo4.Hipotenusa = exemplo4.calcularHipotenusa();

    Console.WriteLine ("Perímetro:" + exemplo4.calculaPerimetro());
    Console.WriteLine ("Área: " + exemplo4.calculaArea());
    Console.WriteLine ("Hipotenusa :" + exemplo4.Hipotenusa);
    
    Console.WriteLine ("");
    //Exemplo 5: Comparando Triangulos
    Console.WriteLine ("Exemplo 5:");
    Console.WriteLine ("Área 1: " + exemplo1.calculaArea());
    Console.WriteLine ("Área 2: " + exemplo2.calculaArea());
    Console.WriteLine ("Maior Área: " + Triangulos.compara(exemplo1, exemplo2).calculaArea() );
    
  }
}