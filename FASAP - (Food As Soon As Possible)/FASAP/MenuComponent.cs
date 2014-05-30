using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmetkaZaNaracka
{
    public abstract class MenuComponent
    {
        public MenuComponent MakeOrder() { return null; }

        public abstract string GetDescription();

        public abstract int ComputeCost();

        public abstract string Print(string indent);

        public abstract void AddComp(MenuComponent mc);

        public abstract void RemoveComp(MenuComponent mc);
    }
}
