using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brand
{
    internal class Notebook : Product
    {
        private string _opSystem;
        private string _processor;
        private bool _hasGraphicCard;

        public Notebook(string opSystem, string processor)
        {
            _opSystem = opSystem;
            _processor = processor;
        }
        public Notebook(bool hasGraphicCard) : this.(string opSystem, string processor) {
            _hasGraphicCard = hasGraphicCard;
            }
    }
}
