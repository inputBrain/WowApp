using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WowApp.Host.Objects.Items
{
    class Pickaxe : StandartObject
    {
        private string _name = "Кирка";
        private string _color = "";
        private int _id = 002;
        public override string Name { get => _name; set => _name = value; }
        public override string Color { get => _color; set => _color = value; }
        public override int Id { get => _id; set => _id = value; }

        public override void ShowInfo(string infoType)
        {
            if (infoType == "Full")
            {
                WriteLine(_name + "" + _color + " ID_" + _id);
            }
            else
            {
                WriteLine(_name);
            }
        }
    }
}
