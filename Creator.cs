using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piekarnia
{
    public abstract class Creator
    {
        public abstract IProdukt Piekarz();

        public string Wypiekanie()
        {
            var produkt = Piekarz();
            var wynik = produkt.Wypiecz();
            return wynik;
        }
    }
}
