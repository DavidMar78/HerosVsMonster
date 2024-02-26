using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrienteObjet.Classes
{
    internal class Personnage
    {
        public  string _Nom;
        int _force;
        int _endu;
        int _intel;
        int _sagesse;

        public virtual int Force //permet de mettre des conditions ou modifier la valeur en dehors 
        {
            get { return _force; } //ajouter le bonus en lecture seul pour ne pas modif la valeur de base 
            set { _force = value; }
        }
        public virtual int Endu
        {
            get { return _endu; }
            set { _endu = value; }
        }
        public virtual int Sagesse
        {
            get { return _sagesse; }
            set { _sagesse = value; }
        }
        public virtual int Intel
        {
            get { return _intel; }
            set { _intel = value; }
        }

        public void CalculCaract()
        {
            Random rnd = new Random();
            Force = rnd.Next(10, 20);
            Endu = rnd.Next(10, 20);
            Sagesse = rnd.Next(10, 20);
            Intel = rnd.Next(10, 20);
        }

        public virtual void afficherCaract()
        {
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine($"Nom : {_Nom}");
            Console.WriteLine($"Force : {Force} ({_force})");
            Console.WriteLine($"Endu : {Endu} ({_endu})");
            Console.WriteLine($"Intel : {Intel} ({_intel})");
            Console.WriteLine($"Sagesse : {Sagesse} ({_sagesse})");
        }
    }
}
