using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrienteObjet.Classes
{
    internal class Mage : Personnage
    {
        public override int Intel { get => base.Intel + 4; set => base.Intel = value; }
        public override int Sagesse { get => base.Sagesse + 2; set => base.Sagesse = value; }
    }
}
