using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hegyescsucsos
{
    class Hegycsucsosztaly
    {
        string nev;
        string hegyseg;
        int magassag;

        public Hegycsucsosztaly(string nev, string hegyseg, int magassag)
        {
            this.nev = nev;
            this.hegyseg = hegyseg;
            this.magassag = magassag;
        }

        public string Nev { get => nev;}
        public string Hegyseg { get => hegyseg;}
        public int Magassag { get => magassag;}
    }
}
