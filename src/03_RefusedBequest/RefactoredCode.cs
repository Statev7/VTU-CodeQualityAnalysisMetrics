﻿namespace _03_RefusedBequest
{
    using System;

    public class RefactoredCode
    {
        public interface IFlyable
        {
            void Fly();
        }

        public abstract class Bird
        {
            public abstract void Eating();
        }

        public class Parrot : Bird, IFlyable
        {
            public override void Eating() => Console.WriteLine("Eating...");

            public void Fly() => Console.WriteLine("Flying...");
        }

        public class Penguin : Bird
        {
            public override void Eating() => Console.WriteLine("Eating.");
        }
    }
}
