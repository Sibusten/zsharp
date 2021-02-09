using System;
using Sibusten.ZSharp.Variables;

namespace Sibusten.ZSharp.Output
{
    public class OutputSelector<TNext>
    {
        private TNext _next;

        public OutputSelector(TNext next)
        {
            _next = next;
        }

        public VariableSelector<TNext> c => new VariableSelector<TNext>(var => { Console.Write(var); return _next; });
    }
}
