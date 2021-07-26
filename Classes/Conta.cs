using System;

namespace DigitalInnovationOne
{
    public class Conta
    {
        private TipoConta TipoConta {get; set;} // atributos nenhum usuario pode alterar na apliçao.(encapisulamento)
        private double Saldo {get ; set;} // atributos dever ser sempre privado, nenhum usuario pode alterar na apliçao.
        private double Credito {get ; set;}
        private string Nome {get;set;}

        // Abaixo segue um metodo construtor, Ele é um metodo que é chamado no momento
        // que é criado o objeto
        // Quem que ter o nome da Classe sempre(Conta)
        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
           //esse this fala que só ira alterar nessa instancia e nao nas outras.
            this.TipoConta = tipoConta; 
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }// metodo sacar
        public bool sacar(double valorSaque)
        {
            //validar saldo suficiente
            if (this.Saldo - valorSaque < (this.Credito *-1)){
                Console.WriteLine("Saldo insuficiente");
                return false;// para a excusao e retorna quem chamou esse metodo
                // se for usar as funçoes de console deve add using System no inicio
            }
                // tiver saldo segue abaixo
                this.Saldo -= valorSaque; // aqui pego o valor saldo e diminuo do saque
                Console.WriteLine("saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
                // esse 0 e 1 formata a string onde o 0 fica Nome e 1 o saldo
                return true;
        }
                // metodo depositar
                public void Depositar(double valorDeposito)
                { this.Saldo += valorDeposito;
                Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
                }

                public void Transferir(double valorTransferencia, Conta contaDestino)
                {
                    if (this.sacar(valorTransferencia)){
                        contaDestino.Depositar(valorTransferencia);
                    }
                }
                public override string ToString() // Override (sobreescreve toString da Calsse mãe)
		{
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito;
			return retorno;
		}
	}
}
    
    
