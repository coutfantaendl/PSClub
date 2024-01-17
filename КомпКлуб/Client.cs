using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace КомпКлуб
{
    internal class Client
    {
        private int _money;
        private int _moneyToPay;

        public int DesiredMinutes {  get; private set; }

        public Client(int money,Random random)
        {
            _money = money;
            DesiredMinutes = random.Next(10,30);
        }
        public bool ChekSolvency(Computer computer)
        {
            _moneyToPay = DesiredMinutes * computer.PricePerMinute;
            if(_money >= _moneyToPay)
            {
                return true;
            }
            else
            {
                _moneyToPay = 0;
                return false;
            }
        }
        public int Pay()
        {
            _money -= _moneyToPay;
            return _moneyToPay;
        }
    }
}
