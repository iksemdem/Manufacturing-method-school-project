using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Piekarnia
{
    public class Piekarnia
    {
        public void Main()
        {
            Console.WriteLine("Aplikacja: Włączono z Ciastkiem.");
            ClientCode(new WypiekanieCiastka());

            Console.WriteLine("");

            Console.WriteLine("Aplikacja: Włączono z Chlebem.");
            ClientCode(new WypiekanieChleba());
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Klient; Nie wiem co się piecze, ale wiem że się piecze.\n" + creator.Wypiekanie());
        }
        
    }
}
