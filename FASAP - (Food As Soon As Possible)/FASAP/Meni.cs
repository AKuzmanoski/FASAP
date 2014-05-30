using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmetkaZaNaracka
{
    public class Meni : MenuComponent
    {
        public string Ime { get; set; }
        public bool Validnost { get; set; }
        public Dictionary<string, MenuComponent> Podmeni { get; set; }

        public override string GetDescription()
        {
            throw new NotImplementedException();
        }

        public override int ComputeCost()
        {
            throw new NotImplementedException();
        }

        public override string Print(string indent)
        {
            throw new NotImplementedException();
        }

        public override void AddComp(MenuComponent mc)
        {
            throw new NotImplementedException();
        }

        public override void RemoveComp(MenuComponent mc)
        {
            throw new NotImplementedException();
        }
    }
}
