using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardAPI
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string CPF { get; set; }
        public int IdCard { get; set; }
        public string Address { get; set; }
        public int IdUserLogin { get; set; }
    }
}
