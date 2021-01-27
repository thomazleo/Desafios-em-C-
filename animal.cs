using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
  String a;
  String b;
  String c;
  a = Console.ReadLine();
  b = Console.ReadLine();
  c = Console.ReadLine();


    if (a == "vertebrado") {
      if (b == "ave") {
        if (c == "carnivoro") {
          Console.WriteLine("aguia");
        } else if (c == "onivoro") {
          Console.WriteLine("pomba");
        }
      } else if (b == "mamifero") {
        if (c == "onivoro") {
          Console.WriteLine("homem");
        } else if (c == "herbivoro") {
          Console.WriteLine("vaca");
        }
      }
    }

    if (a == "invertebrado") {
      if (b == "inseto") {
        if (c == "hematofago") {
          Console.WriteLine("pulga");
        } else if (c == "herbivoro") {
          Console.WriteLine("lagarta");
        }
      } else if (b == "anelideo") {
        if (c == "hematofago") {
          Console.WriteLine("sanguessuga");
        } else if (c == "onivoro") {
          Console.WriteLine("minhoca");
        }
      }
    }
  }
}