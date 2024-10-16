using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Brand
{
    internal class Phone : Product
    {
        private int _ram;
        private string _color = "black";
        private decimal _balance;
        public Phone(string brandname, string model, decimal price, decimal cost, int count ,int ram) //inheritance alinmadi
        {
            _ram = ram;
            _balance = 0;
        }
        public int ram
        {
            get { return _ram; }
            set
            {
                _ram = value < 0 ? -value : value;
            }
        }
        public decimal balance
        {
            get { return _balance; }
            set
            {
                if (_balance == 0)
                {
                    Console.WriteLine("Balans yoxdur");
                }
                else if (_balance < 0)
                {
                    Console.WriteLine("Bele balans olmur");
                }
                else
                {
                    _balance = value;
                }
            }
        }
        public void Calls()
        {
            decimal seconds = 45;
            decimal valueOneSec = 0.01m;
            _balance -= seconds * valueOneSec;
        }
        public void Pay()
        {
            decimal money = 40;
            _balance += money;
        }
    }
}
