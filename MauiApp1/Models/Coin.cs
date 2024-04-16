using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    internal class Coin
    {
        public int Lados { get; set; } = 2;

        public int Girar()
        {
            return Random.Shared.Next(0, Lados);
        }

    }
}
