using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrienteObjet.Classes
{
    internal class Pretre : Personnage
    {
        public override int Intel { get => base.Intel +2; set => base.Intel = value; }
        public override int Sagesse { get => base.Sagesse +4; set => base.Sagesse = value; }
    }
}
