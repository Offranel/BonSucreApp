using System;
using System.Collections.Generic;
using System.Text;

namespace BonSucreApp.Models
{
    internal class Review
    {
        public int ReviewId { get; set; }
        public int CustomerId { get; set; }
        public int DessertId { get; set; }
        public int Score { get; set; }
    }
}
