﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piekarnia
{
    public class WypiekanieChleba : Creator
    {
        public override IProdukt Piekarz()
        {
            return new Chleb();
        }
    }
}