using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrienteObjet.Classes
{
    internal class Pretre
    {
        public string _Nom;
        int _Force;
        int _Endu;
        int _Intel;
        int _Sagesse;

        public int Sagesse
        {
            get { return _Sagesse +4; }
            set { _Sagesse = value ; }
        }
        public int Intel
        {
            get { return _Intel +2; }
            set { _Intel = value ; }
        }
        public int Force
        {
            get { return _Force; }
            set { _Force = value; }
        }
        public int Endu
        {
            get { return _Endu; }
            set { _Endu = value; }
        }
        public void CalculCaract()
        {
            Random rnd = new Random();
            Force = rnd.Next(10, 20);
            Endu = rnd.Next(10, 20);
            Sagesse = rnd.Next(10, 20);
            Intel = rnd.Next(10, 20);
        }
    }
}
