using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelProje.Repos
{
    public class AboneCreate
    {
        public int AboneId { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Tel { get; set; }
        public string? Adress { get; set; }
        public int Deposit { get; set; }
        public int Balance { get; set; }
        public bool AboneSituation { get; set; }

    }
}
