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

        /// <summary>
        /// Console.Write
        /// </summary>
        public VariableSelector<TNext> c => new VariableSelector<TNext>(_engine, variable =>
        {
            Console.Write(variable);
            return _next;
        });

        /// <summary>
        /// Console.WriteLine
        /// </summary>
        /// <value></value>
        public VariableSelector<TNext> C => new VariableSelector<TNext>(_engine, variable =>
        {
            Console.WriteLine(variable);
            return _next;
        });
    }
}
