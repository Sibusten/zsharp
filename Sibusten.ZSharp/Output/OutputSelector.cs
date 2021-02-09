using System;
using Sibusten.ZSharp.Variables;

namespace Sibusten.ZSharp.Output
{
    public class OutputSelector<TNext>
    {
        private readonly ZEngine _engine;
        private readonly TNext _next;

        public OutputSelector(ZEngine engine, TNext next)
        {
            _engine = engine;
            _next = next;
        }

        public VariableSelector<TNext> c => new VariableSelector<TNext>(_engine, var => { Console.Write(var); return _next; });
    }
}
