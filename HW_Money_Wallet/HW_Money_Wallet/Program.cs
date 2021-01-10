using System; // komentar vytvoreny jako zmena souboru pri samostudiu githubu

namespace HW_Money_Wallet
{

    class Program
    {
        static void Main(string[] args)
        {
            var wallet1 = new Wallet();
            wallet1.AddMoney(10000);
            wallet1.AddMoney(3500);
            wallet1.WithdrawMoney(2000);
            wallet1.AddMoney(500);
            wallet1.WithdrawMoney(3000);
            wallet1.CurrentMoney();

            Console.Read();
        }
    }
}
