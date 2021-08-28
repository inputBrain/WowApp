using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowApp.Host.Interfaces
{
    interface IWeapon
    {
        public abstract string Name { get; set; }
        public abstract int Damage { get; }
        public abstract string Description { get; }
        void Fire();
    }
}
