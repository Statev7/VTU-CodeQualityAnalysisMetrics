﻿namespace _03_RefusedBequest
{
    using System;

    public class ProblematicCode
    {
        public abstract class Bird
        {
            public abstract void Eating();

            public abstract void Fly();
        }

        public class Parrot : Bird
        {
            public override void Eating() => Console.WriteLine("Eating...");

            public override void Fly() => Console.WriteLine("Flying...");
        }

        public class Penguin : Bird
        {
            public override void Eating() => Console.WriteLine("Eating.");

            public override void Fly() => throw new NotImplementedException();
        }
    }
}
