using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmetkaZaNaracka
{
    public class Stavka : MenuComponent
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Opis { get; set; }
        public int Cena { get; set; }
        public bool Validnost { get; set; }
        public bool Dodatok { get; set; }

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
