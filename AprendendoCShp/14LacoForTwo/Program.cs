using System;

namespace _14LacoForTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14 Laço for two!");
            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            //********
            //*********
            //**********

           for(int linha = 0; linha < 10; linha++)
            {
                for(int coluna = 0; coluna < 10; coluna++)
                {
                    if(coluna > linha)
                    {
                        break;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
