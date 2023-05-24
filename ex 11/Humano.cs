﻿namespace exercicio1;
class Humano:Animal
{
        public override string Fala()
    {
        return base.Fala() + "olá";
    }
}