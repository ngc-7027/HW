using System;

namespace HW_Money_Wallet
{
    public class Wallet
    {
        private int _currentMoney = 0;

        public void AddMoney(int moneyToAdd)
        {
            if (moneyToAdd <= 0)
            {
                Console.WriteLine("Vkládaná částka musí být větší než 0.");
            }
            else if ((_currentMoney + moneyToAdd) > 5000)
            {
                Console.WriteLine("Nedošlo k vložení peněz do peněženky. Celková částka v peněžence nesmí být větší než 5 000 Kč.");
            }
            else
            {
                _currentMoney += moneyToAdd;
            }
        }

        public void WithdrawMoney(int moneyToWithdraw)
        {
            if (moneyToWithdraw <= 0)
            {
                Console.WriteLine("Vámi požadovanou částku nelze vybrat. Ověřte správnost požadavku.");
            }
            else if (_currentMoney < moneyToWithdraw)
            {
                Console.WriteLine("Z peněženky nelze vybrat více peněz, než kolik se v ní aktuálně nachází.");
            }
            else
            {
                _currentMoney -= moneyToWithdraw;
            }
        }

        public void CurrentMoney()
        {
            Console.WriteLine(_currentMoney);
        }
    }
}
