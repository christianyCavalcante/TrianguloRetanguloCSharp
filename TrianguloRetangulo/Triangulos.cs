using System;

namespace TrianguloRetangulo{
  class Triangulos:ITriangulos{

    private double catetoA;
    private double catetoB;
    private double hipotenusa;

    public Triangulos(){
      this.catetoA = 0; 
      this.catetoB = 0; 
      this.hipotenusa = 0;
    }

    public Triangulos(double a, double b){
      this.catetoA = a; 
      this.catetoB = b; 
      this.hipotenusa = calcularHipotenusa();
      
    }
    
    public Triangulos(double a, double b, double h){
      catetoA = a; 
      catetoB = b; 
      hipotenusa = h;
    }

    public double CatetoA { 
      get => catetoA; 
      set => catetoA = value; 
    }

    public double CatetoB { 
      get => catetoB; 
      set => catetoB = value; 
    }

    public double Hipotenusa { 
      get => hipotenusa; 
      set => hipotenusa = value; 
    }

    public bool validarTrianguloRetangulo(){
      return Math.Round(Math.Pow(CatetoA,2) + Math.Pow(CatetoB,2))== Math.Round(Math.Pow(Hipotenusa,2));
    }

    public double calculaPerimetro(){
      return CatetoA + CatetoB + Hipotenusa;
    }

    public double calculaArea(){
      if(!validarTrianguloRetangulo()){
        Console.WriteLine ("Esta função calcula área apenas para triângulo retângulo!");
        
        return 0;
      }
      return (CatetoA * CatetoB) / 2;
    }

    public double calcularHipotenusa(){
      double somaDoQuadradoDosCatetos = Math.Pow(CatetoA,2) + Math.Pow(CatetoB,2);
      return Math.Sqrt(somaDoQuadradoDosCatetos);
    }

    public static Triangulos compara(Triangulos t1, Triangulos t2){
      if(t1.calculaArea() > t2.calculaArea()){
        return t1;
      }else{
        return t2;
      }
    }

  }
}