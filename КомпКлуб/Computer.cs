using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КомпКлуб
{
    internal class Computer
    {
        private Client _client;
        private int _minutseRemaining;

        public  bool IsTaken
        {
            get
            {
                return _minutseRemaining > 0;
            }
        }

        public int PricePerMinute {  get; private set; }

        public Computer(int pricePerMinute)
        {
            PricePerMinute = pricePerMinute;
        }
        public void BecomeTaken(Client client)
        {
            _client = client;
            _minutseRemaining = _client.DesiredMinutes;
        }
        public void BecomeEmpty()
        {
            _client = null;
        }
        public void SpendOneMinute()
        {
            _minutseRemaining--;
        }
        public void ShowState()
        {
            if (IsTaken)
                Console.WriteLine($"Компьютер занят, осталось минут: {_minutseRemaining}");
            else
                Console.WriteLine($"Компьютер свободен,цена за минуту: {PricePerMinute}");
        }
    }
}
