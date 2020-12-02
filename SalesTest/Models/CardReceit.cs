using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardAPI
{
    public class CardReceit
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string IsPaid { get; set; }
        public decimal Value { get; set; }
        public int IdClient { get; set; }
        public decimal PaidValue { get; set; }
        public DateTime PaidDate { get; set; }
    }
}
