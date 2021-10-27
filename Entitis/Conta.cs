using Atividade.Exceções.ContaBancaria.Entitis.Exception;
using System;
using System.Collections.Generic;


namespace Atividade.Exceções.ContaBancaria.Entitis
{
    class Conta
    {
        public int NumeroConta { get; set; }
        public string Cliente { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta()
        {

        }
        public Conta(int numeroconta, string cliente, double saldo, double limiteSaque)
        {
            NumeroConta = numeroconta;
            Cliente = cliente;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double qntDeposito)
        {
           Saldo += qntDeposito;
        }
        public void Saque(double qntSaque)
        {
            if (qntSaque > LimiteSaque)
            {
                //declarar a classe com as exceções(DominioException)
                throw new DomínioException("--A quantidade excede o limite de saque!--");
            }
            if (qntSaque > Saldo)
            {
                throw new DomínioException("--Saldo insuficiente!--");
            }
            Saldo -= qntSaque;
            
        }
    }
}
