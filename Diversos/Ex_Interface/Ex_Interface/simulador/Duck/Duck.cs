using System;

namespace Interfaces
{
  public class Duck:Swim,Quack
  {
    public void quack()
    {
      Console.WriteLine("quackkk!!!!");
    }
    public void swim()
    {
      Console.WriteLine("Nadar!!!");
    }
    public virtual void display()
    {
      Console.WriteLine("Pato genérico");
      quack();
      swim();
    }
  }
}