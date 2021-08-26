using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WowApp.Host.Objects.Box
{
    class Chest : StandardObject
    {
        private string _name = "Сундук";
        private string _color = "Желтый";
        private int _id = 0;
        public override string Name { get => _name ; set => _name = value; }
        public override string Color { get => _color ; set => _color = value; }
        public override int Id { get => _id; set => _id = value; }

        public override void ShowInfo(string infoType)
        {
            if(infoType == "Full")
            {
                WriteLine(_name + " " + _color + " ID_" + _id);
            }
            else
            {
                WriteLine(_name);
            }
        }
    }
}
