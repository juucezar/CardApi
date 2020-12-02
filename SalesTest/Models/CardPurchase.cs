using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardAPI
{
    public class CardPurchase
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public int IdCardReceit { get; set; }
    }
}
