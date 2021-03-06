﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramToInterface
{
    public abstract class Duck
    {
      protected FlyBehaviour flyBehaviour;
      protected QuackBehaviour quackBehaviour;

      public abstract string display();

      public string Swim()
      {
       return "All duck can swim!";
      }

      public string PerformFly()
      {
        return flyBehaviour.PerformFly();
      }

      public string PerformQuack()
      {
        return quackBehaviour.PerformQuack();
      }

      public void SetFlyBehaviour(FlyBehaviour flyBehaviour)
      {
        this.flyBehaviour = flyBehaviour;
      }

      public void SetQuackBehaviour(QuackBehaviour quackBehaviour)
      {
        this.quackBehaviour = quackBehaviour;
      }
    }
}
