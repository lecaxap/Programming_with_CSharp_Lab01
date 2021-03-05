using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Transaction
    {
        private int id;
        private decimal sum;
        private string description;
        private string currency;
        private Category category;
        private DateTime date;
        //private File file;

        public string Description { get => description; set => description = value; }
        public string Currency { get => currency; set => currency = value; }
        public decimal Sum { get => sum; set => sum = value; }
        public DateTime Date { get => date; set => date = value; }
        internal Category Category { get => category; set => category = value; }
        public int Id { get => id; set => id = value; }

    }
}
