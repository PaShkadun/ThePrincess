using System;
using System.Collections.Generic;
using System.Text;

namespace ThePrincess
{
    class Mine
    {
        public string Status { get; private set; }
        public int Damage { get; private set; }

        public void InactiveMine()
        {
            Status = "Inactive";
        }

        public Mine(int damage)
        {
            Status = "Active";
            Damage = damage;
        }
    }
}
