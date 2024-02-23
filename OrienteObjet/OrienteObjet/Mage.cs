﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrienteObjet
{
    internal class Mage
    {
        public string _Nom;
        int _Force;
        int _Endu; 
        int _Intel;
        int _Sagesse;

        public int Sagesse
        {
            get { return _Sagesse; }
            set { _Sagesse = value + 2; }
        }
        public int Intel
        {
            get { return _Intel; }
            set { _Intel = value + 4; }
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
        public int CalculCaract()
        {
            Random rnd = new Random();
            return rnd.Next(10, 20);
        }
    }
}
