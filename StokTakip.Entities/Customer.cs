using System;
using System.Collections.Generic;

namespace StokTakip.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
