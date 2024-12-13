using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalCursWork
{
    public class DealRecord
    {
        private DateTime _date;
        public DateTime Date
        {
            get => _date;
            set
            {
                if (value.Year < 2020 || value.Year > DateTime.Now.Year)
                    throw new ArgumentException("Дата постройки должна быть между 2020 и текущим годом.");
                _date = value;
            }
        }

        public decimal Profit { get; set; }
    }
}
