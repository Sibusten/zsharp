using System;
using Sibusten.ZSharp.Flow;
using Sibusten.ZSharp.Variables;

namespace Sibusten.ZSharp.Output
{
    public class OutputSelector<TNext>
    {
        private readonly Block _block;
        private readonly TNext _next;

        public OutputSelector(Block block, TNext next)
        {
            _block = block;
            _next = next;
        }

        /// <summary>
        /// Console.Write
        /// </summary>
        public VariableSelector<TNext> c => new VariableSelector<TNext>(variableCallback =>
        {
            _block.AddStatement(context => Console.Write(variableCallback(context)));
            return _next;
        });

        /// <summary>
        /// Console.WriteLine
        /// </summary>
        /// <value></value>
        public VariableSelector<TNext> C => new VariableSelector<TNext>(variableCallback =>
        {
            _block.AddStatement(context => Console.WriteLine(variableCallback(context)));
            return _next;
        });
    }
}
