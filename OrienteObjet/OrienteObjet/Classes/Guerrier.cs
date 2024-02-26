using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrienteObjet.Classes
{
    internal class Guerrier : Personnage
    {
        public override int Endu { get => base.Endu +3; set => base.Endu = value; }
        public override int Force { get => base.Force +3; set => base.Force = value; }



    }
}
