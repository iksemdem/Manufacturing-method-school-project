using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piekarnia
{
    internal class Ciastko : IProdukt
    {
        public string Wypiecz()
        {
            return "Wypieczono Ciastko";
        }
    }
}
