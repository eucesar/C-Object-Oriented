using bytebank.Contas;
using bytebank.Titular;

/*
Cliente cliente = new Cliente();
cliente.nome = "André Silva";
cliente.cpf = "123456789";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-X";
conta.numero_agencia = 15;
conta.saldo = 100;

Console.WriteLine("Titular = " + conta.titular.nome);
Console.WriteLine("Cpf = " + conta.titular.cpf);
Console.WriteLine("Profissão = " + conta.titular.profissao);
Console.WriteLine("Nº Conta = " + conta.conta);
Console.WriteLine("Saldo = " + conta.saldo);
Console.WriteLine("Nº Agência = " + conta.numero_agencia);

ContaCorrente conta2 = new ContaCorrente();
//junto os dois new 
conta2.titular = new Cliente();
conta2.titular.nome = "José Souza";
conta2.titular.profissao = "Tester";
conta2.titular.cpf = "987654321";
conta2.conta = "9999-X";
conta2.numero_agencia = 18;
conta2.saldo = 500;

Console.WriteLine(conta2.titular.nome);
*/

/*
//crio um novo OBJETO = que chama variaveis ou qq coisa da class / repartição
ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva"; //uso o PONTO depois do nome da varivel que eu acabei de definir para chamar a var q está na class
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);
*/

/*
contaDoAndre.Depositar(100);

Console.WriteLine("Saldo da conta do André pós-depósito = " + contaDoAndre.saldo);

if (contaDoAndre.Sacar(300) == true) //IGUAL
{
    Console.WriteLine("Saldo da conta do André pós-saque = " + contaDoAndre.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente para saque.");
}
*/

/*
ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

contaDoAndre.Transferir(50, contaDaMaria);

Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);
*/

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta7 = new ContaCorrente(285, "1111-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
