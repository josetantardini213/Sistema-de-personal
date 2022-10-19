using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.de.personal
{
    internal class Familiar : Persona
    {
        private Parentescos parentesco;

        private int Legajo;
        
        public void setParentesco(String parentesco)
        {
            this.parentesco = (Parentescos)Enum.Parse(typeof(Parentescos), parentesco);
            
        }
        public String getParentesco()
        {
            return parentesco.ToString();
        }

        public void setLegajo(int legajo)
        {
            this.Legajo = legajo;
        }

        public int getLegajo()
        {
            return Legajo;
        }

    }
}
