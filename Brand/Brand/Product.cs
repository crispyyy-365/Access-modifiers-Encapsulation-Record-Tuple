using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Brand
{
    internal class Product
    {
        protected string _id;
        protected string _brandname {  get; set; }
        protected string _model {  get; set; }
        protected decimal _price { get; set; }
        protected decimal _cost { get; set; }

        protected decimal _income;

        protected int _count =0;

        public Product(string brandname, string model ,decimal price, decimal cost, int count)
        {
            _brandname = brandname;
            _model = model;
            _price = price;
            _cost = cost;
            _count = count;
            _income = 0;
        }
        public string Id
        {
            get { return _id; }
            set { _id = _brandname.Substring(0, 2) + _model.Substring(0, 2); }
        }
        public int count
        {
            get { return _count; }
            set
            {
                _count = value < 0 ? -value : value; 
            }
        }
        public decimal Income
        {
            get { return _income; }
            set
            {
                _income += (_price * count) - (_cost * count);
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"ID : {Id} , Brand Name : {_brandname} , Model : {_model} , Price : {_price} , Cost : {_cost} , Income : {Income} , Count : {count}.");
        }
    }
}
