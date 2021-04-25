﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // açúcar sintático 
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            {

                lista.Adicionar(new ContaCorrente(345, 23462));
                lista.Adicionar(new ContaCorrente(363, 22451));
                lista.Adicionar(new ContaCorrente(735, 23552));
                lista.Adicionar(new ContaCorrente(363, 22451));
                lista.Adicionar(new ContaCorrente(735, 23552));
                lista.Adicionar(new ContaCorrente(363, 22451));
                lista.Adicionar(new ContaCorrente(363, 22451));
                lista.Adicionar(new ContaCorrente(735, 23552));
                lista.Adicionar(new ContaCorrente(735, 23552));
            };

   

            Console.ReadLine();
        }
    }
}
