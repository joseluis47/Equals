using System;
using System.Collections.Generic;
using System.IO;
using Usuarios.Entities;

namespace Usuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\User\source\repos\Usuarios\usuarios.txt";
            HashSet<Acesso> acessos = new HashSet<Acesso>();

            try
            {
                using(FileStream fs = new FileStream(caminho,FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            Acesso acesso = new Acesso(sr.ReadLine());
                            acessos.Add(acesso);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            Console.WriteLine($"Tivemos acesso de {acessos.Count} Usuários diferentes");
        }
    }
}
